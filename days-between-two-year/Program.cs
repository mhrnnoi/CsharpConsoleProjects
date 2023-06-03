using System;

namespace days_between_two_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heyy there");
            Console.WriteLine("enter two dates with this format: \"day, month, year\"");

            Console.WriteLine("enter date 1 :");
            var date1 = Console.ReadLine();

            Console.WriteLine("enter date 2 :");
            var date2 = Console.ReadLine();
            try
            {
                Console.WriteLine(Differences(date1, date2) + " " + "days");

            }
            catch (Exception)
            {

                Console.WriteLine("invalid input");
            }

        }
        public static int Differences(string date1, string date2)
        {

            var arr1 = date1.Split(',');

            var arr2 = date2.Split(',');


            var days1 = days(arr1);
            var days2 = days(arr2);

            return Math.Abs(days1 - days2);




        }

        public static int days(string[] arr1)
        {
            if (arr1.Length != 3)
            {
                throw new Exception();
            }
            if (int.Parse(arr1[2]) < 0 || int.Parse(arr1[1]) > 12 || int.Parse(arr1[1]) < 1 || int.Parse(arr1[0]) > 31 || int.Parse(arr1[0]) < 1)
            {
                throw new Exception();
            }
            if (int.Parse(arr1[1]) > 6 && int.Parse(arr1[0]) > 30)
            {
                throw new Exception();
            }
            if ((!IsLeapYear(int.Parse(arr1[2]))) && int.Parse(arr1[1]) == 12 && int.Parse(arr1[0]) > 29)
            {
                throw new Exception();
            }
            var counter = 0;
            for (int i = 1; i <= int.Parse(arr1[2]); i++)
            {
                if (IsLeapYear(i))
                {
                    counter++;
                }//
            }
            int day = counter;

            int mahhaye_31_ruze = int.Parse(arr1[2]) * 6;
            day += mahhaye_31_ruze * 31;

            int mahhaye_30_ruze = int.Parse(arr1[2]) * 5;
            day += mahhaye_30_ruze * 30;

            int mahhaye_29_ruze = int.Parse(arr1[2]);
            day += mahhaye_29_ruze * 29;

            if (int.Parse(arr1[1]) <= 6)
            {
                day += (int.Parse(arr1[1]) - 1) * 31;
                day += (int.Parse(arr1[0]));
            }
            else if (int.Parse(arr1[1]) > 6 && int.Parse(arr1[1]) <= 12)
            {
                day += 6 * 31;
                day += (int.Parse(arr1[1]) - 6 - 1) * 30;
                day += (int.Parse(arr1[0]));


            }

            return day;
        }


        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                    return (year % 400 == 0) ? true : false;
                return true;
            }
            return false;

        }
    }
}
