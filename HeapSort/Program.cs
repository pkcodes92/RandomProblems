namespace HeapSort
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[] myKeys = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            //double[] mykeys = new double[] {2.22, 0.5, 2.7, -1.0, 11.2};
            //string[] mykeys = new string[] {"Red", "White", "Black", "Green", "Orange"};

            Console.WriteLine("\nOriginal Array Elements : ");
            PrintArray(myKeys);

            HeapSort(myKeys);

            Console.WriteLine("\n\nSorted Array Elements : ");
            PrintArray(myKeys);

            Console.WriteLine("Program execution has finished, you may now exit");
            Console.ReadKey();
        }

        private static void HeapSort<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            BuildMaxHeap(array);

            for (int i = heapSize - 1; i >= 1; i--)
            {
                Swap(array, i, 0);
                heapSize--;
                Sink(array, heapSize, 0);
            }
        }

        private static void BuildMaxHeap<T>(T[] array) where T : IComparable<T>
        {
            int heapSize = array.Length;

            for (int i = (heapSize / 2) - 1; i >= 0; i--)
            {
                Sink(array, heapSize, i);
            }
        }

        private static void Sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
        {
            if (GetLeftKidPos(toSinkPos) >= heapSize)
            {
                // No left kid => not kid at all
                return;
            }

            int largestKidPos;
            bool leftIsLargest;

            if (GetRightKidPos(toSinkPos) >= heapSize || array[GetRightKidPos(toSinkPos)].CompareTo(array[GetLeftKidPos(toSinkPos)]) < 0)
            {
                largestKidPos = GetLeftKidPos(toSinkPos);
                leftIsLargest = true;
            }
            else
            {
                largestKidPos = GetRightKidPos(toSinkPos);
                leftIsLargest = false;
            }

            if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
            {
                Swap(array, toSinkPos, largestKidPos);

                if (leftIsLargest)
                {
                    Sink(array, heapSize, GetLeftKidPos(toSinkPos));
                }
                else
                {
                    Sink(array, heapSize, GetRightKidPos(toSinkPos));
                }
            }
        }

        private static void Swap<T> (T[] array, int pos0, int pos1)
        {
            T tmpVal = array[pos0];
            array[pos0] = array[pos1];
            array[pos1] = tmpVal;
        }

        private static int GetLeftKidPos(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }

        private static int GetRightKidPos(int parentPos)
        {
            return 2 * (parentPos + 1);
        }

        private static void PrintArray<T> (T[] array)
        {
            foreach (T t in array)
            {
                Console.Write(' ' + t.ToString() + ' ');
            }
        }
    }
}