using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cshark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //day1 : input/output


            Console.WriteLine("Hello world!");

            //sum of 2 no using input output
            int n1, n2,sum;
            Console.WriteLine("Enter 2no:");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2no:");
            n2 = Convert.ToInt32(Console.ReadLine());

            sum = n1 + n2;

            Console.WriteLine("sum=" + sum);

            //-------------------------------
            int @if;
            @if = 100;
            string name = @"omkar is cool";
            Console.WriteLine(name);


        }
    }
}
