using System;
using System.Threading;

namespace BreakFastChallange
{
    public class Toaster
    {
        public void PuttingBreadInToster()
        {

            Console.WriteLine("Putting a slice of bread in the toaster");


            // Thread.Sleep(300);


        }
        public static void StartToasting()
        {
            Console.WriteLine("Start toasting...");
            Thread.Sleep(3500);
            Console.WriteLine("Remove toast from toaster");
        }
    }
}
