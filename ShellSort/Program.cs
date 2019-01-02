namespace ShellSort
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Having an array of numbers hardcoded
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            // Size of the input array
            int n = arr.Length;

            Console.WriteLine("Original Array Elements: ");
            ShowArrayElements(arr);

            // Performing the actual shell sort
            ShellSort(arr, n);

            Console.WriteLine("\nSorted Array Elements: ");
            ShowArrayElements(arr);

            Console.WriteLine("Program has completed execution. Press any key to quit");
            Console.ReadKey();
        }

        private static void ShowArrayElements(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }

            Console.Write(Environment.NewLine); 
        }

        private static void ShellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;

            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }

                if (inc / 2 != 0)
                {
                    inc = inc / 2;
                }
                else if (inc == 1)
                {
                    inc = 0;
                }
                else
                {
                    inc = 1;
                }
            }
        }
    }
}