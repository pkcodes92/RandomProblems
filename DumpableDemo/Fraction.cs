namespace DumpableDemo
{
    using System;

    /// <summary>
    /// This is the fraction class.
    /// </summary>
    public class Fraction : IDumpable
    {
        /// <summary>
        /// Public integers.
        /// </summary>
        public int z, n;
        
        /// <summary>
        /// The default constructor.
        /// </summary>
        /// <param name="a">A random integer value.</param>
        /// <param name="b">Another random integer value.</param>
        public Fraction(int a, int b)
        {
            z = a;
            n = b; 
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This method writes to the console.
        /// </summary>
        public void Dump()
        {
            Console.WriteLine("Fraction : " + z + "/" + n); 
        }
    }
}