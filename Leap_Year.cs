using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Leap_Year
    {
        public static void Leap()
        {
            int Year;
            Console.WriteLine("Enter Four Digit Number : ");
            Year=Convert.ToInt32(Console.ReadLine());
            if (Year < 9999 && Year > 999)
            {

                if (((Year % 4 == 0) && (Year % 100 != 0)) || ((Year % 400 == 0)))
                {
                    Console.WriteLine("{0} is Leap Year ", +Year);
                }
                else
                {
                    Console.WriteLine("{0} is Not a Leap Year  ", +Year);
                }
            }
            else
            {
                Console.WriteLine("Your Year Should be of 4 digits :");
            }
        }
    }
}
