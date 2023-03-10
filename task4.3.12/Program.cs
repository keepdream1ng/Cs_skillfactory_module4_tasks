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
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //testing Swap
            Swap(arr, 0, 1);

            foreach (int i in arr)
            {
                Console.Write(i);
            }

            Console.ReadKey();
        }

    }
}