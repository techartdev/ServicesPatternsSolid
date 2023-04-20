
using ServicesPatternsSolid.DesignPatterns;

namespace ServicesPatternsSolid.Console
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            new AbstractFactoryPattern().Run();
            new AdapterPattern().Run();
            new CommandPattern().Run();
            new DecoratorPattern().Run();
            new FactoryMethodPattern().Run();
            new FacadePattern().Run();
            new IteratorPattern().Run();
            new ObserverPattern().Run();
            new SingletonPattern().Run();
            new StrategyPattern().Run();
            new TemplateMethodPattern().Run();
        }
    }
}