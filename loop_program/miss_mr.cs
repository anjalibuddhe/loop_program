using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


//5.Depending on age(decimal number and gender (m / f), print a personal title:

//“Mr.” – a man(gender “m”) – 16 or more years old.
//“Master” – a boy (gender “m”) under 16 years.
//“Ms.” – a woman (gender “f”) – 16 or more years old.
//“Miss” – a girl (gender “f”) under 16 years.


namespace loop_program
{
    internal class miss_mr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age of the person");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Gender");
            char gender = Convert.ToChar(Console.ReadLine());


            if (age>=16 && gender== 'm')

            {
                Console.WriteLine("Mr. Anuj has 16yr old");
            }
            else if (age <16 && gender =='m')
            {
                Console.WriteLine("Master Sahil has 16yr old");
            }
            else if(age >= 16 && gender=='f')
            {
                Console.WriteLine("Ms. Sara");
            }
            else if(age < 16 && gender == 'f'){
                Console.WriteLine("Miss Anjali");
            }
        }
    }
}
