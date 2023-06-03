using System;
using System.Text;
using System.Collections.Generic;
namespace variable_creator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello this is var generator with pascal case formating");
            Console.Write("plz enter some word with space between them : ");

            var input = Console.ReadLine();
            var arrStr = input
                            .ToLower()
                            .Split(" ");

            foreach (var item in arrStr)
            {
                var newStr = new StringBuilder(item);
                newStr[0] = char.ToUpper(newStr[0]);
                Console.Write(newStr);
                newStr.Clear();
                
            }

            
        }
    }
}
