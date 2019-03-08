using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = " ";
            Console.WriteLine("Привет! Как тебя зовут?");
            string userName = Console.ReadLine();

            Console.WriteLine("\nПривет, " + userName + "! Сколько тебе лет?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge >= 18)
            {
                Console.WriteLine("\nЗамечательно! Ты ходишь в школу?");
                userAnswer = Console.ReadLine();
                
                if(userAnswer.ToLower() == "нет")
                {
                    Console.WriteLine("\nСентябрь горииит...(выберите 1, 2 или 3)\n1) Убийца плачет\n" +
                                      "2) Птица парииит\n3) Что это вообще такое?");
                    userAnswer = Console.ReadLine();

                    if (userAnswer == "1")
                    {
                        Console.WriteLine("\nБлеск! Ты прошел мой тест!");
                    }
                    else
                    {
                        Console.WriteLine("\nОбманщик!");
                    }
                } else
                {
                    Console.WriteLine("Обманщик, тебе нет 18!");
                }
            } else
            {
                Console.WriteLine("Извини, но тебе закрыт доступ к программе!");
            }

        }
    }
}
