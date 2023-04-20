using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Define the skeleton of an algorithm in an operation, deferring some steps to subclasses
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
    }

    public class ConcreteClass : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            //...
        }

        protected override void PrimitiveOperation2()
        {
            //...
        }
    }

    public class TemplateMethodPattern
    {
        public void Run()
        {
            AbstractClass c = new ConcreteClass();
            c.TemplateMethod();
        }
    }
}
