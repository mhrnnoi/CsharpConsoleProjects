using System;

namespace favorite_tv_channel_founder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi welcome to tv controller !");
            var channel = "1";
            string changer = null;
           
            do
            {
                
                Console.WriteLine("you are now watching channel number {0} ",channel);
                Console.WriteLine("do you want to change ? Y or N ");
                changer = Console.ReadLine();
                
                if (changer.ToLower() == "y")
                {
                    Console.Write("plz enter the channel number you want to watch:  ");
                    channel = Console.ReadLine();
                }


                
            } while (changer.ToLower() == "y" );

            Console.WriteLine("enjoy!");
            Console.WriteLine("your fav channel is {0}",channel);
        }
    }
}
