using System;

namespace ProcessStateMachineStub
{
    public class CompleteState : IProcessState
    {
        public void Execute(Process process)
        {
            Console.WriteLine(process.Name + " - Executing CompleteState");
        }
    }
}