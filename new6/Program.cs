using System;

namespace new6
{
    class Program
    {
        static void Main(string[] args)
        {
            var chnge = 0 ;
            var x =0;
            var lastnum = 512;
            for (int i = 0; i <= lastnum; i++)
            {
                x++;
                if (Convert.ToString(i,16).Length != Convert.ToString(lastnum,16).Length)
                {
                    chnge =  Convert.ToString(lastnum,16).Length-Convert.ToString(i,16).Length ;
                    for (int m = 0; m < chnge; m++)
                    {
                        System.Console.Write(0);
                    }
                }
                System.Console.Write(Convert.ToString(i,16)); 
                if (x %16 == 0)
                {
                    System.Console.WriteLine("");
                }
                else {
                    System.Console.Write(" ");
                }
            }


            


        }
    }
}
