using System;
using System.Collections.Generic;

namespace TriangleStuff
{
    internal class Program
    {



        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number and press enter");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number and press enter");
            var b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter thrid number and press enter");
            var c = int.Parse(Console.ReadLine());

            Triangle t = new Triangle(a,b,c);

            Console.WriteLine(t.TriangleTest());
            Console.ReadKey();
        }


    }
}