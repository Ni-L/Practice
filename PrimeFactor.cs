using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    class PrimeFactor
    {
        public static void ReadInput()
        {
            int n, i;
            Console.WriteLine("Please enter your integer: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + n);
                }
            }
        }
    }

}