using System;
using System.Collections.Generic;
using System.Text;
namespace Consecutive_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello plz enter numbers seperated by hyphen (-)");
            Console.WriteLine("i'll say its Consecutive or Not Consecutive");

            Console.Write("enter numbers : ");

            var stringer = new StringBuilder();


            var numbers = Console.ReadLine();

            var listNum = new List<int>();
            foreach (var item in numbers)
            {
                if (item == '-')
                {
                    if (string.IsNullOrWhiteSpace(stringer.ToString()))
                    {
                        stringer.Append('-');
                    }
                    else
                    {
                        listNum.Add(Convert.ToInt32(stringer.ToString()));
                        stringer.Clear();
                    }
                }
                else
                {
                    stringer.Append(item);
                }


            }
            listNum.Add(Convert.ToInt32(stringer.ToString()));





            bool m = false;
            for (int i = 0; i < listNum.Count - 1; i++)
            {
                if (listNum[i] - listNum[i + 1] == 1 || listNum[i] - listNum[i + 1] == -1)
                {
                    m = true;
                }
                else
                {
                    m = false;
                    break;
                }
            }
            if (m)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
          

        }
    }
}
