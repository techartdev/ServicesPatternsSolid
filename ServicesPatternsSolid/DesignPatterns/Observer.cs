using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int state;

        public int State
        {
            get { return state; }
            set
            {
                state = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }
    }

    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            int state = ((ConcreteSubject)subject).State;
            //...
        }
    }

    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            int state = ((ConcreteSubject)subject).State;
            //...
        }
    }

    public class ObserverPattern
    {
        public void Run()
        {
            ConcreteSubject subject = new ConcreteSubject();
            subject.Attach(new ConcreteObserverA());
            subject.Attach(new ConcreteObserverB());
            subject.State = 1;
            subject.State = 2;
        }
    }
}
