using System;

namespace ProcessStateMachineStub
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new Process();
            process.Execute();
            process.Execute();
            process.Execute();

            Console.ReadLine();
        }
    }
}
