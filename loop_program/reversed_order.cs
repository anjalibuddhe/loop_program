using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class reversed_order
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter The number You want to reversed");
            int num=Convert.ToInt32(Console.ReadLine());
            int res, sum = 0;
            int new_no = num;

            while (num > 0)
            {
                res = num % 10;
                sum = sum * 10 + res;
                num=num/ 10;


            }
                Console.WriteLine($"reversed order id {sum}" );



        }
    }
}
