using System;

namespace _1207_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int N = input.Length;
            int M = (int)Math.Ceiling(Math.Sqrt(N));

            char[,] c = new char[M, M];
            //String[] b = input.Split(""); 
            int index = 0;
            //String[] b = new string[N];


            for (int i =0;i<M;i++)
            {
                for(int j=0;j<M;j++)
                {
                    if (index<N)
                    {
                        c[i,j] = input[index];
                    }
                    else
                    {
                        c[i, j] =' ';
                    }
                        index++;
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(c[j, i]);

                }
            }


        }
    }
}
