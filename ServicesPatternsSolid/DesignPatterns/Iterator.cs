using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

    public interface IAggregate
    {
        IIterator GetIterator();
    }

    public class ConcreteAggregate : IAggregate
    {
        private object[] items;

        public ConcreteAggregate(object[] items)
        {
            this.items = items;
        }

        public IIterator GetIterator()
        {
            return new ConcreteIterator(items);
        }
    }

    public class ConcreteIterator : IIterator
    {
        private object[] items;
        private int position = 0;

        public ConcreteIterator(object[] items)
        {
            this.items = items;
        }

        public bool HasNext()
        {
            return position < items.Length;
        }

        public object Next()
        {
            object item = items[position];
            position++;
            return item;
        }
    }

    public class IteratorPattern
    {
        public void Run()
        {
            object[] items = { "Item 1", "Item 2", "Item 3" };
            IAggregate aggregate = new ConcreteAggregate(items);
            IIterator iterator = aggregate.GetIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
