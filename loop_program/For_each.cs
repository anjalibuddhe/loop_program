using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class For_each
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1; i <= 5; i++)
            {
                Console.WriteLine("Enter number");
                int inp = Convert.ToInt32(Console.ReadLine());

                sum += inp;
                //Console.WriteLine(inp);
            }
            Console.WriteLine(sum);


        }
    }
}
