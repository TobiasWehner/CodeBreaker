using System;
using static System.Console;
using System.Threading;

namespace CodeBreakerV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretInput;
            int secretNumber = 0;
            string Input;
            int number = 0;
            bool isNumber = false;
            bool isEqual = false;

            while (isNumber == false)
            {
                WriteLine("Spieler 1, Bitte eine Geheimzahl eingeben!");
                secretInput = ReadLine();
                isNumber = Int32.TryParse(secretInput, out secretNumber);
                Clear();
            }

            isNumber = false;

            while (isEqual == false)
            {
                while (isNumber == false)
                {
                    WriteLine("Spieler 2, Bitte eine Zahl eingeben!");
                    Input = ReadLine();
                    isNumber = Int32.TryParse(Input, out number);
                    Clear();
                }

                if (number == secretNumber)
                {
                    WriteLine("Die Zahl ist richtig");
                    isEqual = true;
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
                Thread.Sleep(1020);
                Clear();
                isNumber = false;
            }
            ReadLine();
        }
    }
}
