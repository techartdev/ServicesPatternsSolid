using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Attach additional responsibilities to an object dynamically
    public interface IComponent
    {
        void Operation();
    }

    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            //...
        }
    }

    public abstract class Decorator : IComponent
    {
        private IComponent component;

        public Decorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            component.Operation();
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            //...
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            //...
        }
    }

    public class DecoratorPattern
    {
        public void Run()
        {
            IComponent component = new ConcreteComponent();
            component = new ConcreteDecoratorA(component);
            component = new ConcreteDecoratorB(component);
            component.Operation();
        }
    }
}
