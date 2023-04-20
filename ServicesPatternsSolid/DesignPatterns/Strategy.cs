using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Define a family of algorithms, encapsulate each one, and make them interchangeable
    public interface IStrategy
    {
        void Algorithm();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void Algorithm()
        {
            //...
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Algorithm()
        {
            //...
        }
    }

    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            strategy.Algorithm();
        }
    }

    public class StrategyPattern
    {
        public void Run()
        {
            Context context = new Context(new ConcreteStrategyA());
            context.ExecuteStrategy();
            context.SetStrategy(new ConcreteStrategyB());
            context.ExecuteStrategy();
        }
    }
}
