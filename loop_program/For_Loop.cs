using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class For_Loop
    {

        static void Main(string[] args)
        {
            //for (int i = 1; i <= 50; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int i = 1;
            while (i <= 50)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
