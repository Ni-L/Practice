using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    /// <summary>
    /// Reading input from the user for Finding roots of quadratic Equation
    /// </summary>
    class Quadratic
    {
        public static void RootsOfEqu()
        {
            //3,1,-2
            Console.WriteLine("Enter the Value of a:");//Enter the value of a
            int a = Convert.ToInt32(Console.ReadLine());//Coverting string into int
            Console.WriteLine("Enter the Value of b:");//Enter the value of b
            int b = Convert.ToInt32(Console.ReadLine());//Converting string into int
            Console.WriteLine("Enter the Value of c:");//Enter the value of c
            int c = Convert.ToInt32(Console.ReadLine());//Converting string into int
            double delta = b * b - (4 * a * c);//Formula of delta 
            double sqr = Math.Sqrt(delta);//mathematical packages
            double root1 = (-b+ sqr)/ (2 * a);//For finding the root1
            double root2 = (-b - sqr) / (2 * a);//For finding the root2

            Console.WriteLine("The value of root1 "  + root1);//=(-b+ sqr)/ (2 * a)
            Console.WriteLine("The value of root2 " + root2);//(-b - sqr) / (2 * a)

        }
    }
}
