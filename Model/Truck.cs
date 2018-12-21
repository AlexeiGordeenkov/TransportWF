using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Truck : MotorVehicle
    {
        public Truck(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption)
        {
            this.Name = name;
            this.Fuel = fuel;
            this.MaxSpeed = maxSpeed;
            this.StartSpeed = startSpeed;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption;
        }

        public override Vehicle Clone()
        {
            Truck copy = new Truck(Name, Fuel, MaxSpeed, StartSpeed, TankCapacity, FuelConsumption);
            copy.CurrentCoordinate = CurrentCoordinate;
            copy.BrakingDistances = BrakingDistances;
            copy.CurentSpeed = CurentSpeed;
            copy.Acceleration = Acceleration;
            copy.StartCoordinate = StartCoordinate;
            copy.StartTime = StartTime;
            copy.ReachedMaxSpeed = ReachedMaxSpeed;
            return copy;
        }

        public override double GetAcceleratingDistance()
        {
            throw new NotImplementedException();
        }

        public override double GetMaxDistance()
        {
            throw new NotImplementedException();
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
