using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Day2_ifelse
    {
        static void Main(string[] args)
        {
            //if
            int no;
              Console.WriteLine("enter no:");
              no = Convert.ToInt32(Console.ReadLine());

              if (no%2==0) {
                  Console.WriteLine("even");
              }
              else
              {
                  Console.WriteLine("odd");
              }
            
            //if else
            
            int person;
            Console.WriteLine("enter your age:");
            person = Convert.ToInt32(Console.ReadLine());
            if (person>=18)
            {
                Console.WriteLine("person is eligible");  
            }
            else
            {
                Console.WriteLine("person is not eligible");
            }
            

            //if-else chain
            int student;

            Console.WriteLine("enter your marks");
            student = Convert.ToInt32(Console.ReadLine());

            if (student>=90)
            {
                Console.WriteLine("grade:A");
            }
            else if(student>=80 && student <= 89)
            {
                Console.WriteLine("grade:B");
            }
            else if (student >= 70 && student <= 79)
            {
                Console.WriteLine("grade:C");
            }
            else if (student >= 60 && student <= 69)
            {
                Console.WriteLine("grade:D");
            }
            else
            {
                Console.WriteLine("you are fail");
            }
        }
    }
}
