namespace InheritanceRectangle
{
    using System;

    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class TableTop : Rectangle
    {
        private readonly double cost;
        public TableTop(double l, double w): base(l, w)
        {

        }

        public double CostCal()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", CostCal());
        }
    }

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