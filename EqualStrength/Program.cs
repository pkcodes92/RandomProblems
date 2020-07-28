// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace EqualStrength
{
    using System;

    /// <summary>
    /// This is the driver class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main entry point of execution.
        /// </summary>
        /// <param name="args">Project specific command line arguments.</param>
        public static void Main(string[] args)
        {
            int yourLeft = 10;
            int yourRight = 15;
            int friendsLeft = 15;
            int friendsRight = 10;

            bool result = AreEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight);

            Console.WriteLine($"Final result: {result}");
        }

        /// <summary>
        /// This method checks for equal strength.
        /// </summary>
        /// <param name="yourLeft">Strength in the left hand of person 1.</param>
        /// <param name="yourRight">Strength in the right hand of person 1.</param>
        /// <param name="friendsLeft">Strength in the left hand of person 2.</param>
        /// <param name="friendsRight">Strength in the right hand of person 2.</param>
        /// <returns></returns>
        public static bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            bool leftsEqual = false;
            bool rightsEqual = false;
            bool bothEqual;

            if ((yourRight == friendsRight) && (yourLeft == friendsLeft))
            {
                leftsEqual = true;
                rightsEqual = true;
            }
            else if ((yourRight == friendsLeft) && (friendsRight == yourLeft))
            {
                leftsEqual = true;
                rightsEqual = true;
            }

            if (leftsEqual && rightsEqual)
            {
                bothEqual = true;
            }
            else
            {
                bothEqual = false;
            }

            return bothEqual;
        }
    }
}