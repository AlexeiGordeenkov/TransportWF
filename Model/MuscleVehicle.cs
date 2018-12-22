using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class MuscleVehicle : Vehicle
    {
        public double MaxRange { get; set; }
        public override double GetMaxDistance()
        {
            return MaxRange;
        }
        public override double GetAcceleratingDistance()
        {
            return 1;
        }
    }
}
