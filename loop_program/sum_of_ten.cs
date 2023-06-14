using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace loop_program
{

    //Write a C program to compute the sum of the first 10 natural numbers.
    internal class sum_of_ten
    {
        static void Main(string[] args)
        {
            int num = 0 ;
            for (int i = 1; i <= 10; i++)
            {
                num= num + i;
            }
                Console.WriteLine(num);
        }
    }
}
