using System;
using static System.Console;
using System.Threading;

namespace CodeBreakerV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 1000);
            string Input;
            int number = 0;
            bool isNumber = false;
            bool isEqual = false;
            int i = 1;

            while (isEqual == false)
            {
                while (isNumber == false)
                {
                    WriteLine("Dein {0}. Versuch Spieler 2, gebe bitte eine Zahl ein!", i);
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
                i++;
            }
            ReadLine();
        }
    }
}
