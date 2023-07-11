
using Imi.Project.Pin.Concept.Quiz.Models;

namespace Imi.Project.Pin.Concept.Quiz.Interfaces
{
    public interface IQuizService
    {
        Task<List<Question>> GetQuestionsAsync();
    }
}
