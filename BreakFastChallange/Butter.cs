using System;
using System.Threading;

namespace BreakFastChallange
{
    public class Butter
    {
        public static void PutButter()
        {
            Console.WriteLine("Putting Butter on the toast");

            Thread.Sleep(1500);
        }
    }
}
