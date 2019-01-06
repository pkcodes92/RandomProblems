namespace DiscriminantValue
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for A = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter a value for B = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter a value for C = ");
            int c = int.Parse(Console.ReadLine());

            int discriminant = CalculateDiscriminant(a, b, c);

            if (discriminant > 0)
            {
                Console.WriteLine($"Discriminant = {discriminant} and there are 2 solutions");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine($"Discriminant = {discriminant} and there is only 1 solution");
            }
            else
            {
                Console.WriteLine($"Discriminant = {discriminant} and there are no real solutions");
            }

            Console.ReadKey();
        }

        private static int CalculateDiscriminant(int a, int b, int c)
        {
            int discriminant = (int)Math.Pow(b, 2) - (4 * a * c);

            return discriminant;
        }
    }
}