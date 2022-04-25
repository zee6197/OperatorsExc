using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercise no. 1
            var result1 = Sum(2, 6, 1, 1, 1);
            Console.WriteLine($"The sum is: {result1}");

            var result2 = Multiply(2, 6);
            Console.WriteLine($"The product is: {result2}");

            var result4 = Subtract(2, 6);
            Console.WriteLine($"The difference is: {result4}");

            Console.WriteLine();
            var result3 = Divide(17, 4);


            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine());


            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");
        }

        // Exercise 1
        public static int Sum(params int[] list)
        {
            int TheSum = 0;
            for (int i = 0; i < list.Length; i++)
                TheSum = TheSum + list[i];
            return TheSum;

        }

        public static int Multiply(params int[] list)
        {
            int TheProduct = 1;
            for (int i = 0; i < list.Length; i++)
                TheProduct = TheProduct * list[i];
            return TheProduct;
        }

        public static int Subtract(params int[] list)
        {
            int TheDiff = 0;
            for (int i = 0; i < list.Length; i++)
                TheDiff = list[0] - list[i];
            return TheDiff;
        }

        public static int Divide(int a, int b)
        {
            var answer = a / b;
            var TheRem = a % b;
            int quotient = answer;
            int remainder = TheRem;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {TheRem}");
            return 0;
        }

        // Exercise 2

        public static double AreaOfCircle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);

            return area;
        }

    }
}
