using Autofac;

namespace ProcessStateMachineStub
{
    class ContainerFactory
    {
        public static IContainer Create()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProcessExecuter>().As<ProcessExecuterBase>();
            builder.RegisterType<ReadyState>().As<IProcessState>();
            builder.RegisterType<InProgressState>().As<IProcessState>();
            builder.RegisterType<CompleteState>().As<IProcessState>();
            var container = builder.Build();
            return container;
        }
    }
}