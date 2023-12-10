using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; } = 100;
        public Question CurrentQuestion { get; set; }

        public void CreateQuestions()
        {
            // trzeba utworzyć prawidziwą listę pytań
            Questions = new List<Question>();

            var q1 = new Question();
            q1.Content = "Jak miał na imię Einstein?";
            q1.Category = 100;

            var a1 = new Answer();
            a1.Id = 1;
            a1.Content = "Albert";
            a1.IsCorrect = true;
            q1.Answers.Add(a1);

            var a2 = new Answer();
            a2.Id = 2;
            a2.Content = "Adam";
            q1.Answers.Add(a2);

            var a3 = new Answer();
            a3.Id = 3;
            a3.Content = "John";
            q1.Answers.Add(a3);

            var a4 = new Answer();
            a4.Id = 4;
            a4.Content = "Tom";
            q1.Answers.Add(a4);

            Questions.Add(q1);

        }

        public void DrawQuestion()
        {
            // trzeba naprawdę wyslosować pytanie
            CurrentQuestion =  Questions[0];
        }

        public bool IsCorrectAnswer(int number)
        {
            var userAnswer = CurrentQuestion.Answers.FirstOrDefault(x => x.Id == number);
            return userAnswer.IsCorrect;
        }

    }
}
