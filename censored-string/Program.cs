using System;
using System.Text;
using System.Linq;

namespace censored_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome ");
            Console.WriteLine(UnCensor("*PP*RC*S*", "UEAE"));



        }
        public static string UnCensor(string censored, string sensored)
        {
            var str = new StringBuilder(censored);
            int i = 0;
            return string.Join("",censored.Select((x,y) => (x == '*') ? str[y] = sensored[i++]: x));
            
        }
    }
}
