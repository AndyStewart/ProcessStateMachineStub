using System;

namespace ProcessStateMachineStub
{
    public class InProgressState : IProcessState
    {
        public void Execute(Process process)
        {
            Console.WriteLine("Executing Ready In Progress");
            process.ProcessState = new CompleteState();
        }
    }
}