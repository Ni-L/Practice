using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace Practice
{
    class SumOfTripletes
    {
        public static void SumOfTripletes1()
        {
            HashSet<int> hs = new HashSet<int>();
            bool found = false;
            int[] array = { 12, -6, -6, 4, 5, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                //i=0
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = -(array[i] + array[j]);
                    if (hs.Contains(sum))
                    {
                        found = true;
                        Console.WriteLine("{" + array[i] + " ," + array[j] + " ," + sum +" } ");

                    }
                    else
                    {
                        hs.Add(array[j]);
                    }
                }
            }
            if(found == false)
            {
                Console.WriteLine("Tripletes not present in the givrn array");
            }

        }
    }
}
    