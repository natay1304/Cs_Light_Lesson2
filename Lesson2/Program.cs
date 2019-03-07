using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isDoorOpen = false;
            Console.Write("Hi! What is your age? - ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if(userAge >= 18 && isDoorOpen == false)
            {
                isDoorOpen = true;
                Console.WriteLine("The door is open. Welcome!");
            }
            else
            {
                Console.WriteLine("Your are too young. Go home!");
            }

        }
    }
}
