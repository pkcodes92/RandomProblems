// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace CompanyBotStrategy
{
    using System;

    /// <summary>
    /// This is the main driver class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main driver method.
        /// </summary>
        /// <param name="args">The project specific command line arguments.</param>
        public static void Main(string[] args)
        {
            int[][] trainingData = new int[4][] { new int[] {3, 1},
                                                  new int[] {6, 1},
                                                  new int[] {4, 1},
                                                  new int[] {5, 1} };

            double answerTime = BotStrategy(trainingData);

            Console.WriteLine($"The answer time is: {answerTime}");

            Console.WriteLine("The program execution has finished. You may now press any key to exit");
            Console.ReadKey(); 
        }

        private static double BotStrategy(int[][] trainingData)
        {
            int trainingSum = 0, trainingCount = 0;
            double average;

            for (int i = 0; i < trainingData.Length; i++)
            {
                if (trainingData[i][1] == 1)
                {
                    trainingCount++;
                    trainingSum += trainingData[i][0]; 
                }
            }

            if (trainingCount > 0 && trainingSum > 0)
            {
                average = (double)trainingSum / trainingCount; 
            }
            else
            {
                average = 0; 
            }

            return average;
        }
    }
}