namespace InheritanceRectangle
{
    using System;

    /// <summary>
    /// This is the table top class.
    /// </summary>
    public class TableTop : Rectangle
    {
        /// <summary>
        /// This is the table top constructor.
        /// </summary>
        /// <param name="l">This is the length.</param>
        /// <param name="w">This is the width.</param>
        public TableTop(double l, double w): base(l, w)
        {

        }

        /// <summary>
        /// This method calculates the cost.
        /// </summary>
        /// <returns>The cost given the area.</returns>
        public double CostCal()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }

        /// <summary>
        /// This method outputs the results.
        /// </summary>
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", CostCal());
        }
    }
}