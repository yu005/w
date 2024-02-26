using System;
namespace PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            int a = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    a += i;

                }
            }
            if (n == a)
            {
                Console.WriteLine($"{n}: perfect number");
            }
            else
            {
                Console.WriteLine($"{n}: normal number");
            }
        }
    }
}
