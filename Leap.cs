using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
/// <summary>
/// for finding out leap year
/// </summary>
namespace Practice
{
    class Leap
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the year");
            string input = Console.ReadLine();
            //Coverting String to Year
            int year = Convert.ToInt32(input);
            //calling leap() method to find leapyear
            leap(year);

        }

        private static void leap(int year)
        {
            if ((year % 4 == 00 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }
    }
}
