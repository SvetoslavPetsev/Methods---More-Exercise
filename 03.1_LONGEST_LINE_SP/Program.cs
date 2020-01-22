using System;

namespace _00_TEST_ZONE
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[8];

            double maxDistance = 0;

            double[] pointA = new double[2];
            double[] pointB = new double[2];

            for (int i = 0; i < 8; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 8; i += 2)
            {
                for (int j = 2; j < 8; j += 2)
                {
                    double a = Math.Abs(array[i] - array[j]);
                    double b = Math.Abs(array[i + 1] - array[j + 1]);

                    double distance = Math.Sqrt(a * a + b * b);

                    if (distance > maxDistance)
                    {
                        maxDistance = distance;

                        pointA[0] = array[i];
                        pointA[1] = array[i + 1];

                        pointB[0] = array[j];
                        pointB[1] = array[j + 1];
                    }
                }
            }
            double distanceA = GiveDistanceToZero(pointA);
            double distanceB = GiveDistanceToZero(pointB);
            if (distanceA < distanceB)
            {
                Console.Write("(" + string.Join(", ", pointA) + ")");
                Console.Write("(" + string.Join(", ", pointB) + ")");
            }
            else
            {
                Console.Write("(" + string.Join(", ", pointB) + ")");
                Console.Write("(" + string.Join(", ", pointA) + ")");
            }
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
