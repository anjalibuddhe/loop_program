using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class loopFor
    {
        static void Main(string[] args)
        {
             for (int i = 2; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(Console.ReadLine());
        }
    }
}
