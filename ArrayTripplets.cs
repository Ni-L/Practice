using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;
namespace Practice
{
    class ArrayTripplets
    {
        public static void Array2()
        {

            bool found = false;
            int[] array = { 12, -6, -6, 4, 5, 10 };
            for (int i =0; i<array.Length; i++)
            {
                //i=0
                for(int j=i+1; j<array.Length; j++)
                {
                    //j=1
                    for(int k=j+1; k<array.Length; k++)
                    {
                        //k=2
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            found = true;
                            Console.WriteLine(array[i] + "," + array[j] + ","+array[k] + ",");
                        }
                    }

                }
            }
            if (found == false)
            {
                Console.WriteLine("Triplates not present inthe given array");
            }
               
        }
    }
}
