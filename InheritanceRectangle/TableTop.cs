namespace InheritanceRectangle
{
    using System;

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
}