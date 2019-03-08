using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int userHealth = 100;
            int bossHealth = 100;
            string answer = "";
            string command = "";

            Console.WriteLine("Привет! \nТы теневой маг и у тебя " + userHealth + " единиц здоровья. " +
                "\nТебе необходимо расправиться с боссом, у которого также " + bossHealth + " единиц здоровья" +
                "\nТы можешь использовать следующие заклинания: \n\nFireBall (отнимает 30 ед. здоровья у Босса)" +
                "\nNightmareMoon(отнимает 45 ед здоровья у Босса)\nSuperAttack (можно использовать после NightmareMoon, отнимает 70 ед. здоровья у Босса)" +
                "\n(Esc - выход из игры)\n\nБосс также будет вас атаковать! Удачи!");

            Console.WriteLine("\nВведите заклинание:");
            bool attackComplete = false;

            while (userHealth > 0 && bossHealth > 0)
            {
                command = Console.ReadLine();
                switch (command.ToLower()) //выбор атаки игрока
                {
                    case "fireball":
                        bossHealth -= 30;
                        if (bossHealth < 0)
                        {
                            bossHealth = 0;
                        }
                        Console.WriteLine("У босса осталось " + bossHealth + " ед. здоровья");
                        break;

                    case "nightmaremoon":
                        bossHealth -= 45;
                        if (bossHealth < 0)
                        {
                            bossHealth = 0;
                        }
                        Console.WriteLine("У босса осталось " + bossHealth + " ед. здоровья");
                        attackComplete = true;
                        break;

                    case "superattack":
                        if (attackComplete == true)
                        {
                            bossHealth -= 70;
                        } else
                        {
                            Console.WriteLine("Вы можете использоват супер аттаку только после NightmareMoon");
                        }

                        if (bossHealth < 0)
                        {
                            bossHealth = 0;
                        }

                        Console.WriteLine("У босса осталось " + bossHealth + " ед. здоровья");
                        break;

                    case "esc":
                        Console.WriteLine("Вы вышли из игры. До встречи!");
                        userHealth = -1;
                        bossHealth = -1;
                        break;
                }
                //аттака босса в зависимости от его хп
                if (bossHealth > 55 && userHealth > 0)
                {
                    userHealth -= 15;
                    Console.WriteLine("Босс вас аттакует и наносит 15 ед. урона.\nУ Вас осталось " + userHealth + " ед. здоровья");
                    Console.WriteLine("\nВведите следующую команду:");
                }

                else if (bossHealth <= 55 && bossHealth > 20 && userHealth > 0)
                {
                    userHealth -= 55;
                    if (userHealth < 0)
                    {
                        userHealth = 0;
                        Console.WriteLine("Босс вас аттакует и наносит 55 ед. урона.\nУ Вас осталось " + userHealth + " ед. здоровья");
                    }
                    else
                    {
                        Console.WriteLine("Босс вас аттакует и наносит 55 ед. урона.\nУ Вас осталось " + userHealth + " ед. здоровья");
                        Console.WriteLine("\nВведите следующую команду:");
                    }
                }

                else if (bossHealth <= 20 && bossHealth > 0 && userHealth > 0)
                {
                    userHealth -= 70;

                    if (userHealth < 0)
                    {
                         userHealth = 0;
                         Console.WriteLine("Босс вас аттакует и наносит 70 ед. урона.\nУ Вас осталось " + userHealth + " ед. здоровья");
                    }
                    else
                    {
                            Console.WriteLine("Босс вас аттакует и наносит 70 ед. урона.\nУ Вас осталось " + userHealth + " ед. здоровья");
                            Console.WriteLine("\nВведите следующую команду:");
                    }
                }
                //результат игры
                if (userHealth <= 0 && userHealth != -1)
                {
                    Console.WriteLine("У вас закончилось здоровье. Вы проиграли :(");
                    Console.WriteLine("Хотите сыграть еще (yes, no)?");
                    answer = Console.ReadLine();
                }
                else if(bossHealth <= 0 && bossHealth != -1)
                {
                    Console.WriteLine("Вы победили!");
                    Console.WriteLine("Хотите сыграть еще (yes, no)?");
                    answer = Console.ReadLine();
                }
                //хотите ли сыграть еще
                if (answer.ToLower() == "yes")
                {
                    Console.Clear();
                    userHealth = 100;
                    bossHealth = 100;
                    Console.WriteLine("\nТы снова теневой маг и у тебя " + userHealth + " единиц здоровья! " +
                                      "\nТебе необходимо расправиться с боссом (" + bossHealth + " единиц здоровья)" +
                                      "\nТы можешь использовать следующие заклинания: \n\nFireBall (отнимает 30 ед. здоровья у Босса)" +
                                      "\nNightmareMoon(отнимает 45 ед здоровья у Босса)\nSuperAttack (отнимает 70 ед. здоровья у Босса)" +
                                      "\nEsc (выход из игры)\n\nБосс также будет вас атаковать! Удачи!\n\nВведите заклинание:");
                    answer = "";
                }
                else if (answer.ToLower() == "no")
                {
                    Console.WriteLine("\nGoodbye");
                }
            }        
        }
    }
}
