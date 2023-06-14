using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class printTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    int res = num * i;
            //    Console.WriteLine(res);
            //}

            int i = 1;
            while (i <= 10) {
                int res = num * i;
                Console.WriteLine(res);
                i++;
            }
        }
    }
}
