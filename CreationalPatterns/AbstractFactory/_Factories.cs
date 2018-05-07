using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class FactoryBase
    {
        public abstract ProductABase CreateProductA();
        public abstract ProductBBase CreateProductB();
    }

    public class ConcreateFactory1 : FactoryBase
    {
        public override ProductABase CreateProductA() => new ProductA1();
        public override ProductBBase CreateProductB() => new ProductB1();
    }

    public class ConcreateFactory2 : FactoryBase
    {
        public override ProductABase CreateProductA() => new ProductA2();
        public override ProductBBase CreateProductB() => new ProductB2();
    }
}
