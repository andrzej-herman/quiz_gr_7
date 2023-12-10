using QuizApp.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.frontend
{
    public static class Display
    {
        public static void DisplayWelcome()
        {
            Console.WriteLine(" Witaj w Quizie");
            Console.WriteLine(" Spróbuj odpowiedzieć na 7 pytań" );
            Console.WriteLine(" Powodzenia !!!");
            Console.WriteLine();
            Console.Write(" Naciśnij ENTER, aby ropocząć grę ... ");
            Console.ReadLine();
        }

        public static int DisplayQuestion(Question question)
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine();
            Console.WriteLine($" Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();

            foreach (var answer in question.Answers)
            {
                Console.WriteLine($" {answer.Id}. {answer.Content}");
            }

            Console.WriteLine();
            // musimy gracza abu wcisnął 1 lub 2 lub 3 lub 4
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ...");

            return int.Parse(Console.ReadLine());
        }

    }
}
