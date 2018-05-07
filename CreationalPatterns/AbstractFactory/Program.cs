using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var fac1 = new ConcreateFactory1();
            Console.WriteLine(fac1.CreateProductA().Name);
            Console.WriteLine(fac1.CreateProductB().Name);

            var fac2 = new ConcreateFactory2();
            Console.WriteLine(fac2.CreateProductA().Name);
            Console.WriteLine(fac2.CreateProductB().Name);
        }
    }
}
