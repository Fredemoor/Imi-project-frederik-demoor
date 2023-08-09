using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Interfaces;
using System.Net.Http;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Api
{
    public class ApiUserService : IUserService
    {

        private readonly string BaseUri = Constants.BaseUrl;
        protected AppHttpClient HttpClient;

        public ApiUserService(string baseUri, AppHttpClient httpClient)
        {
            BaseUri = baseUri;
            HttpClient = httpClient;
        }
        public async Task<User> Login(User user)
        {
            return await HttpClient.PostCallApi<User, User>($"api/Accounts/login", user);
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await HttpClient.PostCallApi<User, User>($"api/Accounts/register", user);
        }
        //public async Task<User> Login(User user)
        //{
        //    return await AppHttpClient
        //        .PostCallApi<User, User>($"{BaseUri}/api/Accounts/login", user);
        //}

        //public async Task<User> AddUserAsync(User user)
        //{
        //    return await AppHttpClient
        //        .PostCallApi<User, User>($"{BaseUri}/api/Accounts/register", user);

        //}

        public bool ValidateUserPassword(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
    }
}
