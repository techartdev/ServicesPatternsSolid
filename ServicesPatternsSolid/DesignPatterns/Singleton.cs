using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // A class of which only a single instance can exist
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void DoSomething()
        {
            //...
        }
    }

    public class SingletonPattern
    {
        public void Run()
        {
            Singleton singleton = Singleton.GetInstance();
            singleton.DoSomething();
        }
    }
}
