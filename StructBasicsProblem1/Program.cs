namespace StructBasicsProblem1
{
    using System;

    struct ValuesStruct
    {
        public int x;
        public int y; 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n Declaring a simple structure: \n");
            Console.Write("-----------------------------------\n");

            ValuesStruct primaryStruct = new ValuesStruct
            {
                x = int.Parse(Console.ReadLine()), 
                y = int.Parse(Console.ReadLine())
            };

            int sum = primaryStruct.x + primaryStruct.y;
            Console.WriteLine($"The sum of {primaryStruct.x} and {primaryStruct.y} is {sum}");

            Console.WriteLine("Execution of this program has completed. You may now press any key to exit");
            Console.ReadKey(); 
        }
    }
}