using System;
using System.Collections.Generic;
namespace new0_
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("entr num i will show you that in hex and binary untill you enter 0");

            System.Console.WriteLine("enter num ");

            var num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                int hexx = num;
                int reminder ;
                var hexint = new List<object>();

                while (hexx >= 16)
                {
                    reminder = hexx % 16;
                    switch (reminder)
                    {
                        case 10:
                        hexint.Add("A");
                        break;
                        case 11:
                        hexint.Add("B");
                        break;
                        case 12:
                        hexint.Add("C");
                        break;
                        case 13:
                        hexint.Add("D");
                        break;
                        case 14:
                        hexint.Add("E");
                        break;
                        case 15:
                        hexint.Add("F");
                        break;
                        default:
                        hexint.Add(reminder);
                        break;
                    }

                    hexx = hexx / 16;



                }
                hexint.Add(hexx);

                hexint.Reverse();
                foreach (var item in hexint)
                {
                    System.Console.Write(item);
                }


                System.Console.WriteLine();

                int numB = num;
                var ints = new List<Int32>();

                while (numB >= 2)
                {
                    ints.Add(numB % 2);
                    numB = numB / 2;


                }
                ints.Add(numB);

                ints.Reverse();
                foreach (var item in ints)
                {
                    System.Console.Write(item);
                }
                System.Console.WriteLine("\nenter num");
                num = Convert.ToInt32(Console.ReadLine());
            }






        }
    }
}
