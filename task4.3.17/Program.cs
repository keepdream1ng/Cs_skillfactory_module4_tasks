namespace Cs_skillfactory_module4_tasks
{
    internal class Program
    {
        static void PrintArray2D(int[,] array)
        {
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= array.GetUpperBound(1); k++)
                {
                    Console.Write(array[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Swap(int[,] arr, int k, int j, int row)
        {
            if (k != j)
            {
                arr[row, k] += arr[row, j];
                arr[row, j] = arr[row, k] - arr[row, j];
                arr[row, k] -= arr[row, j];
            }
        }
        static void InsertSortRow(int[,] arr, int row)
        {
            for (int i = 1; i <= arr.GetUpperBound(1); i++)
            {
                int k = i;
                while (k > 0 && arr[row, k - 1] > arr[row, k])
                {
                    Swap(arr, k - 1, k, row);
                    k--;
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            PrintArray2D(arr);
            Console.WriteLine();

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                InsertSortRow(arr, i);
            }

            PrintArray2D(arr);
            Console.ReadKey();
        }
    }
}