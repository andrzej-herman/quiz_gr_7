using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; } = 100;

        public void CreateQuestions()
        {
            Questions = new List<Question>();

            var q1 = new Question();
            q1.Content = "Jak miał na imię Einstein?";
            q1.Category = 100;
            q1.Answer_01 = "Albert";
            q1.Answer_02 = "Adam";
            q1.Answer_03 = "John";
            q1.Answer_04 = "Tom";
            Questions.Add(q1);

            var q2 = new Question();
            q2.Content = "Jaka jest stolica Polski?";
            q2.Category = 200;
            q2.Answer_01 = "Warszawa";
            q2.Answer_02 = "Poznań";
            q2.Answer_03 = "Łódź";
            q2.Answer_04 = "Pabianice";
            Questions.Add(q2);
        }

        public Question DrawQuestion()
        {
            return Questions[0];
        }

    }
}
