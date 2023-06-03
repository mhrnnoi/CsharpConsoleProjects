using System;
using System.Text;
namespace string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder lets = new StringBuilder();

            lets
                .Append("54.99")
                .AppendFormat("$","5454")
                .Remove(5,1)
                .AppendLine()
                .AppendJoin(',',new char[2]{'u','j'});
                
            Console.WriteLine(lets);
        }
    }
}
