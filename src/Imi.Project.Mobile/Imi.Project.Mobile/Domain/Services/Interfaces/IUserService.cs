using Imi.Project.Mobile.Domain.Models;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> Login(User user);
        Task<User> AddUserAsync(User user);
        bool ValidateUserPassword(string password, string ConfirmPassword);
    }
}
