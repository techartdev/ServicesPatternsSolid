using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesPatternsSolid.DesignPatterns
{
    // Creates an instance of several derived classes
    public class FactoryMethod
    {
        public Product CreateProduct(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.ProductA:
                    return new ProductA();
                case ProductType.ProductB:
                    return new ProductB();
                default:
                    throw new ArgumentOutOfRangeException(nameof(productType), productType, null);
            }
        }
    }

    public enum ProductType
    {
        ProductA,
        ProductB
    }

    public abstract class Product
    {
        public abstract void Operation();
    }

    public class ProductA : Product
    {
        public override void Operation()
        {
            // logic here
        }
    }

    public class ProductB : Product
    {
        public override void Operation()
        {
            // logic here
        }
    }

    public class FactoryMethodPattern
    {
        public void Run()
        {
            FactoryMethod factoryMethod = new FactoryMethod();
            Product productA = factoryMethod.CreateProduct(ProductType.ProductA);
            productA.Operation();
            Product productB = factoryMethod.CreateProduct(ProductType.ProductB);
            productB.Operation();
        }
    }
}
