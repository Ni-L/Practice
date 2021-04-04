using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace Practice
{
    class PowerOfTwo
    {
        public static void ReadInput()
        {

            Console.WriteLine("Enter as 2^Number:- ");//Getting inputs from user
            string Number = Console.ReadLine();
            int number = Convert.ToInt32(Number);
            //covert from string to Integer
            int num = 1;
            int i = 1; //Count from 0 to N
            int LimitPowerTwo = 31;


            if (number > LimitPowerTwo) //reapeat until i equal n
            {
                Console.WriteLine($"You Enter {number} of 2^ exceeds the value limit 31");
            }
            else
            {

                for (i = 1; i <= number; i++) //to check the Number
                {
                    num = (num * 2); //Multiplay Number By 2
                    Console.WriteLine(num);
                }
            }
        }
    }
}