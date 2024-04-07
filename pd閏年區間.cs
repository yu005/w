using System;
namespace pd
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int x = int.Parse(nums[0]);
            int y = int.Parse(nums[1]);
            int a = 0;
            if (x > y || x < 0 || y < 0)
            {
                Console.WriteLine($"{x}~{y}: Wrong Input");
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 4 == 0)
                    {
                        if (i % 100 == 0)
                        {
                            if (i % 400 == 0)
                            {
                                if (a == 0)
                                {
                                    Console.Write($"{x}~{y}: {i}");
                                    a++;
                                }
                                else
                                {
                                    Console.Write($",{i}");
                                    a++;
                                }
                            }
                        }
                        else
                        {
                            if (a == 0)
                            {
                                Console.Write($"{x}~{y}: {i}");
                                a++;
                            }
                            else
                            {
                                Console.Write($",{i}");
                                a++;
                            }
                        }

                    }
                }
                if(a==0)
                {
                    Console.Write($"{x}~{y}: NONE");
                }
                Console.WriteLine();
                Console.Write($"Total: {a} leap years.");
            }
        }
    }
}
