using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ElectricVehicle : Vehicle
    {
        public override double GetAcceleratingDistance()
        {
            return 1;
        }

        public override double GetMaxDistance()
        {
            return 500f - StartCoordinate;
        }
    }
}
