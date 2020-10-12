using System;
using static System.Console;

namespace CodeBreakerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber;
            int number;
            WriteLine("Spieler 1, Bitte eine Geheimzahl eingeben!");
            secretNumber = int.Parse(ReadLine());
            Clear();
            WriteLine("Spieler 2, Bitte eine Zahl eingeben.");
            number = int.Parse(ReadLine());
            if (number == secretNumber)
            {
                WriteLine("Die Zahl ist richtig");
            }
            else if (number > secretNumber)
            {
                WriteLine("Die eingegebene Zahl ist zu groß");
            }
            else if (number < secretNumber)
            {
                WriteLine("Die eingegebene Zahl ist zu klein");
            }
            else
            {
                WriteLine("Die Zahl nicht richtig");
            }
            ReadLine();
        }
    }
}
