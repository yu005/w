namespace s1122100_1211
{
    internal class Program
    {
        class Triangle
        {
            //1.fields
            private int a, b, c;
            //2.constructors
            public Triangle(int a, int b, int c)
            {
                setEdges(a, b, c);
            }

                
            //3.methods
            public void setEdges(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public bool IsTriangle()
            {
                if(a+b>c && b+c>a && a+c>b)
                    return true;
                else 
                    return false;
            }
        }
        static void Main(string[] args)
        {
            //0.define class Triangle

            //1.read a,b,c
            string data=Console.ReadLine();
            string[] nums = data.Split(' ');
            int a = int.Parse(nums[0]);
            int b = int.Parse(nums[1]);
            int c = int.Parse(nums[2]);
            //2.Create an object of Triangle with a/b/c
            Triangle shape2 = new Triangle(a, b, c);
            //3.call isTriagle() and show some message
            if (shape2.IsTriangle())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}