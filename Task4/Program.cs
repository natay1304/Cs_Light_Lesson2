using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 7; i <= 98; i += 7) //так короче всего выходит, в условии цикла прописываем все, что нам нужно
            {
                Console.Write(i + " ");
            }
        }
    }
}
