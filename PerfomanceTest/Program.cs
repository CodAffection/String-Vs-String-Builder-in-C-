using System;
using System.Text;
using System.Diagnostics;

namespace PerfomanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch Mytimer = new Stopwatch();
            string str = string.Empty;
            Mytimer.Start();
            for (int i = 0; i < 10000; i++)
            {
                str += i.ToString();
            }
            Mytimer.Stop();
            Console.WriteLine("Time taken by string : {0}", Mytimer.Elapsed);

            StringBuilder sbr = new StringBuilder(string.Empty);
            //restart timer from zero
            Mytimer.Restart();
            for (int i = 0; i < 10000; i++)
            {
                sbr.Append(i.ToString());
            }
            Mytimer.Stop();
            Console.WriteLine("Time taken by stringbuilder : {0}", Mytimer.Elapsed);
            Console.ReadKey();
        }
    }
}
