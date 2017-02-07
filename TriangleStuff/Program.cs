using System;
using System.Collections.Generic;

namespace TriangleStuff
{
    internal class Program
    {

        public static string _notTriangle = "This is not a triangle";
        public static string _equilateralTriangle = "This is an equilateral triangle";
        public static string _isoscelesTriangle = "This is an isosceles triangle";
        public static string _scaleneTriangle = "This is a scalene triangle";

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter first number and press enter");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number and press enter");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter thrid number and press enter");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(TriangleTest(a,b,c));
            Console.ReadKey();


        }

        public static string TriangleTest(int a, int b, int c)
        {
            if (a+b<c || a+c<b || b+c<a)
            {
                return _notTriangle;
            }
            else if(a == b && a == c)
            {
                return _equilateralTriangle;
            }
            else if ((a == b && a!= c) || (b == c && b != a))
            {
                return _isoscelesTriangle;
            }
            else
            {
                return _scaleneTriangle;
            }
        }
    }
}