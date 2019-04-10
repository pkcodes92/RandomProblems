namespace DumpableDemo
{
    using System;

    public class Fraction : IDumpable
    {
        public int z, n;
        
        public Fraction(int a, int b)
        {
            z = a;
            n = b; 
        }

        public string Name { get; set; }

        public void Dump()
        {
            Console.WriteLine("Fraction : " + z + "/" + n); 
        }
    }
}