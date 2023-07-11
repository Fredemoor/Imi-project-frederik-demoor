namespace Imi.Project.Pin.Concept.Quiz.Models
{
    public class Question
    {
        public string Category { get; set; }
        public string QuestionTitle { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> IncorrectAnswers { get; set; }
    }
}
