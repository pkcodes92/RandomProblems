namespace OnlyEvenNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = 248622;

            bool result = EvenDigitsOnly(n);

            Console.WriteLine($"Does {n} contain only even digits? {result}");

            Console.ReadKey();
        }

        static bool EvenDigitsOnly(int n)
        {
            var finalRes = true; 
            int temp = n;
            while (temp > 0)
            {
                if (temp % 2 != 0)
                {
                    finalRes = false;
                }

                temp = temp / 10; 
            }

            return finalRes; 
        }
    }
}