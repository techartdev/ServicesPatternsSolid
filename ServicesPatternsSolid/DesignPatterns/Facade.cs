using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Provide a unified interface to a set of interfaces in a subsystem
    public class SubsystemA
    {
        public void OperationA()
        {
            //...
        }
    }

    public class SubsystemB
    {
        public void OperationB()
        {
            //...
        }
    }

    public class SubsystemC
    {
        public void OperationC()
        {
            //...
        }
    }

    public class Facade
    {
        private readonly SubsystemA _subsystemA;
        private readonly SubsystemB _subsystemB;
        private readonly SubsystemC _subsystemC;

        public Facade()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
            _subsystemC = new SubsystemC();
        }

        public void Operation()
        {
            _subsystemA.OperationA();
            _subsystemB.OperationB();
            _subsystemC.OperationC();
        }
    }

    public class FacadePattern
    {
        public void Run()
        {
            Facade facade = new Facade();
            facade.Operation();
        }
    }
}
