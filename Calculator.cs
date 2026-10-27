using System;

namespace Zachet
{
    public class Calculator
    {
        public static string Message = "Hello GitHub!";

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Main()
        {
            Console.WriteLine(Message);
            Console.WriteLine($"2 + 3 = {Add(2, 3)}");
        }
    }
}
