using System;

namespace PB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            string n1 = str[0];
            string n2 = str[1];



            if (!IsLegal(str[0]) || !IsLegal(str[1]))
            {
                Console.WriteLine($"Wrong Input");
                return;

            }
            AB(n1, n2);
            Console.WriteLine($"{n1} {n2}: {AB(n1, n2)}");



        }
        public static bool IsLegal(string guessNumber)
        {

            for (int i = 0; i < guessNumber.Length; i++)
            {
                for (int j = i + 1; j < guessNumber.Length; j++)
                {
                    if (guessNumber[i] == guessNumber[j])
                    {
                        return false;
                    }
                }
            }
            if (guessNumber.Length != 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
            public static string AB(string n1,string n2)
            {
                int A = 0;
                int B = 0;
                for(int i = 0;i < n1.Length;i++) 
                {
                    if (n1[i] == n2[i] )
                    {
                    A++;
                    }
                    else if (n2.Contains(n1[i])) 
                {
                    B++;
                }
                }
            return $"{A}A{B}B";

            }

        }
    }
