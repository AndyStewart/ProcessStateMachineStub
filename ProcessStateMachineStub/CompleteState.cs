using System;

namespace ProcessStateMachineStub
{
    public class CompleteState : IProcessState
    {
        public void Execute(Process process)
        {
            Console.WriteLine("Executing CompleteState");
        }
    }
}