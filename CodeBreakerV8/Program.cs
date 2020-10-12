using System;
using static System.Console;
using System.Threading;

namespace CodeBreakerV8
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 2147483647;
            int average = (min + max) / 2;

            int minValue = 0;
            int maxValue = -1;
            Random rnd = new Random();
            int secretNumber = 0;
            string secretInput = "";
            string Input;
            int number = 0;
            bool isNumber = false;
            bool isEqual = false;
            int i = 1;
            while (minValue > maxValue)
            {
                while (isNumber == false)
                {
                    WriteLine("Spieler 1, gebe das untere Zahlen limit ein!", i);
                    secretInput = ReadLine();
                    isNumber = Int32.TryParse(secretInput, out minValue);
                    Clear();
                }
                isNumber = false;
                while (isNumber == false)
                {
                    WriteLine("Spieler 1, gebe das obere Zahlen limit ein!", i);
                    secretInput = ReadLine();
                    isNumber = Int32.TryParse(secretInput, out maxValue);
                    Clear();
                }
                isNumber = false;
            }
            try
            {
                secretNumber = rnd.Next(minValue, maxValue + 1);
            }
            catch
            {
                secretNumber = rnd.Next(minValue, maxValue);//um 2147483647 nicht zu zulassen
            }

            while (isEqual == false)
            {
                if (average == secretNumber)
                {
                    isEqual = true;
                }
                else if (average > secretNumber)
                {
                    max = average;
                    average = (min + max) / 2;
                }
                else if (average < secretNumber)
                {
                    min = average + 1;
                    average = (min + max) / 2;
                }
                isNumber = false;
                i++;
            }
            WriteLine("Die Zufallszahl war {0}.", secretNumber);
            WriteLine("Die errechnete Zahl ist {0}.", average);
        }
    }
}
