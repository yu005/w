using System;
using System.Runtime.InteropServices;

namespace w11_1120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read two integers:x,y
            
            string data = Console.ReadLine();//"1 50"
            string[] nums = data.Split(' ');//{"1","50"}
            int x = int.Parse(nums[0]);
            int y = int.Parse(nums[1]);
            Console.Write($"Perfect numbers between {x} to {y}: ");
            //lookup the perfect numbers between x an y.
            int min = (x>y) ? y : x; //小括號判斷真假
            int max = (y<x) ? x : y;
            int c = 0;
            //
            for(int n=min;n<=max ;n++)
            {
                if (isPerfectNumber(n))
                {
                    if (c == 0)
                    {
                        Console.Write(n);
                        c++;
                    }
                    else
                    {
                        Console.Write($",{n}");
                    }

                }

            }
            if(c == 0)
                {
                    Console.WriteLine("NONE");
                    
                }

        }
        public static bool isPerfectNumber(int x)
        {

            bool result = false;
            int sumOfFactor = 0;
            for(int i = 1;i<x;i++)
            {
                if (x % i == 0)
                {
                    sumOfFactor += i;//sumOfFactor = sumOfFactor + i;
                }
            }

            result = (sumOfFactor == x) ? true : false;

            return result;
        }
    }
 

}