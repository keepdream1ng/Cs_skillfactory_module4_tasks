namespace Cs_skillfactory_module4_tasks
{
    internal class Program
    {
        static void Swap(int[] arr, int k, int j)
        {
            if (k != j)
            {
                arr[k] += arr[j];
                arr[j] = arr[k] - arr[j];
                arr[k] -= arr[j];
            }
        }
        static void InsertSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int k = i;
                while (k > 0 && arr[k - 1] > arr[k])
                {
                    Swap(arr, k - 1, k);
                    k--;
                }
            }
        }

        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            InsertSort(arr);

            foreach (int i in arr)
            {
                Console.Write(i);
            }

            Console.ReadKey();
        }

    }
}