using Imi.Project.Pin.Concept.Quiz.Interfaces;
using Imi.Project.Pin.Concept.Quiz.Models;
using Microsoft.AspNetCore.Components;

namespace Imi.Project.Pin.Concept.Quiz.Pages
{
    public partial class QuizCard
    {
        [Inject]
        private IQuizService ApiQuizService { get; set; }
        private List<Question> Questions;

        public QuizCard()
        {
            Questions = new List<Question>();
        }

        private int questionIndex = 0;
        private int score = 0;

        protected async void ResetGame()
        {
            Questions.Clear();
            questionIndex = 0;
            score = 0;

            await LoadQuestions();
            StateHasChanged();
        }

        protected void OptionSelected(string option)
        {
            if (option == Questions[questionIndex].CorrectAnswer)
            {
                score++;
            }
            questionIndex++;
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                await LoadQuestions();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected async Task LoadQuestions()
        {
            Questions = await ApiQuizService.GetQuestionsAsync();
            foreach (Question q in Questions)
            {
                q.IncorrectAnswers.Add(q.CorrectAnswer);
                Shuffle(q.IncorrectAnswers);
            }
        }

        protected void Shuffle(List<string> answers)
        {
            int lastIndex = answers.Count() - 1;
            while (lastIndex > 0)
            {
                string tempVal = answers[lastIndex];
                int randomIndex = new Random().Next(0, lastIndex);
                answers[lastIndex] = answers[randomIndex];
                answers[randomIndex] = tempVal;
                lastIndex--;
            }
        }
    }
}
