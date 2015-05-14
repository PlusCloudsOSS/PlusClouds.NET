using System.Collections.Generic;
using System.Reflection;
using PlusClouds.Net.Attributes;
using PlusClouds.Net.Request;
using PlusClouds.Net.Response;
using RestSharp;

namespace PlusClouds.Net
{
    internal static class Extensions
    {
        public static TResponse Execute<TResponse>(this RestClient client, string resource, Method method,
            params KeyValuePair<string, object>[] parameters)
        {
            var request = new RestRequest(resource, method);

            foreach (var parameter in parameters)
            {
                request.AddParameter(new Parameter
                {
                    Name = parameter.Key,
                    Type = ParameterType.GetOrPost,
                    Value = parameter.Value
                });
            }

            return client.Execute<PlusResponseParent<TResponse>>(request).Data.Response;
        }

        public static TResponse Execute<TResponse>(this RestClient client, string resource, Method method,
            IRequest request)
        {
            return client.Execute<TResponse>(resource, method, request.CreateParameters());
        }

        public static IRestResponse Execute(this RestClient client, string resource, Method method = Method.POST)
        {
            return client.Execute(new RestRequest(resource, method));
        }

        private static KeyValuePair<string, object>[] CreateParameters(this IRequest request)
        {
            var properties = request.GetType().GetProperties();
            var parameterList = new List<KeyValuePair<string, object>>();

            foreach (var propertyInfo in properties)
            {
                var name = string.Empty;

                var nameAttr = propertyInfo.GetCustomAttribute<NameAttribute>();
                if (nameAttr != null)
                    name = nameAttr.Name;

                if (string.IsNullOrEmpty(name))
                    name = char.ToLowerInvariant(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);

                var value = propertyInfo.GetValue(request);

                parameterList.Add(new KeyValuePair<string, object>(name, value));
            }

            return parameterList.ToArray();
        }
    }
}