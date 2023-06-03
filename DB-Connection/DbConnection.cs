using System;

namespace DB_Connection
{
    public abstract class DbConnection
    {
        protected string ConnectionString { get; private set; }
        protected TimeSpan Timeout { get;  set; }

        protected bool IsOpened { get;  set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new Exception();
            }
            this.ConnectionString = connectionString;
            
        }

        public abstract void Open();
        
        public abstract void close();
        
    }
}
