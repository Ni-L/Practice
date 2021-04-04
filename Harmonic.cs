using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace Practice
{
    class Harmonic
    {
            public static void ReadHarmonicNumber()//created method for reading the output
            {
                Console.WriteLine("Please enter nth harmonic number");
                int nthNumber = Convert.ToInt32(Console.ReadLine());//Coverting string value in int
                Console.WriteLine(Harmonic1(nthNumber));
            }
            private static double Harmonic1(int length)
            {
                double sum = 0;
            // 1/1 + 1/2 + 1/3.......1/5(or sum value)
           // int endNumber = 0;
                for (int i = 1; i <= length; i++)
                {
                    sum = sum + ((double)1 / i);

                }
                return sum;
            }
        }



    
}
