using System;

namespace PF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            string[] input1 = Console.ReadLine().Split();
            x1 = double.Parse(input1[0]);
            y1 = double.Parse(input1[1]);


            string[] input2 = Console.ReadLine().Split();
            x2 = double.Parse(input2[0]);
            y2 = double.Parse(input2[1]);

            // 建立 Point 物件 A 和 B
            Point A = new Point();
            Point B = new Point();

            // 設定座標值
            A.setXY(x1, y1);
            B.setXY(x2, y2);

            // 輸出座標及象限
            Console.WriteLine("PA({0:F3}, {1:F3}) Zone{2}", A.getX(),A.getY(),A.getZone());
            Console.WriteLine("PB({0:F3}, {1:F3}) Zone{2}", B.getX(), B.getY(), B.getZone());
        }
        class Point
        {
            private double x, y;

            public void setXY(double x,double y)
            {
                this.x = x;
                this.y = y;
            }

            public double getX() 
            {
                return x;
            }
            public double getY() 
            {
                return y;
            }

            public int getZone()
            {

                if(x==0 || y==0)
                    return 0;
                else if(x>0 && y>0)
                    return 1;
                else if(x<0 && y>0)
                    return 2;
                else if (x<0 && y<0)
                    return 3;
                else
                    return 4;
            }
        }
    }
}
