namespace QuadraticSolver
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            QuadraticRoots qr = new QuadraticRoots();
            qr.Read();
            qr.Compute();

            Console.WriteLine("Program execution has completed, press any key to exit");
            Console.ReadKey(); 
        }
    }
}