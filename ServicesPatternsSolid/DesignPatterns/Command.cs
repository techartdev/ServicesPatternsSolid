using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations
    public interface ICommand
    {
        void Execute();
    }

    public class Receiver
    {
        public void Action()
        {
            //...
        }
    }

    public class ConcreteCommand : ICommand
    {
        private Receiver receiver;

        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Action();
        }
    }

    public class Invoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }

    public class CommandPattern
    {
        public void Run()
        {
            Receiver receiver = new Receiver();
            ICommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}
