using System;
using System.Threading;

namespace BreakFastChallange
{
    public class Coffe
    {
        
        public void Brew()
        {
            Console.WriteLine("Pouring coffee");
            Thread.Sleep(5000);
            Console.WriteLine("coffee is ready");
        }
    }
}
