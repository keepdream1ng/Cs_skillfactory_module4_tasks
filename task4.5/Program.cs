namespace skillfactory_module4_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int k = 0; k < 3; k++)
            {
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите, пожалуйста, логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                User.HasPet = Console.ReadLine() == "Да" ? true : false;

                Console.WriteLine("Введите возраст пользователя");
                // Next part will help with typing random stuff without crashing.
                double.TryParse(Console.ReadLine(), out User.Age);

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i <= User.favcolors.GetUpperBound(0); i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }

                // I guess nex time we gonna learn how to send this data somewhere.
            }

            Console.ReadLine();
        }
    }
}