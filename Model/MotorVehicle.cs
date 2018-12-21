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
        
    }
}
