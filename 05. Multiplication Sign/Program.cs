using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main()
        {
            int[] inputNumbers = new int[3];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }

            int countOfNegative = GetNegativeCount(inputNumbers);
            bool zero = ChekZero(inputNumbers);

            if (zero == true)
            {
                Console.WriteLine("zero");
                return;
            }
            if (countOfNegative == 1 || countOfNegative == 3)
            {
                Console.WriteLine("negative");
            }
            else 
            {
                Console.WriteLine("positive");
            }
        }
        //check number of negative NUMBERS
        static int GetNegativeCount(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        static bool ChekZero(int[] arr)
        {
            bool haveZero = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    haveZero = true;
                }
            }
            return haveZero;      
        }
    }
}
