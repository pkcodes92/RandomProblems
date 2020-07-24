namespace TowersOfHanoiApp
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            TowerOfHanoi T = new TowerOfHanoi();
            string cNumDiscs;
            Console.Write("Enter the number of discs: ");
            cNumDiscs = Console.ReadLine();
            T.NumDiscs = Convert.ToInt32(cNumDiscs);
            T.MoveTower(T.NumDiscs, 1, 3, 2);
            Console.WriteLine("The program execution has completed - you may press any key to exit");
            Console.ReadKey(); 
        }
    }
}