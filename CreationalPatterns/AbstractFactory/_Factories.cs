using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IFactory
    {
        ProductABase CreateProductA();
        ProductBBase CreateProductB();
    }

    public class ConcreateFactory1 : IFactory
    {
        public ProductABase CreateProductA() => new ProductA1();
        public ProductBBase CreateProductB() => new ProductB1();
    }

    public class ConcreateFactory2 : IFactory
    {
        public ProductABase CreateProductA() => new ProductA2();
        public ProductBBase CreateProductB() => new ProductB2();
    }
}
