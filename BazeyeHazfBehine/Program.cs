using System;
using System.Collections.Generic;
using System.Linq;

namespace BazeyeHazfBehine
{
    class Program
    {
        static void Main(string[] args)
        {
            var tedadSatr = Convert.ToInt32(Console.ReadLine());
            var lstStr = new List<string>();

            for (int i = 0; i < tedadSatr; i++)
            {
                lstStr.Add(Console.ReadLine());
            }
            var lstInt = new List<int>();

            for (int i = 0; i < lstStr.Count; i++)
            {
                lstInt.AddRange(Enumerable.Range(int.Parse(lstStr[i].Split()[0]),(int.Parse(lstStr[i].Split()[1]) - int.Parse(lstStr[i].Split()[0])) +1));
                
            }
            lstInt.Sort();
            var lstyekTaSad = new List<int>(Enumerable.Range(1,100)) ;
            var lstYadaki = new List<int>(lstInt);
            while (lstyekTaSad.FindIndex(a=> lstYadaki.Contains(a) == false) < 0 )
            {
                
            }
            lstyekTaSad.Find(a=> lstYadaki.Contains(a) == false);
        }
    }
}
