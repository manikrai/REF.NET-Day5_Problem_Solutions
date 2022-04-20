using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Problem_Solutions
{
    internal class Factors
    {
        public static void Factorisation()
        {
            int N;
            Console.WriteLine("Enter Your Number : ");
            N=Convert.ToInt32(Console.ReadLine());
            int i, j;
            int count = 0;
            int flag = 0;
            Console.WriteLine();
            Console.WriteLine("Prime Factor Of {0} Is :\n",N);
            for(i=2; i<N; i++)
            {
                if(N % i == 0)
                {
                    count = 0;
                    for(j=1 ; j<=i ; j++)
                    {
                        if(i % j == 0)
                        
                            count++;
                    }
                        if(count == 2)
                        {
                            flag = 1;
                            Console.Write(i +" ");
                        }
                    }
                }
                if (flag == 0)
                Console.WriteLine("There is no Prime factor for {0} Is ", N);
                
            }

        }
    }

