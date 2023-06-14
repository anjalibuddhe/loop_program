using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write C# Program to check uppercase or lowercase alphabets
namespace loop_program
{
    internal class caseletter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any alphabets");
            char alpha = Convert.ToChar(Console.ReadLine());

            if(alpha >= 'a' && alpha <= 'z')
                 {
                Console.WriteLine("It is lowercase alphabets");
            }
            else if (alpha >= 'A' && alpha <= 'Z')
            {
                Console.WriteLine("It is Uppercase alphabets");
            }
            else
            {
                Console.WriteLine("It is not alphabets");
            }


        }
    }
}
