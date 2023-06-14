//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////4.A student has to travel n kilometers. He can choose between three types of transportation:

////Taxi.Starting fee: 0.70 EUR.Day rate: 0.79 EUR / km.Night rate: 0.90 EUR / km.
////Bus.Day / Night rate: 0.09 EUR / km.Can be used for distances of minimum 20 km.
////Train. Day / Night rate: 0.06 EUR / km.Can be used for distances of minimum 100 km.
////Write a program that reads the number of kilometers n and period of the day (day or night) and calculates the fare amount
//namespace loop_program
//{
//    internal class kilometer_cal
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("1. Taxi");
//            Console.WriteLine("2. Bus");
//            Console.WriteLine("3. Train");
//            int op =Convert.ToInt32(Console.ReadLine());


           

//            Console.WriteLine("Select any one option");

//            Console.WriteLine("A Day");
//            Console.WriteLine("B Night");
//            char Tm = Convert.ToChar(Console.ReadLine());


//            Console.WriteLine("Enter Kilometer");
//            int Km = Convert.ToInt32(Console.ReadLine());

//            if(op== 1 && Tm == 'A')
//            {
//                double Fee = Km * 0.70;
//                Console.WriteLine("Chargers to travel by taxi in day" + Fee);
//            }
//            else if(op== 1 && Tm == 'B')
//            {
//                double Fee1 = Km * 0.90;
//                Console.WriteLine("Chargers to travel by taxi in day" + Fee1);

//            }
//            else if (op == 2 && Tm == 'A')
//            {
//                double Fee2= Km * 0.9;
//                Console.WriteLine("Chargers to travel by taxi in day" + Fee2);

//            }
//            //else if (op == 2 && Tm == 'B')
//            //{
//            //    double Fee3= Km * 0.90;
//            //    Console.WriteLine("Chargers to travel by Bus  day" + Fee3);

//            //}
//            else if (op == 3 && Tm == 'A')
//            {
//                double Fee4= Km * 0.90;
//                Console.WriteLine("Chargers to travel by Bus day" + Fee4);

//            }
//            else if (op == 3 && Tm == 'B')
//            {
//                double Fee5= Km * 0.90;
//                Console.WriteLine("Chargers to travel by train ay" + Fee5);

//            }
//            else if (op == 3 && Tm == 'B')
//            {
//                double Fee1 = Km * 0.90;
//                Console.WriteLine("Chargers to travel by train day" + Fee1);

//            }


//        }
//        }
//    }
//}
