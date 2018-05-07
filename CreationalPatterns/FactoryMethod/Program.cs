using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factoryA = new ConcreteFactoryA();
            Console.WriteLine(factoryA.CreateProduct().GetType().Name);

            IFactory factoryB = new ConcreteFactoryB();
            Console.WriteLine(factoryB.CreateProduct().GetType().Name);

            IFactory factoryC = new ConcreteFactoryC();
            Console.WriteLine(factoryB.CreateProduct().GetType().Name);
        }
    }
}
