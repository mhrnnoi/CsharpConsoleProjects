using System;
using System.Threading;

namespace DB_Connection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void close()
        {
            if (!IsOpened)
            {
                throw new Exception();
            }
            Console.WriteLine($"closing oracle connection... with this connection string {ConnectionString}");
        }

        public override void Open()
        {
            Timeout = DateTime.Now.TimeOfDay;

            Console.WriteLine($"opening oracle connection... with this connection string {ConnectionString}");


            Thread.Sleep(3000);
            Console.WriteLine($"opened  {ConnectionString}");
            Thread.Sleep(3000);
            Console.WriteLine($"closed  {ConnectionString}");


            if ((DateTime.Now.TimeOfDay - Timeout).Minutes > 5)
            {
                throw new Exception();
            }
            IsOpened = true;
        }
    }
}
