using System;

namespace leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("leap year calculator");
            Console.WriteLine("enter year : ");
            Console.WriteLine(LeapYear(Convert.ToInt32( Console.ReadLine())));

            
        }
        public static string LeapYear(int year)
        {
            if (year % 4 ==0)
            {
                if(year % 100 ==0)
                {
                    if (year % 400 == 0)
                    {
                        return "leap year";
                    }
                    return "not leap year";
                }
                return "leap year";
            }
            return "not leap year";
        }
    }
}
