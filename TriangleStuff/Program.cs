using System;

namespace TriangleStuff
{
    internal class Program
    {



        public static void Main(string[] args)
        {
            var a = 0;
            var b = 0;
            var c = 0;
            Console.WriteLine("Enter first number and press enter");
            var s = Console.ReadLine();
            if (s != null) a = int.Parse(s);

            Console.WriteLine("Enter second number and press enter");
            s = Console.ReadLine();
            if (s != null) b = int.Parse(s);


            Console.WriteLine("Enter thrid number and press enter");


            s = Console.ReadLine();
            if (s != null) c = int.Parse(s);

            Triangle t = new Triangle(a,b,c);

            Console.WriteLine(t.TriangleTest());
            Console.ReadKey();
        }


    }
}