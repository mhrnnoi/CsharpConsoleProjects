using System;
using System.Threading;

namespace BreakFastChallange
{
    public class Egg
    {
        public static void Warming()
        {
            Console.WriteLine("Warming the egg pan...");
            Thread.Sleep(6000);
            Console.WriteLine("eggs are ready");
        }
    }
}
