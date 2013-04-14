using Autofac;

namespace ProcessStateMachineStub
{
    class ContainerFactory
    {
        public static IContainer Create()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProcessExecuter>().As<ProcessExecuterBase>();
            builder.RegisterType<ReadyState>().As<IProcessState>().AsSelf();
            builder.RegisterType<InProgressState>().As<IProcessState>().AsSelf();
            builder.RegisterType<CompleteState>().As<IProcessState>().AsSelf();
            var container = builder.Build();
            return container;
        }
    }
}