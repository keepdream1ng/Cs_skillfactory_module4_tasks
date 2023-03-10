namespace skillfactory_module4_tasks
{
    using System;

    class MainClass
    {
        //I decided to write my own enum, and error messages helped me figure out those shouldnt be a strings.
        public enum MyDaysOfWeek
        {
            Mournday = 1,
            Tearsday,
            Wasteday,
            Thirstday,
            Fightday,
            Shatterday,
            Sinday
        }

        public static void Main(string[] args)
        {
            (string name, byte age, MyDaysOfWeek day, string birthdate) anketa;

            Console.Write("What is your name? ");
            anketa.name = Console.ReadLine();

            Console.Write($"And your age, dear {anketa.name}? ");
            anketa.age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", anketa.name, anketa.age);

            Console.Write("What is your favorite day of week number? ");

            anketa.day = (MyDaysOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("So, your favorite day is {0} ;)", anketa.day);

            Console.Write("Enter your birthdate: ");
            anketa.birthdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is {0}", anketa.birthdate);

            Console.ReadKey();

        }
    }
}