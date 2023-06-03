using System;

namespace intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new StopWatch();
            var input = "";
            bool continuee = true;
            while (continuee)
            {
                Console.WriteLine("enter: ");
                input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "start":
                        timer.Start();
                        break;
                    case "stop":
                        timer.Stop();
                        break;
                    case "duration":
                        Console.WriteLine( timer._duration);
                        break;


                    default:
                    continuee = false;
                        break;
                }

            }


        }

        public static void Writer(out int num, out int sum)
        {
            num = 50;
            sum = 90;
        }
    }
}
