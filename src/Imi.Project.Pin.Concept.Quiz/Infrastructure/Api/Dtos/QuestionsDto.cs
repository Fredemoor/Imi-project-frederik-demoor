namespace Imi.Project.Pin.Concept.Quiz.Infrastructure.Api.Dtos
{
    public class QuestionsDto
    {

        public string Category { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; set; }
        public string Question { get; set; }

    }
}
