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
        public Game()
        {
            Random = new Random();
            CreateQuestions();
            AllCategories = Questions.Select(x => x.Category).Distinct().ToList();
            CurrentCategory = AllCategories[CategoryIndex];
        }

        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }
        public int PlayerPoints { get; set; }
        public List<int> AllCategories { get; set; }
        public int CategoryIndex { get; set; }

        public void CreateQuestions()
        {
            Questions = QuestionCreator.GetQuestions();
        }

        public void DrawQuestion()
        {
            var questionsOfCategory = Questions.Where(x => x.Category == CurrentCategory).ToList();
            var number = Random.Next(0, questionsOfCategory.Count);
            var question = questionsOfCategory[number];
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();

            //for (int i = 0; i < question.Answers.Count; i++)
            //{
            //    question.Answers[i].DisplayOrder = i + 1;
            //}

            var n = 1;
            foreach (var answer in question.Answers)
            {
                answer.DisplayOrder = n++;
            }



            CurrentQuestion = question;
        }

        public bool IsCorrectAnswer(int number)
        {
            var userAnswer = CurrentQuestion.Answers.FirstOrDefault(x => x.DisplayOrder == number);
            var isCorrect = userAnswer.IsCorrect;
            if (isCorrect)
            {
                PlayerPoints += CurrentQuestion.Category;
            }

            return isCorrect;
        }

        public bool IsLastQuestion()
        {
            if (CategoryIndex >= AllCategories.Count - 1)
            {
                return true;
            }
            else
            {
                CategoryIndex++;
                CurrentCategory = AllCategories[CategoryIndex];
                return false;

            }
        }

    }
}
