using System;

namespace timer_checcekr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to this program ");
            Console.WriteLine("i'll check if you entered time format or not ");
            Console.WriteLine("actually time format is time between 00.00 to 23.59");
            Console.WriteLine("so if you do right i'll say ok other wise i'll say not valid");

            var vurudi = Console.ReadLine();;
            
           
           
            try
            {
                var timer = TimeSpan.Parse(vurudi);
                Console.WriteLine("ok");
                    
                
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("not valid");
            }
            

        }
    }
}
