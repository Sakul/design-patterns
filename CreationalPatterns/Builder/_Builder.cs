using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IVehicleBuilder
    {
        Product GetResult { get; }
        void BuildPartA();
        void BuildPartB();
    }

    public class MotorCycleBuilder : IVehicleBuilder
    {
        public Product GetResult { get; private set; } = new Product();

        public void BuildPartA() => GetResult.Add("MotorCycle-Part-A");
        public void BuildPartB() => GetResult.Add("MotorCycle-Part-B");
    }

    public class CarBuilder : IVehicleBuilder
    {
        public Product GetResult { get; private set; } = new Product();

        public void BuildPartA() => GetResult.Add("Car-Part-A");
        public void BuildPartB() => GetResult.Add("Car-Part-B");
    }

    public class ScooterBuilder : IVehicleBuilder
    {
        public Product GetResult { get; private set; } = new Product();

        public void BuildPartA() => GetResult.Add("Scooter-Part-A");
        public void BuildPartB() => GetResult.Add("Scooter-Part-B");
    }
}
