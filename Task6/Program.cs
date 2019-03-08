using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string rightAnswer = "ель";
            string giveUp = "сдаюсь";
            int attemps = 3;
            Console.Write("Привет!\n\nОтгадай загадку:\nУ вас " + attemps + " попытки\nЗимой и летом одним цветом? - ");
            string answer = Console.ReadLine();
            
            while (attemps > 0)
            {
                if(attemps-- > 1 && answer.ToLower() != rightAnswer && answer.ToLower() != giveUp)

                {
                    Console.Write("\nНеправельный ответ. У вас осталось " + attemps + " попытки(а)." +
                                  "\nЕсли вы не знаете ответ, напишите сдаюсь, или введите ответ еще раз: ");
                    answer = Console.ReadLine();
                }
                else if (answer.ToLower() == rightAnswer)
                {
                    Console.WriteLine("\nПравильный ответ!");
                }
                else if(answer.ToLower() == "сдаюсь")
                {
                    Console.WriteLine("\nПравильный ответ - " + rightAnswer + "\nПока!");
                }
                else
                {
                    Console.WriteLine("\nВаш ответ неверный, и у вас больше нет попыток. Правильный ответ - " + rightAnswer);
                }
            }
        }
    }
}
