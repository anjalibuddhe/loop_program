using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class prime_Number
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    count++;
                }
            }

                if(count ==2)
                     Console.WriteLine("It is prime number");
                else
                
                    Console.WriteLine("It is not prime number");
                
            

        }
    }
}
