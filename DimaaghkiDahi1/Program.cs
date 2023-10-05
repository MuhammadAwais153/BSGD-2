using System;

namespace Methods
{
    internal class Program
    {
        private static int Result;

        public static void Add(int a, int b)
        {
            Result = a + b;
        }

        public static void Subtract(int a, int b)
        {
            Result = a - b;
        }

        public static void Multiply(int a, int b)
        {
            Result = a * b;
        }

        public static void Divide(int a, int b)
        {
            Result = a / b;
        }

        public static void Pass(int a)
        {
            if (a > 35)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static void AGrade(int a)
        {
            if (a >= 96)
            {
                Console.WriteLine("A+ Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static void BGrade(int a)
        {
            if (a >= 73)
            {
                Console.WriteLine("B Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static void CGrade(int a)
        {
            if (a >= 61)
            {
                Console.WriteLine("C Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static void DGrade(int a)
        {
            if (a >= 54)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private static void Fail(int a)
            {
                if (a <= 45)
                {
                    Console.WriteLine("F Grade");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

        public static void Main(string[] args)
        {
            Pass(100);
            AGrade(100);
            Pass(75);
            BGrade(75);
            Pass(64);
            CGrade(64);
            Pass(51);
            DGrade(51);
            Pass(45);
            Fail(45);
        }
    }
}