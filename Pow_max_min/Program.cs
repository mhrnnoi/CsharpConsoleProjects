using System;

namespace Pow_max_min
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two num to power it");
            try
            {
                Console.WriteLine("first num : ");
                var firstNum = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("second num : ");
                var secondNum = Convert.ToDouble(Console.ReadLine());

                var power = Pow(firstNum, secondNum);

                Console.WriteLine($"{firstNum} power {secondNum} : {power}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!");
                Console.WriteLine(ex.Message);
            }




            Console.ReadLine();
            Console.Clear();

            var arr = new double[5];

            Console.WriteLine("Enter 5 num to find min and max ");
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"number {i + 1}: ");
                    arr[i] = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine(MinMax(arr));

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!");
                Console.WriteLine(ex.Message);
            }



        }

        public static string MinMax(double[] x)
        {
            if (x.Length < 1)
            {
                return ("yue entered empty");

            }

            return $"Your maximum number is: {Max(x)}\nYour minimum number is: {Min(x)}";

        }

        public static double Pow(double x, double y = 2)
        {
            if (y == 0)
                return 1;

            double num = x;

            for (int i = 1; i < y; i++)
            {
                num = x * num;
            }

            return num;
        }

        public static double Max(double[] x)
        {
            if (x.Length < 1)
            {
                Console.WriteLine("yue entered empty");
                return double.NaN;
            }

            double max = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > max)
                    max = x[i];
            }

            return max;
        }

        public static double Min(double[] x)
        {
            if (x.Length < 1)
            {
                Console.WriteLine("yue entered empty");
                return double.NaN;
            }

            double min = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < min)
                    min = x[i];
            }
            return min;
        }


    }


}

