using System;
using System.Threading;
using System.Threading.Tasks;

namespace BreakFastChallange
{
    public class Bacon
    {

        public static void FirstSide()
        {
            Console.WriteLine("cooking first side of bacon...");

            Thread.Sleep(4000);
        }
        public static void SecondSide()
        {
            Console.WriteLine("cooking the second side of bacon...");

            Thread.Sleep(4000);
        }
        public void FlippingSlice()
        {

            Console.WriteLine("flipping a slice of  bacon");

        }


        public static void PutBaconOnPlate()
        {

            Console.WriteLine("Put bacon on plate");
            Thread.Sleep(1000);
            Console.WriteLine("bacon is ready");



        }
    }
}
