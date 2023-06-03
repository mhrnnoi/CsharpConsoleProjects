using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BreakFastChallange
{

    class Program
    {
        static async Task Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            await PoorCoffe();

            Task.WaitAll(FryEgg(), FryBeacon(3), ToastBread(2));
            await PoorJuice();
            Console.WriteLine("Breakfast is ready!");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds + " ms ");

        }
        public static async Task PoorCoffe()
        {
            await Task.Run(() =>
            {

                var cup = new Coffe();
                cup.Brew();
            });

        }



        public static async Task FryEgg()
        {
            await Task.Run(() =>
                       {
                           Egg.Warming();
                       });
        }
        public static async Task FryBeacon(int quantinty)
        {

            await Task.Run(() =>
            {
                var bacons = new List<Bacon>();
                for (int i = 0; i < quantinty; i++)
                {
                    bacons.Add(new Bacon());
                }
                Bacon.FirstSide();

                foreach (var item in bacons)
                {
                    item.FlippingSlice();
                }
                Bacon.SecondSide();
                Bacon.PutBaconOnPlate();


            });
        }
        public static async Task ToastBread(int quantity)
        {
            await Task.Run(() =>
            {
                var Toasts = new List<Toaster>();
                for (int i = 0; i < quantity; i++)
                {
                    Toasts.Add(new Toaster());
                }
                foreach (var item in Toasts)
                {
                    item.PuttingBreadInToster();
                }
                Toaster.StartToasting();
            });

            await Task.Run(() =>
            {
                Butter.PutButter();
                Jam.PutJam();
            });

        }

        public static async Task PoorJuice()
        {
            await Task.Run(() =>
                       {
                           juice.Juice();
                       });
        }

    }
}
