using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Harmonic_Number
    {
         static double nthHarmonic(int N)
        {
            float harmonic = 1;
            //hn = H1 + H2 + H3 ....+
            //Hn-1 + Hn-1 + 1/n
            for(int i=2;i<=N;i++)
            {
                harmonic += (float)1/i;
            }
            return harmonic;
        }
        public static void Har()
        {
            Console.WriteLine("Enter Your Number : ");
            int N =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(@nthHarmonic(N));
        }

    }
}
