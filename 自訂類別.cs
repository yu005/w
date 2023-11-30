using System;

namespace _411221003_hw0601


{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num1 = Console.ReadLine().Split(' ');
            double x1 = Convert.ToDouble(num1[0]);
            double y1 = Convert.ToDouble(num1[1]);
            string[] num2 = Console.ReadLine().Split(' ');
            double x2 = Convert.ToDouble(num2[0]);
            double y2 = Convert.ToDouble(num2[1]);
            string[] num3 = Console.ReadLine().Split(' ');
            double x3 = Convert.ToDouble(num3[0]);
            double y3 = Convert.ToDouble(num3[1]);

            Point A = new Point();
            Point B = new Point();
            Point C = new Point();//宣告兩組測資
            A.SetXY(x1, y1);//將x1y1放入SetXY
            B.SetXY(x2, y2);
            C.SetXY(x3, y3);
            A.distence(B);
            B.distence(C);
            C.distence(A);
            if (A.distence(B) + B.distence(C) > C.distence(A) && B.distence(C) + C.distence(A) > A.distence(B) && A.distence(B) + C.distence(A) > B.distence(C))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            //Console.WriteLine("A({0:F6}, {1:F6})", A.GetX(), A.GetY());
            //Console.WriteLine("B({0:F6}, {1:F6})", B.GetX(), B.GetY());
            //Console.WriteLine("d(A, B) = {0:F6}", A.distence(B));
        }
    }
    class Point
    {
        private double x;//私有的
        private double y;

        public void SetXY(double x, double y)
        {
            this.x = x;//私有的=外部傳入資料
            this.y = y;
        }
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public double distence(Point p)//()內測資
        {
            double sum = Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
            return sum;
        }
    }
}
