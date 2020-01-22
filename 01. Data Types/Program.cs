using System;

namespace _01._Data_Types
{
    class Program
    {
        public static void Main()
        {
            string dataType = Console.ReadLine();
            string input = Console.ReadLine();
            string result = "";
            switch (dataType)
            {
                case "string":
                    result = GiveSomeResult(dataType, input);
                    Console.WriteLine(result);
                    break;
                case "int":
                    result = GiveSomeResult(dataType, input);
                    int i = int.Parse(result);
                    Console.WriteLine(i);
                    break;
                case "real":
                    result = GiveSomeResult(dataType, input);
                    double d = double.Parse(result);
                    Console.WriteLine("{0:F2}", d);
                    break;
            }

        }
        public static string GiveSomeResult(string dataType, string input)
        {
            string result = "";
            if (dataType == "string")
            {
                result = "$" + input + "$";
            }
            else if (dataType == "int")
            {
                int number = int.Parse(input);
                number *= 2;
                result = number.ToString();
            }
            else if (dataType == "real")
            {
                double number = double.Parse(input);
                number *= 1.5;
                result = number.ToString();
            }
            return result;
        }
    }
}
