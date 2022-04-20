using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Quotient_And_Remainder
    {
      public static void Result()
        {
            int First;
            Console.WriteLine("Enter Dividend : ");
            First = Convert.ToInt32(Console.ReadLine());

            int Second;
            Console.WriteLine("Enter Divisor : ");
            Second = Convert.ToInt32(Console.ReadLine());

            int remainder=(First%Second);
            Console.WriteLine("Remainder Is :" + remainder);
            int quotient=(First/Second);
            Console.WriteLine("Quotient Is : " + quotient);
        }

    }
}
