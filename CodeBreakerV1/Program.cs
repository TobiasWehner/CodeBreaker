using System;
using static System.Console;

namespace CodeBreakerV1
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
            else
            {
                WriteLine("Die Zahl nicht richtig");
            }
            ReadLine();
        }
    }
}