namespace InheritanceRectangle
{
    using System;

    public class CalRectangle
    {
        static void Main(string[] args)
        {
            TableTop t = new TableTop(7.5, 8.04);
            t.Display();

            Console.WriteLine("Program execution has finished, you may now press any key to exit");
            Console.ReadKey(); 
        }
    }
}