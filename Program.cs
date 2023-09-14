using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statement__days_of_the_week_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a day between 1 and 6");
            int number = int.Parse(Console.ReadLine()); //convert to an int

            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wenesday");
                    break;
                case 4: 
                    Console.WriteLine("Thurday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;



            }

            if(number >= 6)
            {
                Console.WriteLine("Its a weekend");

            }

            Console.Read();
        }
    }
}
