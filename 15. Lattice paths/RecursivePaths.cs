using System;

namespace ConsoleApp1
{
    /* Lattice paths - recursive solution
     * Not really effective one.. */
    class RecursivePaths
    {        
        static int howManyPath(int x, int y)
        {           
            if (x - 1 >= 0 && y - 1 >= 0)
                return howManyPath(x - 1, y) + howManyPath(x, y - 1);
            else if (x - 1 >= 0)
                return howManyPath(x - 1, y);
            else if (y - 1 >= 0)
                return howManyPath(x, y - 1);

            //obvious that x == 0 and y == 0 here
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(howManyPath(3, 3));
            Console.ReadKey();
        }
    }
}
