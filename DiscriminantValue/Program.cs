namespace DiscriminantValue
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for A = ");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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

            Console.WriteLine("Program execution is completed - you may now press any key to exit");
            Console.ReadKey();
        }

        /// <summary>
        /// Function that will calculate the discriminant for a quadratic equation
        /// </summary>
        /// <param name="a">The coefficient for the variable of degree 2</param>
        /// <param name="b">The coefficient for the variable of degree 1</param>
        /// <param name="c">The constant value</param>
        /// <returns>An integer value which can determine the type of roots for a quadratic equation</returns>
        private static int CalculateDiscriminant(int a, int b, int c)
        {
            int discriminant = (int)Math.Pow(b, 2) - (4 * a * c);

            return discriminant;
        }
    }
}