﻿using System;

namespace Calculator1
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

        public static void Main(string[] args)
        {
            Add(10, 45);
            Console.WriteLine("Answer is: " + Result);
            Subtract(50, 12);
            Console.WriteLine("Answer is: " + Result);
            Multiply(100, 74);
            Console.WriteLine("Answer is: " + Result);
            Divide(12,85);
            Console.WriteLine("Answer is: " + Result);
        }
    }
}