namespace LuhnValidator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var sampleNumber = "5177 0547 5647 2315";
            var expectedResult = true;

            Console.WriteLine(expectedResult == Luhn.IsValid(sampleNumber) ? "Yahtzee, it works!" : "Not quite working yet");
            Console.WriteLine("The program execution has ended - please press any key to exit");

            Console.ReadKey();
        }
    }
}