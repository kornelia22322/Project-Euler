using System;

namespace ConsoleApp2
{
    class DynamicPathSolution
    {
        /* Dynamic programming - better one */
        static long howManyPath(int n)
        {
            long[,] array = new long[n + 1, n + 1];
            array[0, 0] = 1;

            for(long i = 0; i < n + 1; i++)
            {
                for (long j = 0; j < n + 1; j++)
                {
                    if (i - 1 >= 0 && j - 1 >= 0)
                        array[i, j] = array[i - 1, j] + array[i, j - 1];
                    else if (i - 1 >= 0)
                        array[i, j] = array[i - 1, j];
                    else if (j - 1 >= 0)
                        array[i, j] = array[i, j - 1];
                }
            }

            return array[n, n];
        }



        static void Main(string[] args)
        {
            Console.WriteLine(howManyPath(20));
            Console.ReadKey();
        }
    }
}
