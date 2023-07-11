using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Services.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.IServices
{
    public interface IUserService
    {
        Task<AuthenticateResultModel> Login(string username, string password);
        Task<AuthenticateResultModel> Register(string username, string email, string password, DateTime birthdate, bool termsAndConditions);
        IQueryable<ApplicationUser> GetUsers();
    }
}
