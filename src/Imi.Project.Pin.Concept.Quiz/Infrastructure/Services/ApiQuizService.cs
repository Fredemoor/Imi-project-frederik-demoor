using Imi.Project.Pin.Concept.Consts;
using Imi.Project.Pin.Concept.Quiz.Infrastructure.Api.Dtos;
using Imi.Project.Pin.Concept.Quiz.Interfaces;
using Imi.Project.Pin.Concept.Quiz.Models;

namespace Imi.Project.Pin.Concept.Quiz.Infrastructure.Services
{
    public class ApiQuizService : IQuizService
    {
        private string baseUri = Constants.baseUri;
        protected IAppHttpCLient httpCLient;

        public ApiQuizService(IAppHttpCLient client)
        {
            httpCLient = client;

        }

        public async Task<List<Question>> GetQuestionsAsync()
        {
            var questionsFromApi = await httpCLient.GetApiResult<List<QuestionsDto>>($"{baseUri}");

            var questions = new List<Question>();
            questions.AddRange(questionsFromApi.Select(q => new Question
            {
                QuestionTitle = q.Question,
                Category = q.Category,
                CorrectAnswer = q.CorrectAnswer,
                IncorrectAnswers = q.IncorrectAnswers,

            }));
            return questions;
        }
    }
}
