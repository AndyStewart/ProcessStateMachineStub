namespace ProcessStateMachineStub
{
    public class Process
    {
        public Process()
        {
            ProcessState = new ReadyState();
        }

        public IProcessState ProcessState { get; set; }

        public void Execute()
        {
            ProcessState.Execute(this);
        }
    }
}