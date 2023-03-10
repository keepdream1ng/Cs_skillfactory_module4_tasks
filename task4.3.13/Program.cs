namespace Cs_skillfactory_module4_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int result = 0;

            foreach (var item in arr)
            {
                result += item;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}