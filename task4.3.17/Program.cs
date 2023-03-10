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

        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            PrintArray2D(arr);

            Console.ReadKey();
        }
    }
}