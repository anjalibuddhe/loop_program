using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class fibo_series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, res;

            for(int k=0; k < n; k++)
            {
                res = a + b;
                Console.WriteLine(res);
                a = b;
                b = res;
            }
        }
    }
}
