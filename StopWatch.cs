using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class StopWatch
    {
        public static void startStopWatch()
        {
         
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Enter input to Set timer: ");
            int timer = Convert.ToInt32(Console.ReadLine());

            stopwatch.Start();
            
            for (int i = 0; i < timer; i++)
            {
                Console.WriteLine("Timer: " + i);
                Thread.Sleep(1000);
            }

            stopwatch.Stop();

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
