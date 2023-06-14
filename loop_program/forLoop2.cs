using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class forLoop2
    {
        static void Main(string[] args)
        {
            //for (int i = 50; i >= 20; i--)
            //{
            //    Console.WriteLine(i);
            //}
            int i = 50;
            while (i >= 20)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
}
