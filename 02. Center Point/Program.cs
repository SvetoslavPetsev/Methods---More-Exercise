using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main()
        {
            double minDistance = double.MaxValue;
            double bestX = 0;
            double bestY = 0;
            for (int i = 0; i < 2; i++)
            {
                double x= double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double distance = GiveDistanceToZero(x, y);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    bestX = x;
                    bestY = y;
                }

            }
            Console.WriteLine($"({bestX}, {bestY})");

        }
        static double GiveDistanceToZero(double x, double y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            double c = Math.Sqrt(x * x + y * y);
            return c;

        }
    }
}
