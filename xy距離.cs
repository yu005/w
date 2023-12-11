namespace _411221003_1211
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0. define class Point
            // 1. read a(x1,y1), b(x2,y2)
            string data1 = Console.ReadLine();
            string data2 = Console.ReadLine();
            string[] num1 = data1.Split(' ');
            double x1 = double.Parse(num1[0]);
            double y1 = double.Parse(num1[1]);
            string[] num2 = data2.Split(' ');
            double x2 = double.Parse(num2[0]);
            double y2 = double.Parse(num2[1]);

            // 2. create 2 objects(pa, pb) of Point with (x1,y1) and (x2,y2)
            Point pa, pb;
            pa = new Point();
            pa.SetXY(x1, y1);
            pb = new Point();
            pb.SetXY(x2, y2);
            // 3. compute distance of pa and pb
            double d = pa.distence(pb);
            // 4. output the resulta
            Console.WriteLine(x1+","+y1);
            Console.WriteLine(x2+","+y2);
            Console.WriteLine("d="+d);
        }
    }
    class Point
    {
        // 1.
        private double x, y;
        // methods
        public void SetXY(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double GetX()
        {
            return this.x;
        }
        public double GetY()
        {
            return this.y;
        }
        //
        public double distence(Point other)
        {
            double sum = Math.Sqrt((x - other.x) * (x - other.x) + (y - other.y) * (y - other.y));
            return sum;
        }

    }
}
