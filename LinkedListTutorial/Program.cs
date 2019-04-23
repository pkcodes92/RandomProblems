/*
 * Author   : Pranav S. Krishnamurthy
 * 
 * Date     : 4th April 2018
 * 
 * Purpose  : Creating a C# console application to be able to 
 *            properly show the implementation of a LinkedList
 */

namespace LinkedListTutorial
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lnkList = new LinkedList();
            lnkList.PrintAllNodes();
            Console.WriteLine();

            lnkList.AddAtLast(12);
            lnkList.AddAtLast("John");
            lnkList.AddAtLast("Peter");
            lnkList.AddAtLast(34);
            lnkList.PrintAllNodes();
            Console.WriteLine();

            lnkList.AddAtStart(55);
            lnkList.PrintAllNodes();
            Console.WriteLine();

            lnkList.RemoveFromStart();
            lnkList.PrintAllNodes();

            Console.ReadKey();
        }
    }
}