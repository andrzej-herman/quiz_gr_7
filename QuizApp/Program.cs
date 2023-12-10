using QuizApp.backend;
using QuizApp.frontend;

var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
game.DrawQuestion();
var userNumber = Display.DisplayQuestion(game.CurrentQuestion);
var ifUserAnsweredCorrect = game.IsCorrectAnswer(userNumber);

if (ifUserAnsweredCorrect)
{
    Console.WriteLine("HURRA !!!");
}
else
{
    Console.WriteLine("GAME OVER !!!");
}















Console.ReadLine();
