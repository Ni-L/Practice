using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    class Distance
    {
        public static void ReadTheValue()
        {
            Console.Write("Enter the value of x");
            string input1 = Console.ReadLine();
            int x = Convert.ToInt32(input1);//Coverting string value to int
            Console.WriteLine("Enter the value of y");
            string input2 = Console.ReadLine();
            int y = Convert.ToInt32(input2);//Converting string value to int
            //Calling Distance method; 
            Distance1(x, y);
        }

        private static void Distance1(int x, int y)//Creating private method
        {
            double distance = Math.Sqrt(x * x + y * y);//formula for finding square
            Console.WriteLine(distance);//
        }
    }
}
