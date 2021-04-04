using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Practice
{
    class StopWatch
    {
        public static void ElapsedTime()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for(int i =1; i<10;i++)
            {
                Console.WriteLine(i);
            }
            watch.Stop();
            Console.WriteLine("Elapsed Time: "+watch.Elapsed);


        }
    }
}
