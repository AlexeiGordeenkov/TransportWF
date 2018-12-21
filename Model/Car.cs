﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car : MotorVehicle
    {
      
        public Car(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption )
        {
            PathToPictures = System.IO.Directory.GetCurrentDirectory() + "\\Resources\\CarIcon.png";
            this.Name = name;
            this.Fuel = fuel;
            this.MaxSpeed = maxSpeed;
            this.StartSpeed = startSpeed;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption;
            SetAcceleration();
        }

        public override double GetAcceleratingDistance()
        {
            return 3;
        }

        public override double GetMaxDistance()
        {
            return TankCapacity / FuelConsumption;
        }

        public override void SaveDate()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            
            throw new NotImplementedException();
        }

        public override void Step()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
