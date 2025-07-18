using RestSharp;
using System.Net.Mime;
using Unit3Demo.Utils.Config;

namespace Unit3Demo.PetStoreAPI.Settings
{
    internal static class ApiClientFactory
    {
        private static readonly RestClient _client;

        static ApiClientFactory()
        {
            EnvironmentData environment = ConfigFileReader.GetEnvironmentData();
            var options = new RestClientOptions
            {
                BaseUrl = new Uri(environment.ApiUrl + environment.ApiVersion)
            };
            _client = new RestClient(options);
            _client.AddDefaultHeader(KnownHeaders.Accept, MediaTypeNames.Application.Json);
        }

        public static RestClient GetClient() => _client;
    }

}