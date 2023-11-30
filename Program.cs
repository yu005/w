using System;

namespace s1122100_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(num[0]);
            int b = Convert.ToInt32(num[1]);
            int c = Convert.ToInt32(num[2]);
            Triangle A = new Triangle(a, b, c);
            if(A.IsTriangle())
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
    class Triangle
    {
        private int a;
        private int b;
        private int c;
        public Triangle(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void SetEdges(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public bool IsTriangle()
        {
            if (a + b > c && b + c > a && a + c > b)
            {
              return true;
            }
                
            else
            {
                return false;
            }

            
        }
    }
}
