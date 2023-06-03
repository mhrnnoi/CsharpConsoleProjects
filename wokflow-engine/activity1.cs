using System;

namespace wokflow_engine
{
    public class activity1 : IWorkflow
    {
        public void Excute()
        {
            Console.WriteLine("activity 1");
        }
    }
}
