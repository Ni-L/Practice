using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    class Glambler
    {
        public static void ReadStakeAmountAndGoal()
        {
            int wons = 0;
            int loose = 0;
            Console.WriteLine("Enter stake amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Goal amount");
            int goal = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int randomValue = random.Next(0, 2);
            Console.WriteLine("Generated random Value: " + randomValue);
            for (int i = 1; i > 0; i++)
            {
                if (amount > 0)
                {
                    if (randomValue == 1)
                    {
                        amount = amount + 1;
                        wons++;
                        if (amount  == goal)
                        {
                            Console.WriteLine("Number of bets played in the game" + i);
                            Console.WriteLine("number of won" + wons);
                            Console.WriteLine("number of loose=" + loose);
                            break;
                        }

                    }
                    else
                    {
                        amount = amount - 1;
                        loose++;
                    }

                }
                else
                  {
                    Console.WriteLine("Game broken means amount is not sufficent");
                    break;
                   }

            }
            Console.WriteLine("Final amount either it may reaches" +amount);
        }
    }
}

