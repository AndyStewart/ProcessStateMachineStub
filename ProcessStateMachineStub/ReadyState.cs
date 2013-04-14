using System;

namespace ProcessStateMachineStub
{
    public class ReadyState : IProcessState
    {
        public void Execute(Process process)
        {
            Console.WriteLine("Executing Ready Process");
            process.ProcessState = new InProgressState();
        }
    }
}