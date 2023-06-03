using System;
using System.Threading;

namespace BreakFastChallange
{
    public class juice
    {
        public static void Juice()
        {
            Console.WriteLine("Pouring orange juice");
            Thread.Sleep(2500);
            Console.WriteLine("Juice is ready");
        }
    }
}
