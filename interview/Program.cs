using System;
using System.Linq;
namespace interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ");
            Console.WriteLine("welcome to my interview test");
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120));


        }

        public static string Interview(int[] arr, int tot)

        {
            int tup = 0;
            bool qualified;
            bool qualified2;
            bool tedad;
            var x = arr.Select((x, y) => (y < 2 && y >= 0) ? ((x <= 5) ? tup += 0 : tup += 1) : (y < 4 && y >= 2) ? ((x <= 10) ? tup += 0 : tup += 1) : (y <= 5 && y >= 4) ? ((x <= 15) ? tup += 0 : tup += 1) : (y < 8 && y >= 6) ? ((x <= 20) ? tup += 0 : tup += 1) : tup += 0).Sum();
            qualified = ((x > 0) ? false : true);
            qualified2 = ((tot <= 120) ? true : false);
            var qualified3 = arr.Count();
            tedad = ((qualified3 == 8) ? true : false);
            if (qualified)
            {
                if (qualified2)
                {
                    if (tedad)
                    {
                        return tedad.ToString();
                    }
                    return false.ToString();
                }
                return false.ToString();
            }
            return false.ToString();




        }
    }
}
