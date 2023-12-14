using System;

namespace _1122
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] a = str.Split(' ');
            int x = int.Parse(a[0]);
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int[] n = new int[nums.Length];

            for(int i = 0; i < nums.Length; i++)
            {
                n[i] = Convert.ToInt32(nums[i]);

            }
            for(int i = 0; i < nums.Length; i++)
            {
                if (n[i] == 1)
                {
                    //Console.WriteLine("你吃到紅蘿蔔了。");
                    x = F1(x);
                }
                else if(n[i] == 2)
                {
                    //Console.WriteLine("你吃到白蘿蔔了。");
                    //if (x > 100)
                    //{
                    //    x -= 20;
                    //}
                    //else
                    //{
                    //    x += 10;
                    //}
                    x = F2(x);
                }
                else if (n[i] == 3)
                {
                    //Console.WriteLine("你吃到黃蘿蔔了，你中毒囉！");

                    //for(int y=0;x>10;y++)
                    //{
                    //    x /= 2;
                    //}
                    x = F3(x);
                }
                else
                {
                    //Console.WriteLine("你吃到發霉的蘿蔔，好臭。");
                    x = F4(x);
                }

            }
            Console.WriteLine($"最後的體重：{x} 公斤");
        }
        public static int F1(int a)
        {
            Console.WriteLine("你吃到紅蘿蔔了。");
            a += 5;
            return a;
        }
        public static int F2(int b)
        {
            Console.WriteLine("你吃到白蘿蔔了。");
            if (b > 100)
            {
                b -= 20;
            }
            else
            {
                b += 10;
            }
            return b;
        }
        public static int F3(int c)
        {
            Console.WriteLine("你吃到黃蘿蔔了，你中毒囉！");

            for (int y = 0; c > 10; y++)
            {
                c /= 2;
            }
            return c;
        }
        public static int F4(int d)
        {
            Console.WriteLine("你吃到發霉的蘿蔔，好臭。");

            return d;
        }






    }
}
