using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] tribArray = new int[3];
            tribArray[2] = 1;
            
            int[] temp = new int[3];


            Console.Write(tribArray[2] + " ");

            for (int i = 1; i < num; i++)
            {

                int sum = 0;

                sum = GiveSumTribonacciArray(tribArray, sum);

                Console.Write(sum + " ");

                tribArray = GiveTribonacciArray(tribArray, temp, sum);

            }
        }

        private static int GiveSumTribonacciArray(int[] tribArray, int sum)
        {
            for (int k = 0; k < tribArray.Length; k++)
            {
                sum += tribArray[k];
            }

            return sum;
        }

        private static int[] GiveTribonacciArray(int[] tribArray, int[] temp, int sum)
        {
            for (int j = 0; j < temp.Length - 1; j++)
            {
                temp[j] = tribArray[j + 1];
            }
            temp[2] = sum;
            tribArray = temp;
            return tribArray;
        }
    }
}
