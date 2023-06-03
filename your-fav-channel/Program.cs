using System;

namespace your_fav_channel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi welcome");
            Console.WriteLine("this program will find your favorite tv channel");

            var channel = 1;
            string changer = null;

            do
            {
                Console.Clear();
                Console.WriteLine("now you are watching channel number {0} ", channel);
                Console.WriteLine("do you like it ? Yes or No ");
                changer = Console.ReadLine();
                while (changer.ToLower() != "yes" && changer.ToLower() != "no")
                {
                    Console.WriteLine("plz enter just  yes or no");
                    changer = Console.ReadLine();
                }
                if (changer.ToLower() == "no")
                {
                    Console.WriteLine("ok lets go to next channel");
                    channel++;
                    
                }



            } while (changer.ToLower() != "yes");

            Console.WriteLine("enjoy!");
            Console.WriteLine("your fav channel is {0}", channel);
        }
    }
}