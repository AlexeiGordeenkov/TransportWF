using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    abstract public class MotorVehicle : Vehicle
    {
        protected double tankCapacity;
        protected Fuel fule;
        protected double fuelConsumption;
    }
}
