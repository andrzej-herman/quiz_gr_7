using QuizApp.backend;
using QuizApp.frontend;

var game = new Game();
Display.DisplayWelcome();
while(true)
{
    game.DrawQuestion();
    var userNumber = Display.DisplayQuestion(game.CurrentQuestion);
    var ifUserAnsweredCorrect = game.IsCorrectAnswer(userNumber);

    if (ifUserAnsweredCorrect)
    {
        if (game.IsLastQuestion())
        {
            Display.SuccessText(game.PlayerPoints);
            break;
        }
        else
        {
            Display.GoodAnswerText(game.CurrentQuestion.Category);
        }
    }
    else
    {
        Display.GameOverText();
        break;
    }
}


















