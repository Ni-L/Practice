using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace Practice
{
    class PassValue
    {
        public static void PassByValue()
        {
            int x = 100;
            Console.WriteLine("x value before calling changevalue method " + x);
            ChangeValueType(x);
            Console.WriteLine("x value after calling changevalue method " + x);
    
        }
        private static void ChangeValueType(int x)
        {
            x = x + 10;
            Console.WriteLine("x value within a changevalue()" + x);
        }
    }


}
