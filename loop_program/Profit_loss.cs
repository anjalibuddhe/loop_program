using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# Sharp program to calculate profit and loss on a transaction
namespace loop_program
{
    internal class Profit_loss
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Selling price of product");
            int SP = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Cost price of product");
            int CP = Convert.ToInt32(Console.ReadLine());

            int profit = SP - CP;

            //int Total_Profit = (profit/CP)*100;

            Console.WriteLine($"shopkeeper made a profit of {profit}% of the cost price");
        }
    }
}
