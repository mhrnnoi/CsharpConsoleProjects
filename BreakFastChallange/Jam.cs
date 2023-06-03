using System;
using System.Threading;

namespace BreakFastChallange
{
    public class Jam
    {
        
        public static void PutJam()
        {
            Console.WriteLine("Putting jam on the toast");
            Thread.Sleep(2000);
            Console.WriteLine("toast is ready");

        }
    }
}
