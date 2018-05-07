using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            IVehicleBuilder motorCycle = new MotorCycleBuilder();
            director.Construct(motorCycle);
            motorCycle.GetResult.Show();

            IVehicleBuilder car = new CarBuilder();
            director.Construct(car);
            car.GetResult.Show();

            IVehicleBuilder scoote = new ScooterBuilder();
            director.Construct(scoote);
            scoote.GetResult.Show();
        }
    }
}
