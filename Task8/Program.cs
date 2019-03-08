using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string rightPassword = "100500";
            int i = 5;

            Console.Write("Hello!\nEnter your password: ");
            string password = Console.ReadLine();

            while (true)
            {
                if (i-- > 1 && password != rightPassword)

                {
                    Console.Write("\nYour password is wrong. You have " + i + " attempt.\nEnter your password once more: ");
                    password = Console.ReadLine();
                }
                else if (password == rightPassword)
                {
                    Console.WriteLine("\nYou entered right password. You win!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nYour password is still wrong and you have not any attempts. You lose!");
                    break;
                }
            }
        }
    }
}
