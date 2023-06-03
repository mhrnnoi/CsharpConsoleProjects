using System;
using System.Linq;

namespace Pow_Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(2, 3));
            Console.WriteLine(Minimum(new double[] {1,2,3,4}));
            Console.WriteLine(Maximum(new double[] {1,2,3,4}));
        }
        public static double Pow(double number, double Power)
        {
            var sum = number;
            if (Power == 0 ) 
                return 1;
            for (int i = 1; i < Power; i++)
            {
                sum *= number;
            }
            return sum;
        }
        public static double Maximum(double[] numbers)
        {
            var max = numbers[0];
            foreach (var item in numbers)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static double Minimum (double[] numbers)
        {
            var min = numbers[0];
            foreach (var item in numbers)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
