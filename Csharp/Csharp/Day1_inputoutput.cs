using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Day1_inputoutput
    {
        static void Main(string[] args)
        {
            //output
            Console.WriteLine("Hello csharp");

            //how to take value from user i/o
            int n1, n2, sum;
            Console.WriteLine("enter 2no:");
            n1=Convert.ToInt32(Console.ReadLine());
            n2=Convert.ToInt32(Console.ReadLine());
            sum=n1 + n2;
            Console.WriteLine("sum{0}",sum);

            //if we declare if in variable and how we use in if?
            //@ allows the keywords to be used as a variable
            string @if = @"hello omkar";
            Console.WriteLine(@if);

            //type casting
            float rate = 10;
            Console.WriteLine(rate);
            int a = (int)10.7f;
            Console.WriteLine(a);
        }
    }
}
