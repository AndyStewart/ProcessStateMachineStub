using System;
using Autofac;

namespace ProcessStateMachineStub
{
    class Program
    {
        private readonly ContainerFactory _containerFactory = new ContainerFactory();

        static void Main(string[] args)
        {
            var container = ContainerFactory.Create();
            var processExecuter = container.Resolve<ProcessExecuterBase>();

            var process = new Process();
            processExecuter.Execute(process);
            processExecuter.Execute(process);
            processExecuter.Execute(process);

            Console.ReadLine();
        }
    }

    public class ProcessExecuter : ProcessExecuterBase
    {
        public override void Execute(Process process)
        {
            process.ProcessState.Execute(process);
        }
    }
}
