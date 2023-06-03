using System;

namespace wokflow_engine
{
    class Program
    {
        static void Main(string[] args)
        {
           var work = new WorkFlowEngine();
           work.Run(new StarterFlow());
           work.Run(new activity1());

        }
    }
}
