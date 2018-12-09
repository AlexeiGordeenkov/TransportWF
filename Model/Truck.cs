﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Truck : MotorVehicle
    {
        public static string TYPE = "Грузовик";
        public Truck(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption)
        {
            this.name = name;
            this.fuel = fuel;
            this.maxSpeed = maxSpeed;
            this.startSpeed = startSpeed;
            this.tankCapacity = tankCapacity;
            this.fuelConsumption = fuelConsumption;
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

        public override string ToString()
        {
            return TYPE;
        }
    }
}
