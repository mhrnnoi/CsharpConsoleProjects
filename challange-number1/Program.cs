using System;

namespace hypotenuse_challange
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("welcome  ");
            Console.WriteLine("this is hypotenuse calculator using Pythagorean theorem  ");
            Console.WriteLine("which states that the square of the length of the hypotenuse (c)  ");
            Console.WriteLine("equals the sum of the squares of the lengths of the other two sides (a), (b).");
            Console.Write("plz enter side a: ");
            var sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("plz enter side b: ");
            var sideB = Convert.ToDouble(Console.ReadLine());

            var hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            Console.WriteLine("length of the hypotenuse is: {0}", hypotenuse);

        }
    }
}
