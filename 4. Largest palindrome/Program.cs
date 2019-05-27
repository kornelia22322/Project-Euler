using System;

namespace ConsoleApp1
{
    class Program
    {
        static int largestPalindrome()
        {
            int largest = 0;
            for(int i = 100; i < 999; i++)
            {
                for(int j = 100; j < 999; j++)
                {
                    int mul = i * j;
                    char[] arr = mul.ToString().ToCharArray();
                    bool isPalindrome = true;
                    for(int z = 0; z < (arr.Length)/2; z++)
                    {
                        if(arr[z] != arr[arr.Length - 1 - z])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                        Console.WriteLine(mul);

                    if (isPalindrome && mul > largest)
                        largest = mul;
                }
            }
            return largest;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(largestPalindrome());
            Console.ReadKey();
        }
    }
}
