using System;
using System.Collections.Generic;
namespace newwwwww
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello wlc to my program!");
            Console.WriteLine("this is vowel counter!");

            Console.WriteLine("so plz enter your text ");

            var input = Console.ReadLine();
            var vowelList = new List<char>(){'a', 'e', 'o','u','i'};
            var vovelCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (vowelList.Contains(input[i]))
                
                    vovelCounter++;
                
            }
            Console.WriteLine(vovelCounter);

        }
    }
}
