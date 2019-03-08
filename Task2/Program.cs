using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            float rubToUsd = 65.8f;
            float rubToEvro = 74.4f;
            float usdToEvro = 0.9f;

            Console.Write("Welcome! Here you can convert your money:)\n\nHow much USD do you have? - ");
            float usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("How much EVRO do you have? - ");
            float evro = Convert.ToSingle(Console.ReadLine());
            Console.Write("How much RUB do you have? - ");
            float rub = Convert.ToSingle(Console.ReadLine());

            Console.Write("\nDo you you want to convert any currency (Yes/No)? - ");
            string answer = Console.ReadLine(); 
            
            while (answer.ToLower() == "yes")
            {
                Console.Write("\nAcrual money course: 1 USD = " + rubToUsd + " RUB; 1 EVRO = " + rubToEvro + " RUB; 1 USD = " + usdToEvro + " EVRO.\nWhat currency do you want to convert: RUB, USD or EVRO? - ");
                string currency = Console.ReadLine(); 
                currency = currency.ToLower();
                Console.Write("What sum do you want to convert? - ");
                float currencyValue = Convert.ToSingle(Console.ReadLine());
                
                switch (currency) //конвертируем все в одну валюту (рубли)
                {
                    case "usd":
                        usd -= currencyValue; 
                        currencyValue *= rubToUsd;
                        break;

                    case "evro":
                        evro -= currencyValue;
                        currencyValue *= rubToEvro;
                        break;
       
                    case "rub":
                        rub -= currencyValue;
                        break;
                }

                Console.Write("What currensy do you want to get after convert (USD, RUB or EVRO)? - ");
                string currencyConverted = Console.ReadLine();

                if (currencyConverted.ToLower() == "usd")
                {
                    currencyValue /= 65.8f;
                    usd += currencyValue;
                } else if(currencyConverted.ToLower() == "evro")
                {
                    currencyValue /= 74.4f;
                    evro += currencyValue;
                }
                else
                {
                    rub += currencyValue;
                }

                Console.WriteLine("\nYour actual currency balance is:\n\nUSD = " + usd + "\nEVRO = " + evro + "\nRUB = " + rub);
                Console.Write("\nDo you still want to convert any currency (Yes/No)? - ");
                answer = Console.ReadLine();
                Console.Clear(); //можно не зачищать, тогда удалить 72 и 73 строки
                Console.WriteLine("\nYour actual currency balance is:\n\nUSD = " + usd + "\nEVRO = " + evro + "\nRUB = " + rub);
            }
            
            Console.WriteLine("Goodbye!");
        }
    }
}
