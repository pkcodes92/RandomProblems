using System;

namespace CompanyBotStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] trainingData = new int[4][] { new int[] {3, 1},
            //                                      new int[] {6, 1},
            //                                      new int[] {4, 1},
            //                                      new int[] {5, 1} };
            int[][] trainingData2 = new int[6][] { new int[] {3, 1},
                                                   new int[] {6, 1},
                                                   new int[] {4, 1},
                                                   new int[] {5, 1},
                                                   new int[] {6, 0 },
                                                   new int[] {1, 1 } };

            double answerTime = BotStrategy(trainingData2);

            Console.WriteLine($"The answer time is: {answerTime}");

            Console.ReadKey(); 
        }

        static double BotStrategy(int[][] trainingData)
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
