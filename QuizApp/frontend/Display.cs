﻿using System;
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
    }
}
