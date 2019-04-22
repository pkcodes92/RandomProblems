namespace SpecialPythagoreanTriplet
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            BruteForce();
            NumberTheory();
            Console.WriteLine("Program execution has completed - you may press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// Going through the brute force approach - seeing how there would be some
        /// time taken for this solution to the problem
        /// </summary>
        static void BruteForce()
        {
            DateTime startTime = DateTime.Now;
            int a = 0, b = 0, c = 0;
            int s = 1000;
            bool found = false;

            for(a = 1; a < s/3; a++)
            {
                for (b = a; b < s/2; b++)
                {
                    c = s - a - b;
                    
                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;

            Console.WriteLine($"The pythagorean triple is {a}, {b}, {c}, and the sum is {a + b + c}");
            Console.WriteLine($"The product is {a * b * c}");
            Console.WriteLine($"Solution took {duration.Milliseconds} ms");
        }

        /// <summary>
        /// Approach using number theory and having the ability to see how
        /// the solution can also be devised through a recursive approach
        /// </summary>
        static void NumberTheory()
        {
            DateTime startTime = DateTime.Now;
            int a = 0, b = 0, c = 0;
            int s = 1000;
            int m = 0, k = 0, n = 0, d = 0;
            bool found = false;

            int mLimit = (int)Math.Sqrt(s / 2); 
            for (m = 2; m <= mLimit; m++)
            {
                // the value of m has been found
                if ((s / 2 % m) == 0)
                {
                    // ensuring to find an odd value for k
                    if (m % 2 == 0)
                    {
                        k = m + 1;
                    }
                    else
                    {
                        k = m + 2;
                    }

                    while (k < 2 * m && k <= s / (2 * m))
                    {
                        if ((s / (2 * m) % k) == 0 && Gcd(k, m) == 1)
                        {
                            d = s / 2 / (k * m);
                            n = k - m;
                            a = d * (m * m - n * n);
                            b = 2 * d * n * m;
                            c = d * (m * m + n * n);
                            found = true;
                            break;
                        }
                        k += 2;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            DateTime stopTime = DateTime.Now;
            TimeSpan duration = stopTime - startTime;

            Console.WriteLine($"The pythagorean triple is {a}, {b}, {c}, and the sum is {a + b + c}");
            Console.WriteLine($"The product is { a * b * c}");
            Console.WriteLine($"Solution took {duration.Milliseconds} ms");
        }

        private static int Gcd(int a, int b)
        {
            int y = 0;
            int x = 0; 

            if (a > b)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }

            while (x % y != 0)
            {
                int temp = x;
                x = y;
                y = temp % x; 
            }

            return y;
        }
    }
}