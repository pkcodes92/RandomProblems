using System;

namespace GetHashCodeTutorial
{
    public struct Number
    {
        private int n; 

        public Number(int value)
        {
            n = value;
        }

        public int Value
        {
            get { return n; }
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Number))
            {
                return false;
            }
            else
            {
                return n == ((Number)obj).n;
            }
        }

        public override int GetHashCode()
        {
            return n; 
        }

        public override string ToString()
        {
            return n.ToString();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int ctr = 0; ctr <= 9; ctr++)
            {
                int randomNum = rnd.Next(int.MinValue, int.MaxValue);
                Number n = new Number(randomNum);
                Console.WriteLine("n = {0,12}, hash code = {1, 12}", n, n.GetHashCode());
            }

            Console.ReadKey(); 
        }
    }
}