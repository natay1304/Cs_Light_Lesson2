using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            Console.Write("Привет! \nВведите ваше имя: ");
            string userName = Console.ReadLine();
            Console.Write("Введите символ, в котором отрисовать ваше имя - ");
            string symbol = Console.ReadLine();

            for(int i = 0; i < userName.Length + 4; i++)
            {
                line += symbol;
            }

            Console.WriteLine(line + "\n" + symbol + " "+ userName + " " + symbol + "\n" + line);
        }
    }
}
