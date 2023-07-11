namespace Imi.Project.Pin.Concept.Quiz.Interfaces
{
    public interface IAppHttpCLient
    {
        Task<T> GetApiResult<T>(string uri);
    }
}
