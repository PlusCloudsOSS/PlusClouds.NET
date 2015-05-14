using System.Collections.Generic;
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

        public static IRestResponse Execute(this RestClient client, string resource, Method method = Method.POST)
        {
            return client.Execute(new RestRequest(resource, method));
        }
    }
}