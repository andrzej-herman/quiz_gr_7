using QuizApp.backend;
using QuizApp.frontend;
using System.ComponentModel;
var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
var question = game.DrawQuestion();


Console.ReadLine();
