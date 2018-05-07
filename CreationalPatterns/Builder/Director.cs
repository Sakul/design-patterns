using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Director
    {
        public void Construct(IVehicleBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
