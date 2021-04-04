using System;
using System.Collections.Generic;
using System.Text;
using Practice;

namespace BasicProgram
{
    class FlipCoin
    {
        public static void ReadInput()
        {
            Console.WriteLine("Please Enter number of times to flip coin");
            //converting from String into int with the help Convert.ToInt32()
            int numberOfTimes = Convert.ToInt32(Console.ReadLine());
            //calling Flip() metthod
            Flip(numberOfTimes);

        }

        private static void Flip(int numberOfTimes)
        {
            //Initialization of variables
            int tail = 0; int head = 0;
            //Object creation for Predefined Random class
            Random random = new Random();
            //using for loop to iterate till condition fails 
            for (int i = 1; i <= numberOfTimes; i++)
            {
                //using random function called NextDouble() to get random value 0 to 1
                if (random.NextDouble() < 0.5)
                    tail++;
                else
                    head++;

            }
            double tailPercentage = (double)tail / numberOfTimes * 100;
            double headPercentage = (double)head / numberOfTimes * 100;
            Console.WriteLine(" Tail count " + numberOfTimes + " = " + tail + "Percentage" + tailPercentage);
            Console.WriteLine("Head count " + numberOfTimes + " = " + head + "Percentage" + headPercentage);
        }

      
    }
}
