using System;

namespace StatisticsBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);

            double mean = getMean(a);
            double median = getMedian(a);
            int mode = getMode(a);

            Console.WriteLine($"Mean is: {mean}");
            Console.WriteLine($"Median is: {median}");
            Console.WriteLine($"Mode is: {mode}");

            Console.ReadKey(); 
        }

        static double getMean(int[] a)
        {
            int sum = 0;
            int size = a.Length;
            double mean;
            foreach (int item in a)
            {
                sum += item;
            }
            mean = Convert.ToDouble(sum) / size;

            return mean;
        }

        static double getMedian(int[] a)
        {
            double median;
            int size = a.Length;
            int[] copy = a;

            // Having the array sorted prior to finding
            // out the median
            Array.Sort(copy);

            // Making sure to calculate the median correctly
            if (size % 2 == 0)
            {
                median = Convert.ToDouble((copy[size / 2 - 1] + copy[size / 2]) / 2);
            }
            else
            {
                median = Convert.ToDouble(copy[(size - 1) / 2]);
            }

            return median;
        }

        static int getMode(int[] a)
        {
            int mode = 0;
            int size = a.Length;
            int[] copy = a;
            Array.Sort(copy);
            int count = 0, max = 0;
            int current = copy[0];

            for (int i = 0; i < size; i++)
            {
                if (copy[i] == current)
                {
                    count++; 
                }
                else
                {
                    count = 1;
                    current = copy[i];
                }

                if (count > max)
                {
                    max = count;
                    mode = copy[i];
                }
            }

            return mode;
        }
    }
}