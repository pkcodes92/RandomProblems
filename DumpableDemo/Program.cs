namespace DumpableDemo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            IDumpable[] a =
            {
                new Fraction(10, 3), 
                new Fraction(9, 4), 
                new Person("Tom", "INDIA", 99556677), 
                new Person("Jerry", "USA", 516444778)
            };

            a[0].Name = "f1";
            a[1].Name = "f2";

            foreach (IDumpable obj in a)
            {
                Console.Write(obj.Name + ": ");
                obj.Dump();
            }

            Console.WriteLine("The program has finished execution - press any key to exit");
            Console.ReadKey(); 
        }
    }
}