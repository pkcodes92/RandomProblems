// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace CryptSolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] crypt = new string[] { "SEND", "MORE", "MONEY" };
            char[][] solution = new char[][] {new char[] {'O', '0' },
                                              new char[] {'M', '1'},
                                              new char[] {'Y', '2'},
                                              new char[] {'E', '5'},
                                              new char[] {'N', '6'},
                                              new char[] {'D', '7'},
                                              new char[] {'R', '8'},
                                              new char[] {'S', '9' }};

            bool isCryptSolution = IsCryptSol(crypt, solution);

            Console.WriteLine("Crypt Solution? {0}", isCryptSolution);
            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey(); 
        }

        static bool IsCryptSol(string[] crypt, char[][] solution)
        {
            List<char[]> wordHolder = new List<char[]>();
            wordHolder = crypt.Select(str => str.ToCharArray()).ToList();

            Dictionary<char, char> solutionHolder = new Dictionary<char, char>();
            for (int i = 0; i < solution.Length; i++)
            {
                solutionHolder.Add(solution[i][0], solution[i][1]); 
            }

            if (crypt.Length <= 2)
            {
                return false;
            }

            int[] nums = new int[3];

            for (int i = 0; i < wordHolder.Count; i++)
            {
                for (int j = 0; j < wordHolder[i].Length; j++)
                {
                    if (wordHolder[i].Length > 1 &&
                        solutionHolder[crypt[i][0]] == '0')
                    {
                        return false;
                    }
                    else
                    {
                        nums[i] = nums[i] * 10 + (solutionHolder[crypt[i][j]] - '0');
                    }
                }
            }

            return nums[0] + nums[1] == nums[2];
        }
    }
}