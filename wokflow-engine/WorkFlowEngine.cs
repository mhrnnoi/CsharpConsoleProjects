using System;

namespace wokflow_engine
{
    public class WorkFlowEngine 
    {
        public void Run(IWorkflow workflow)
        {
            workflow.Excute();
        }
    }
}
