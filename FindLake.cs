using System;

namespace _1213
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split("");
            string []K = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(K[0]);
            int y = Convert.ToInt32(K[1]);
            char[,] arr = new char[x, y];
            if (arr[x,y]== 1)
                FinfLake(x,y);


        }
        static int[,] arr;
        static int c;
        
        static void FinfLake(int i,int j)
        {
            
            c += 1;
            arr[i, j] = 0;
            if(arr[i-1,j]==1)//左1
            {
                FinfLake(i - 1, j);
                c++;
                arr[i - 1, j] = 0;
            }
            if (arr[i +1, j] == 1)//右1
            {
                FinfLake(i + 1, j);
                c++;
                arr[i + 1, j] = 0;
            }
            if (arr[i , j-1] == 1)//上1
            {
                FinfLake(i , j-1);
                c++;
                arr[i , j-1] = 0;
            }
            if (arr[i , j+1] == 1)//下1
            {
                FinfLake(i , j+1);
                c++;
                arr[i , j+1] = 0;
            }
        }
    }
}
