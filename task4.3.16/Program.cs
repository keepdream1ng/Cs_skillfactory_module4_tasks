namespace Cs_skillfactory_module4_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int result = 0;

            foreach (var item in arr)
            {
                if (item > 0) result++;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}