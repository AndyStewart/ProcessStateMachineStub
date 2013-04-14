using System;

namespace ProcessStateMachineStub
{
    public class ReadyState : IProcessState
    {
        private InProgressState _inProgressState;

        public ReadyState(InProgressState inProgressState)
        {
            _inProgressState = inProgressState;
        }

        public void Execute(Process process)
        {
            if (process.HasFailingPreCondition)
            {
                Console.WriteLine(process.Name + " - Has failing pre condition stays at state stays at ready state");
                return;
            }

            Console.WriteLine(process.Name + " - Executing Ready Process");
            process.ProcessState = _inProgressState;
        }
    }
}