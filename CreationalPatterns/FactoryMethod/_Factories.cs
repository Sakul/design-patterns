using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface IFactory
    {
        IProduct CreateProduct();
    }

    public class ConcreteFactoryA : IFactory
    {
        public IProduct CreateProduct() => new ProductA();
    }

    public class ConcreteFactoryB : IFactory
    {
        public IProduct CreateProduct() => new ProductB();
    }

    public class ConcreteFactoryC : IFactory
    {
        public IProduct CreateProduct() => new ProductC();
    }
}
