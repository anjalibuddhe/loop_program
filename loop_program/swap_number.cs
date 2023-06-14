using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class swap_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int n2= Convert.ToInt32(Console.ReadLine());

            switch (n1 = n2)
            {
                case 0:
                   int temp = 0;
                    temp = n1;
                    n1 = n2;
                    n2= temp;
                    Console.WriteLine($"the value of n1 is = {n2} and n2 is ={n1}");
                    break;
                case 1:
                    Console.WriteLine("values are same");
                    break;


            }
        }
    }
}
