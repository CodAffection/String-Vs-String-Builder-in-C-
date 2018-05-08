using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //String concatenation using string class
            String str = "I am ";//1000H
            str += "passionate about ";//2000H
            str += "programming";//3000H
            Console.WriteLine("Result from string :" + str);


            //String concatenation using stringbuilder class
            StringBuilder strb = new StringBuilder("I am ");//5000H
            strb.Append("passionate about ");
            strb.Append("programming");
            Console.WriteLine("Result from stringbuilder :" + strb);

            Console.ReadKey();
        }
    }
}
