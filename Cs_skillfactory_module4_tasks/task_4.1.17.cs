namespace Cs_skillfactory_module4_tasks
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы (stop для остановки)\nWrite your favorite colour in lower case (stop to exit)");

                var color = Console.ReadLine();

                //check if user wants to stop the programm
                if (color == "stop")
                {
                    Console.WriteLine("Цикл остановлен \nCycle stopped");
                    break;
                }
                switch (color)
                {

                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Error");
                        break;
                }
                Console.ReadKey();
            }
        }
    }

}