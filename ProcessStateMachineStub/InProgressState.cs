using System;

namespace ProcessStateMachineStub
{
    public class InProgressState : IProcessState
    {
        private readonly CompleteState _completeState;

        public InProgressState(CompleteState completeState)
        {
            _completeState = completeState;
        }

        public void Execute(Process process)
        {
            Console.WriteLine(process.Name + " - Executing Ready In Progress");
            process.ProcessState = _completeState;
        }
    }
}