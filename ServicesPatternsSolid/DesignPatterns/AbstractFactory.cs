using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Creates an instance of several families of classes
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    public interface IAbstractProductA
    {
        void OperationA();
    }

    public interface IAbstractProductB
    {
        void OperationB();
    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

    public class ConcreteProductA1 : IAbstractProductA
    {
        public void OperationA()
        {
            // logic here
        }
    }

    public class ConcreteProductA2 : IAbstractProductA
    {
        public void OperationA()
        {
            // logic here
        }
    }

    public class ConcreteProductB1 : IAbstractProductB
    {
        public void OperationB()
        {
            // logic here
        }
    }

    public class ConcreteProductB2 : IAbstractProductB
    {
        public void OperationB()
        {
            // logic here
        }
    }

    public class AbstractFactoryPattern
    {
        public void Run()
        {
            IAbstractFactory factory1 = new ConcreteFactory1();
            IAbstractFactory factory2 = new ConcreteFactory2();
            IAbstractProductA productA1 = factory1.CreateProductA();
            IAbstractProductA productA2 = factory2.CreateProductA();
            IAbstractProductB productB1 = factory1.CreateProductB();
            IAbstractProductB productB2 = factory2.CreateProductB();
        }
    }
}
