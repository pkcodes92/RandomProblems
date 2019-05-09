namespace NumberGuessingGame
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int randomNumber = NewNumber(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 and 100 (0 will quit)");
                    int guessInt = int.Parse(Console.ReadLine());
                    if (guessInt == 0)
                    {
                        return;
                    }
                    else if (guessInt < randomNumber)
                    {
                        Console.WriteLine("Low, try again!");
                        ++count;
                        continue;
                    }
                    else if (guessInt > randomNumber)
                    {
                        Console.WriteLine("High, try again!");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Bingo! The number I thought about is {0}", randomNumber);
                        Console.WriteLine("It took you {0} {1}. \n", count, count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
        }

        static int NewNumber(int min, int max)
        {
            Random randomGen = new Random();
            return randomGen.Next(min, max);
        }
    }
}