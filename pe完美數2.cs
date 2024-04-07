using System;
namespace PE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(input[0]);
                int m = Convert.ToInt32(input[1]);
                int num = 0;
                int f = 0;
                int a = 0;
                Console.Write($"Perfect numbers between {n} to {m}: ");
                if (n>m)
                {
                    a = n;
                    n = m;
                    m = a;
                }

                for(int j = n; j <= m; j++)
                {
                     num = 0;
                    for (int i = 1; i < j; i++)
                    {
                         if (j % i == 0)
                         {
                           num += i;

                         }

                    }

                    if (j == num)
                    {
                        if (f == 0)
                        {
                            Console.Write($"{j}");
                            f++;
                        }

                        else if (f > 0)
                        {
                            { Console.Write($",{j}"); }
                        }

                    }


                }                    if (f == 0)
                    {
                        Console.Write($"NONE");

                    }

            }
        }
    }
}
