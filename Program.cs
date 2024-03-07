using System;
namespace ta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            string[] nums = data.Split(' ');
            int x = int.Parse(nums[0]);
            if( (x % 4 == 0 && x % 100 != 0) || (x%400 == 0))
            {
                Console.WriteLine("閏年");
            }
            else
            {
            Console.WriteLine("平年");
            }


        }
    }
}
