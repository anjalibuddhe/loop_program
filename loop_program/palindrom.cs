using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());



            int res, sum = 0;

            int rev = num;
            while(num > 0)
            {
                res=num%10;
                sum = sum * 10 + res;
                num = num / 10;
            }

            if(rev == sum)
            {
                Console.WriteLine("It is Palindrome Number");
            }
            else
            {
                Console.WriteLine("It is Not Palindrome Number");

            }

        }
    }
}
