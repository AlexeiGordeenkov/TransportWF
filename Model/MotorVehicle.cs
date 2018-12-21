using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    abstract public class MotorVehicle : Vehicle
    {
        protected double TankCapacity { get; set; }
        protected Fuel Fuel { get; set; }
        protected double FuelConsumption { get; set; }
<<<<<<< HEAD
        public override double GetMaxDistance()
        {
            if (FuelConsumption == 0) return 500f - CurrentCoordinate;
            return TankCapacity / FuelConsumption;
        }
=======
        
>>>>>>> 57f2f3f2521b1bdb13af398f4e005240b9227b6f
    }
}
