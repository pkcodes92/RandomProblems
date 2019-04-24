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
                    Console.WriteLine("Enter the EUR amount: ");
                    euro = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the EUR value: ");
                    value = double.Parse(Console.ReadLine());

                    inr = euro * value;
                    Console.WriteLine("{0} EUR equals to {1} INR", euro, inr);
                    break;
                case 3:
                    double ringgit, rup, valu;
                    Console.WriteLine("Enter the RM amount: ");
                    ringgit = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the RM value: ");
                    valu = double.Parse(Console.ReadLine());

                    rup = ringgit * valu;
                    Console.WriteLine("{0} RM equals to {1} INR", ringgit, valu); 
                    break;
            }

            Console.WriteLine("Program execution has completed, you may now press any key to exit");
            Console.ReadKey();
        }
    }
}