using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Convert the interface of a class into another interface clients expect
    public interface ITarget
    {
        void Request();
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            //...
        }
    }

    public class Adapter : ITarget
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    public class AdapterPattern
    {
        public void Run()
        {
            ITarget target = new Adapter(new Adaptee());
            target.Request();
        }
    }
}
