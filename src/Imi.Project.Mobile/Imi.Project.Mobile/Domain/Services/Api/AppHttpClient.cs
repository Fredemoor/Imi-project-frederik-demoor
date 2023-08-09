using Imi.Project.Mobile.Domain.Services.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class AppHttpClient : HttpClient, IAppHttpClient
    {
        private readonly string baseUri;

        public AppHttpClient(string baseUri) : base(CreateClientHandler())
        {
            this.baseUri = baseUri;
        }

        private static HttpClientHandler CreateClientHandler()
        {
            var httpClientHandler = new HttpClientHandler();
#if DEBUG
            //allow connecting to untrusted certificates when running a DEBUG assembly
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => { return true; };
#endif
            return httpClientHandler;
        }

        private static JsonMediaTypeFormatter GetJsonFormatter()
        {
            var formatter = new JsonMediaTypeFormatter();

            formatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            return formatter;
        }

        public async Task<T> GetApiResult<T>(string endpoint)
        {
            using (HttpClient httpClient = new HttpClient(CreateClientHandler()))
            {
                string response = await httpClient.GetStringAsync($"{baseUri}/{endpoint}");
                return JsonConvert.DeserializeObject<T>(response, GetJsonFormatter().SerializerSettings);
            }
        }

        public async Task<TOut> PostCallApi<TOut, TIn>(string endpoint, TIn entity)
        {
            return await CallApi<TOut, TIn>($"{baseUri}/{endpoint}", entity, HttpMethod.Post);
        }

        public async Task<TOut> PutCallApi<TOut, TIn>(string endpoint, TIn entity)
        {
            return await CallApi<TOut, TIn>($"{baseUri}/{endpoint}", entity, HttpMethod.Put);
        }

        public async Task<TOut> DeleteCallApi<TOut>(string endpoint)
        {
            return await CallApi<TOut, object>($"{baseUri}/{endpoint}", null, HttpMethod.Delete);
        }

        private async Task<TOut> CallApi<TOut, TIn>(string uri, TIn entity, HttpMethod httpMethod)
        {
            TOut result = default;

            using (HttpClient httpClient = new HttpClient(CreateClientHandler()))
            {
                HttpResponseMessage response;
                if (httpMethod == HttpMethod.Post)
                {
                    response = await httpClient.PostAsync(uri, entity, GetJsonFormatter());
                }
                else if (httpMethod == HttpMethod.Put)
                {
                    response = await httpClient.PutAsync(uri, entity, GetJsonFormatter());
                }
                else
                {
                    response = await httpClient.DeleteAsync(uri);
                }
                result = await response.Content.ReadAsAsync<TOut>();
            }
            return result;
        }
    }
}
