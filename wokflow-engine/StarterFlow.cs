using System;

namespace wokflow_engine
{
    public class StarterFlow :IWorkflow
    {
        public void Excute()
        {
            Console.WriteLine("activity 2");
        }
    }
}
