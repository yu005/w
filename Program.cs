using System;

namespace paIsLegal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (IsLegal(str))
            {
                Console.WriteLine($"{str} is legal.");
            }
            else
            {
                Console.WriteLine($"{str} is illegal.");
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

        }
    }
}
