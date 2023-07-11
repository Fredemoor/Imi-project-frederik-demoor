using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Interfaces
{
    public interface IAppHttpClient
    {
        Task<T> GetApiResult<T>(string uri);

    }
}
