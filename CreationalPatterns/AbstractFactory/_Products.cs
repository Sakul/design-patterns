using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class ProductABase
    {
        public string Name => GetType().Name;
    }
    public class ProductA1 : ProductABase { }
    public class ProductA2 : ProductABase { }

    public abstract class ProductBBase
    {
        public string Name => GetType().Name;
    }
    public class ProductB1 : ProductBBase { }
    public class ProductB2 : ProductBBase { }
}
