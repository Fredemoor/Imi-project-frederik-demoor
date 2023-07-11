using Imi.Project.Pin.Concept.Quiz.Interfaces;
using System.Text.Json;

namespace Imi.Project.Pin.Concept.Quiz.Quiz.Infrastructure.Api
{
    public class AppHttpClient : HttpClient, IAppHttpCLient
    {


        public AppHttpClient() : base(CreateClientHandler())
        {

        }
        private static HttpClientHandler CreateClientHandler()
        {
            var httpClientHandler = new HttpClientHandler();
#if DEBUG
            //allow connecting to untrusted certificates when running a DEBUG assembly
#pragma warning disable CA1416 // Validate platform compatibility
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => { return true; };
#pragma warning restore CA1416 // Validate platform compatibility
#endif
            return httpClientHandler;
        }

        protected static JsonSerializerOptions _camelCaseOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public async Task<T> GetApiResult<T>(string uri)
        {
            string response = await GetStringAsync(uri);
            return JsonSerializer.Deserialize<T>(response, _camelCaseOptions);
        }
    }
}
