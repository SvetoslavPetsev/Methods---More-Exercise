using System;

namespace _00_TEST_ZONE
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pointA = new double[2];
            double[] pointB = new double[2];
            double[] pointC = new double[2];
            double[] pointD = new double[2];

            for (int i = 0; i < 2; i++)
            {
                pointA[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 2; i++)
            {
                pointB[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 2; i++)
            {
                pointC[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 2; i++)
            {
                pointD[i] = double.Parse(Console.ReadLine());
            }

            double lengthAB = GivelengthBetweenPoints(pointA, pointB);
            double lengthCD = GivelengthBetweenPoints(pointC, pointD);

            double[] pointOne = pointA;
            double[] pointTwo = pointB;

            if (lengthAB < lengthCD)
            {
                pointOne = pointC;
                pointTwo = pointD;
            }

            double distanceZeroToPointOne = GiveDistanceToZero(pointOne);
            double distanceZeroToPointTwo = GiveDistanceToZero(pointTwo);

            if (distanceZeroToPointOne <= distanceZeroToPointTwo)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", pointOne[0], pointOne[1], pointTwo[0], pointTwo[1]);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", pointTwo[0], pointTwo[1], pointOne[0], pointOne[1]);
            }
        }
        static double GivelengthBetweenPoints(double[] firstPoint, double[] secondPoint)
        {
            double a = Math.Abs(firstPoint[0] - secondPoint[0]);
            double b = Math.Abs(firstPoint[1] - secondPoint[1]);
            double c = Math.Sqrt(a * a + b * b);
            return c;

        }
        static double GiveDistanceToZero(double[] array)
        {
            double x = Math.Abs(array[0]);
            double y = Math.Abs(array[1]);
            double c = Math.Sqrt(x * x + y * y);
            return c;
        }
    }
}