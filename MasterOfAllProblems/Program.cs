using System;

namespace MasterOfAllProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the RandomProblems app!");
            Console.WriteLine("Please enter a problem you want to solve: ");
            var problemChoice = Console.ReadLine();

            switch (problemChoice)
            {
                case "AbsoluteDifference":
                    ProblemSolver.AbsoluteDifference();
                    break;
                case "AcronymMaker":
                    ProblemSolver.AcronymMaker();
                    break;
                default:
                    Console.WriteLine($"Sorry I don't think that I have a sample of your problem: {problemChoice}");
                    break;
            }

            Console.WriteLine("Execution has completed, please press any key to exit...");
            Console.ReadKey();
        }
    }
}