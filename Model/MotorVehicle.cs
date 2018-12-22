﻿using System;
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
        public override double GetMaxDistance()
        {
            if (FuelConsumption == 0) return 500f - CurrentCoordinate;
            return TankCapacity*100 / FuelConsumption;
        }
        public override double GetAcceleratingDistance()
        {
            return 1;
        }
    }
}
