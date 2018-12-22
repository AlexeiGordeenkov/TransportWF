﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Panzer : MotorVehicle
    {

        public Panzer(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption)
        {
            PathToPictures = System.IO.Directory.GetCurrentDirectory() + "\\Resources\\Panzer.png";
            this.Name = name;
            this.Fuel = fuel;
            this.MaxSpeed = maxSpeed;
            this.StartSpeed = startSpeed;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption;
            Init();
        }
        public override Vehicle Clone()
        {
            Panzer copy = new Panzer(Name, Fuel, MaxSpeed, StartSpeed, TankCapacity, FuelConsumption)
            {
                CurrentCoordinate = CurrentCoordinate,
                BrakingDistances = BrakingDistances,
                CurentSpeed = CurentSpeed,
                Acceleration = Acceleration,
                StartCoordinate = StartCoordinate,
                StartTime = StartTime,
                ReachedMaxSpeed = ReachedMaxSpeed
            };
            return copy;
        }
       
        public override double GetAcceleratingDistance()
        {
            return 5;
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