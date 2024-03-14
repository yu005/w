using System;

namespace PB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            strimg
            

            if (!IsLegal(str[0]) || !IsLegal(str[1]))
            {
                Console.WriteLine($"Wrong Input");
            }



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
            public string AB(strimg str[0],string str[1])
            {
                
            }

        }
    }
}
