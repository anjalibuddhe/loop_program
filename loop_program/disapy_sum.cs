using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C to display n terms of natural numbers and their sum.
//Test Data : 7
//Expected Output :
//The first 7 natural number is :
//1 2 3 4 5 6 7
//The Sum of Natural Number upto 7 terms : 28
namespace loop_program
{
    internal class disapy_sum
    {
        static void Main(string[] args)
        {
              int sum = 0;
            for(int i=1; i<=7; i++) 
            {

                sum=sum + i;
                Console.WriteLine(i);
            }
                Console.WriteLine(sum);

        }
    }
}
