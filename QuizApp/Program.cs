using QuizApp.backend;

Console.WriteLine("Hello");


int x;
string z = "";
Question pytanie1 = new Question();
pytanie1.Category = 100;
pytanie1.Content = "Jak miał na imię Einstein?";
pytanie1.Answer_01 = "Albert";


Console.WriteLine(pytanie1.Content);
pytanie1 = null;
Console.WriteLine(pytanie1.Content);


Console.ReadLine();
