namespace CurrencyConversion
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter your choice: \n 1- Dollar to Rupee \n 2- Euro to Rupee \n 3- Malaysian Ringgit to Rupee ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double dollar, rupee, val;
                    Console.WriteLine("Enter the USD amount: ");
                    dollar = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the USD value: ");
                    val = double.Parse(Console.ReadLine());

                    rupee = dollar * val;
                    Console.WriteLine("{0} USD equals to {1} INR", dollar, rupee);
                    break;
                case 2:
                    double euro, inr, value;
                    // TODO - finish off this later
                    break;
            }

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }
    }
}