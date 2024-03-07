using System;
namespace ta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int x = Convert.ToInt32(input);
            if(x>=90)
            {
                Console.WriteLine("A");
            }
            else if(80<=x && x<=89)
            {
                Console.WriteLine("B");
            }
            else if (70 <= x && x <= 79)
            {
                Console.WriteLine("C");
            }
            else if (60 <= x && x <= 69)
            {
                Console.WriteLine("D");
            }
            else if (x<60)
            {
                Console.WriteLine("F");
            }
        }
    }
}
