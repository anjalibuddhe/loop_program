using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Write C# Sharp program to read any Month Number in integer and display Month name(use switch case)

namespace loop_program
{
    internal class switch_months
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Select Any One Month");
            int op =Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine(" You have choose January");
                    break;
                case 2:
                    Console.WriteLine(" You have choose February");
                    break;

                case 3:
                    Console.WriteLine(" You have choose March");
                    break;
                case 4:
                    Console.WriteLine(" You have choose April");
                    break;
                case 5:
                    Console.WriteLine(" You have choose May");
                    break;
                case 6:
                    Console.WriteLine(" You have choose June");
                    break;

                case 7:
                    Console.WriteLine(" You have choose July");
                    break;
                case 8:
                    Console.WriteLine(" You have choose Augest");
                    break;
                case 9:
                    Console.WriteLine(" You have choose Semptember");
                    break;
                case 10:
                    Console.WriteLine(" You have choose October");
                    break;
                case 11:
                    Console.WriteLine(" You have choose November");
                    break;
                case 12:
                    Console.WriteLine(" You have choose December");
                    break;
                default:
                    Console.WriteLine("You select wrong Option");
                    break;
            }

        }
    }
}
