using System.Collections.Generic;

namespace ProcessStateMachineStub
{
    public class Process
    {
        public Process(string name, bool hasFailingPreCondition  = false)
        {
            Name = name;
            HasFailingPreCondition = hasFailingPreCondition;
        }

        public IProcessState ProcessState { get; set; }
        public List<Process> Children { get; set; }
        public string Name { get; set; }
        public bool HasFailingPreCondition { get; set; }
    }
}