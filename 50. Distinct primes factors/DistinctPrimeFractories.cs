using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class DistinctPrimeFractories
    {
        /* Check if number has exactly n distinct prime factors */
        static bool hasDistinctPrimeFactors(int num, int n)
        {
            int counter = 0;
            int i = 2;
            while(num != 1)
            {
                if (num % i == 0)
                    counter++;

                while (num % i == 0)
                {
                    num = num / i;
                }

                if (counter > n)
                    return false;

                i++;
            }
            if (counter == n)
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            int startInd = 0;
            int startNum = 0;
            int i = 1;
            while(true)
            {
                if (startInd == 4)
                {
                    Console.WriteLine(startNum);
                    break;
                }               
                else if (hasDistinctPrimeFactors(i, 4))
                {
                    if (startInd == 0)
                        startNum = i;
                   
                    startInd++;
                }
                else
                {
                    startNum = 0;
                    startInd = 0;
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
