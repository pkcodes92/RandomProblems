namespace ElectionWinners
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] votesIn = new int[] { 2, 3, 5, 2 };
            int k = 2;

            int result = ElectionsWinners(votesIn, k);

            Console.WriteLine($"The final result: {result}");

            Console.ReadKey(); 
        }

        static int ElectionsWinners(int[] votes, int k)
        {
            int max = votes.Max();
            if (k == 0)
            {
                return votes.Count(x => x == max) > 1 ? 0 : 1;
            }

            return votes.Count(x => x + k > max);
        }
    }
}
