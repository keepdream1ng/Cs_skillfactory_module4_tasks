namespace Cs_skillfactory_module4_tasks
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском (stop для остановки)\nWrite your favorite colour (stop to exit)");

                //task wants me to do a lot of cases, but i want to try and write a shorter version of that code, since we have a user imput

                var text = Console.ReadLine();
                ConsoleColor choosedColor;

                if (text.Length > 1 && char.IsLower(text[0])) text = char.ToUpper(text[0]) + text.Substring(1);

                //check if user wants to stop the programm
                if (!ConsoleColor.TryParse(text, out choosedColor))
                {
                    Console.WriteLine("Выход\nExit");
                    break;
                }
                
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = choosedColor;
                Console.WriteLine($"Your color is {text}!");

            }
            Console.ReadKey();
        }
    }

}