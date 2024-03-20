using System;
namespace ta4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int ans = 0;

            for (; ; )
            {            
                Console.WriteLine("請輸入業績:(-1 for exit)");
                string str = Console.ReadLine();
                int n = Convert.ToInt32(str);

                if (n == -1)
                {
                    break;
                }
                if (n > 0 && n < 100)
                {
                    sum++;
                    ans += n;
 
                }
                else
                {
                    Console.WriteLine("*** Error Data!");
                }
            }
            double anss = ans / sum;
                Console.WriteLine("======================");
                Console.WriteLine($"員工人數:{sum}");
            if (sum != 0)
            {

                Console.WriteLine($"平均業績:{anss:F2}");
            }




        }
    }
} 






        }
    }
}
