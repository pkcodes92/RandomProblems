namespace AlternatingSums
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 40, 50, 60, 80, 10};

            int[] weights = FindAltSums(a);

            for (int i = 0; i < weights.Length; i++)
            {
                Console.Write(weights[i] + " ");
            }

            Console.WriteLine("Program execution has completed - you may know press any key to exit");
            Console.ReadKey(); 
        }

        static int[] FindAltSums(int[] a)
        {
            int[] weights = new int[2];

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    weights[0] += a[i];
                }

                if (i % 2 == 1)
                {
                    weights[1] += a[i];
                }
            }

            return weights;
        }
    }
}