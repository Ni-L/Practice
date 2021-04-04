using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    class VendinMachine
    {
        public static void ReadAmountToFindChange()
        {
            Console.WriteLine("Enter an amount to give change");
            int amount = Convert.ToInt32(Console.ReadLine());
            FindMinNotes(amount);
        }
        private static void FindMinNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };//initialize array
            int[] noteCounter = new int[notes.Length];//2
            for(int i = 0; i<notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];//25/10
                    amount = amount - (noteCounter[i] * notes[i]);//25-(2*10)//5
                    if (amount <= 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Current count===>");
            for (int i = 0; i < notes.Length; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + ":" + notes);
                }
            }

        }
                 
    }
                   
    }



