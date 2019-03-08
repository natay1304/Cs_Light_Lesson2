using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            Console.WriteLine("Привет! \nТы можешь выбрать следующие команды: \n\nSetName (устанавливает имя)" +
                "\nDisplayName(запрашивает число, и выводит столько раз имя)\nSetPassword (установка пароля)" +
                "\nЫSymbolColor(установка цвета символов консоли)" +
                "\nEsc (выход из программы)\nВведите команду: ");
            string name = " ";

            while (menu)
            {
                string command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "setname":
                        Console.WriteLine("Введите имя");
                        name = Console.ReadLine();
                        break;

                    case "displayname":
                        Console.WriteLine("сколько раз хотите увидеть свое имя?");
                        int count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ваше имя:");

                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine(name);
                        }
                        break;

                    case "setpassword":
                        Console.WriteLine("Установите пароль из 4 символов - ");
                        string password = Console.ReadLine();
                        Console.WriteLine("Пароль успешно установлен");
                        break;

                    case "symbolcolor":
                        Console.WriteLine("Write colour: blue, red or green");
                        string color = Console.ReadLine();
                        switch (color)
                        {
                            case "red":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "blue":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "green":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                        }
                        break;

                    case "esc":
                        Console.WriteLine("Вы вышли из программы. До встречи!");
                        menu = false;
                        break;            
                }
                Console.WriteLine("\nВведите команду:");
            }
        }
    }
}
