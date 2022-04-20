using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class FlipCoin
    {
        public static void Flip()
        {
            //int numflip;
            //Console.WriteLine("How Many times you Want to flip a Coin : ");
            //numflip = Convert.ToInt32(Console.ReadLine());
            Coinflip();

            
        }
        private static int Coinflip()
        {
            Random random = new Random();
            int heads = 0;
            int tails = 0;
            int result=0;
            int numflip;
            
            Console.WriteLine("How Many times you Want to flip a Coin : ");
            numflip = Convert.ToInt32(Console.ReadLine());

           

            for ( int i=0; i<numflip;i++)
            {
                result=random.Next(0,2);
                if(result==1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
               
               
            }
            double percentage1 = (heads * numflip / 100);
            double percentage = (tails * numflip / 100);
            Console.WriteLine("Head Flipped {0} Times", heads);
            Console.WriteLine("Tail Flipped {0} Times", tails);
            Console.WriteLine("Head Percentage Is: " + percentage1);
            Console.WriteLine("Tail Percentage Is: " + percentage);
            return result;
        }
    }
}
