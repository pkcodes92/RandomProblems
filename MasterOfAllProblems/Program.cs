using System;

namespace MasterOfAllProblems
{
    /// <summary>
    /// This is the main driver class for this application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This method is the main entry point of execution.
        /// </summary>
        public static void Main()
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
                case "AllLongestStrings":
                    ProblemSolver.AllLongestStrings();
                    break;
                case "AlternatingSums":
                    ProblemSolver.AlternatingSums();
                    break;
                case "ArrayElementsMultiplication":
                    ProblemSolver.ArrayElementsMultiplication();
                    break;
                case "ArrayLeftRotation":
                    ProblemSolver.ArrayLeftRotation();
                    break;
                case "ArrayReplacement":
                    ProblemSolver.ArrayReplacement();
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