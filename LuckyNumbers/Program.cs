namespace LuckyNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = 1230;

            string nStr = n.ToString();

            int sumFirstHalf = 0, sumSecHalf = 0; 

            for (int i = 0; i < nStr.Length / 2; i++)
            {
                sumFirstHalf += Convert.ToInt32(nStr[i]); 
            }

            for (int j = nStr.Length / 2; j < nStr.Length; j++)
            {
                sumSecHalf += Convert.ToInt32(nStr[j]);
            }

            Console.WriteLine(sumFirstHalf == sumSecHalf);

            Console.WriteLine("Program execution has completed, you can press any key to exit");
            Console.ReadKey(); 
        }
    }
}