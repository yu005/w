using System;
namespace ta4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入月份: ");
            string str = Console.ReadLine();
            int mon = Convert.ToInt32(str);
            Console.WriteLine("====================== ");
            int day = 0;
            switch (mon)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                case 2:
                    day = 28;
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }
            Console.WriteLine($"{mon}月的好日子: ");
            for (int i = 1; i <= day; i++)
            {
                if (i % 4 != 0 && i % 10 != 4)
                {
                    if (i == 1)
                    {
                        Console.Write($"{i}");
                    }
                    else
                    {
                        Console.Write($" {i}");
                    }


                }
            }

        }
    }
}

        }
    }
}
