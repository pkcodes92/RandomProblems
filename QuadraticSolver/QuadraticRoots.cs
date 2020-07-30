namespace QuadraticSolver
{
    using System;

    /// <summary>
    /// This is the driver class.
    /// </summary>
    public static class QuadraticRoots
    {
        static double a, b, c;

        /// <summary>
        /// This method will be having the inputs being recorded from the console!
        /// </summary>
        public static void Read()
        {
            Console.WriteLine("\n To find the roots of the To find the roots of a quadratic equation of the form a*x^2 + b*x + c = 0");
            Console.Write("\n Enter value for a : ");
            a = double.Parse(Console.ReadLine());

            Console.Write("\n Enter a value for b : ");
            b = double.Parse(Console.ReadLine());

            Console.Write("\n Enter a value for c : ");
            c = double.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Method that will now compute the various information that will be required for considering this as a solution
        /// for the problem
        /// </summary>
        public static void Compute()
        {
            int m;
            double r1, r2, discriminant;

            discriminant = Math.Pow(b, 2) - (4 * a * c);

            if (a == 0)
            {
                m = 1;
            }
            else if (discriminant > 0)
            {
                m = 2;
            }
            else if (discriminant == 0)
            {
                m = 3;
            }
            else
            {
                m = 4;
            }

            switch (m)
            {
                case 1:
                    Console.WriteLine("\n Not a quadratic equation, linear equation");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("\n Roots are Real and Distinct");
                    r1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    r2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##}", r1);
                    Console.WriteLine("\n Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("\n Roots are Real and Equal");
                    r1 = r2 = (-b) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##}", r1);
                    Console.WriteLine("\n Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("\n Roots are Imaginary");
                    r1 = (-b) / (2 * a);
                    r2 = Math.Sqrt(-discriminant) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##} + i {1:#.##}", r1, r2);
                    Console.WriteLine("\n Second root is {0:#.##} - i {1:#.##}", r1, r2);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Not sure what is going on here!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}