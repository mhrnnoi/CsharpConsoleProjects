using System;

namespace DB_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new OracleConnection("lalalala") ;
            x.Open();
            x.close();

        }
    }
}
