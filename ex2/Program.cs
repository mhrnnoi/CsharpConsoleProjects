using System;
using System.Collections.Generic;
using System.Text;
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello plz enter numbers seperated by hyphen (-)");
            Console.WriteLine("i'll say it has dup or not and if you enter witout anythinbg ");
            Console.WriteLine("i'll close the program ");


            Console.Write("enter numbers : ");

            var numbers = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(numbers))
            {
                var stringer = new StringBuilder();




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
                var counter = 0;
                foreach (var item in listNum)
                {
                    counter = 0;
                    for (int i = 0; i < listNum.Count; i++)
                    {
                        if (listNum[i] == item)
                            counter++;

                    }
                    if (counter > 1)
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }
                if (counter <= 1)
                {
                    Console.WriteLine("not dup");
                }
            }
            
            



        }
    }
}
