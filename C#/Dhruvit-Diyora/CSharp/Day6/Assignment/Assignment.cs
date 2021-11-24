using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Assignment
    {
        //1

        public static int Area(int l, int b)
        {
            return l * b;
        }
        static void Main(string[] args)
        {
            //Compute area of rectangle using func delegate

            Func<int, int, int> rect = Area;

            int result = rect(10, 10);

            Console.WriteLine(result);

            //Compute add of two number using lambda expression
            Func<int, int, int> Sum = (x, y) => x + y;

            int resultSum = Sum(10, 20);

            Console.WriteLine(resultSum);
        }
    }
}
