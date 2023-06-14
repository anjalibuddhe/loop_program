using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_program
{
    internal class Check_Positive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num =Convert.ToInt32(Console.ReadLine());

            switch(num % 2)
            {
                case 1:
                    Console.WriteLine(+ num +" is even number");
                    break;

                case 2:
                    Console.WriteLine($"{num} is negetive number");
                    break;
            }


           
        }
    }
}
