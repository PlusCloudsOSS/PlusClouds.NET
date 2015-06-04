using System;
using System.Collections.Generic;
using System.Reflection;
using PlusCloudsNet.Attributes;
using PlusCloudsNet.Request;
using PlusCloudsNet.Response;
using RestSharp;

namespace PlusCloudsNet
{
    internal static class Extensions
    {
        public static TResponse Execute<TResponse>(this PlusClouds client, string resource, Method method,
            params KeyValuePair<string, object>[] parameters) where TResponse : new()
        {
            var request = new RestRequest(resource, method) {RequestFormat = DataFormat.Json};

            foreach (var parameter in parameters)
            {
                request.AddParameter(new Parameter
                {
                    Name = parameter.Key,
                    Type = ParameterType.GetOrPost,
                    Value = parameter.Value
                });
            }

            var result = client.ApiClient.Execute<PlusResponseParent<TResponse>>(request);
            return result.Data.Response;
        }

        public static TResponse Execute<TResponse>(this PlusClouds client, string resource, Method method,
            IRequest request) where TResponse : new()
        {
            var tokenizedRequest = request as AccessTokenizedRequest;
            if (tokenizedRequest != null)
            {
                if (client.Config.AutoUpdateSession)
                {
                    if (client.AuthenticateResponse == null || (!client.AuthenticateResponse.Result && client.AuthenticateResponse.Expires >= DateTime.Now.Ticks))
                        client.Auth.Authenticate();
                    client.Auth.AccessToken();
                }

                tokenizedRequest.AccessToken = client.AuthenticateResponse.AccessToken;
            }

            return client.Execute<TResponse>(resource, method, request.CreateParameters(client.Config));
        }

        public static IRestResponse Execute(this PlusClouds client, string resource, Method method = Method.POST)
        {
            return client.ApiClient.Execute(new RestRequest(resource, method));
        }

        private static KeyValuePair<string, object>[] CreateParameters(this IRequest request,
            PlusCloudsConfig plusCloudsConfig)
        {
            var properties = request.GetType().GetProperties(
                BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);
            var parameterList = new List<KeyValuePair<string, object>>();

            foreach (var propertyInfo in properties)
            {
                var name = string.Empty;

                var nameAttr = propertyInfo.GetCustomAttribute<NameAttribute>();
                if (nameAttr != null)
                    name = nameAttr.Name;

                if (string.IsNullOrEmpty(name))
                    name = char.ToLowerInvariant(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);

                object value;

                if (propertyInfo.PropertyType == typeof (DateTime))
                {
                    value = ((DateTime) propertyInfo.GetValue(request)).ToString(plusCloudsConfig.DateTimeFormat);
                }
                else
                {
                    value = propertyInfo.GetValue(request);
                }

                if (!value.IsNullOrDefault())
                {
                    parameterList.Add(new KeyValuePair<string, object>(name, value));
                }
            }

            return parameterList.ToArray();
        }

        public static object GetDefaultValue(this Type t)
        {
            if (!t.IsValueType || Nullable.GetUnderlyingType(t) != null)
                return null;

            return Activator.CreateInstance(t);
        }

        public static bool IsNullOrDefault(this object value)
        {
            return value == null || value.Equals(value.GetType().GetDefaultValue());
        }
    }
}