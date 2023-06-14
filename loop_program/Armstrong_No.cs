using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class Armstrong_No
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            int res, sum = 0;
            int temp = num;
            while(num != 0)
            {
                res = num % 10;
                sum = sum + (res * res * res);
                num = num / 10;
            }
            if(sum == temp)
            {
                Console.WriteLine(" It is Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong Number");
            }


        }
    }
}
