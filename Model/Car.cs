using System;
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
            this.Name = name;
            this.fuel = fuel;
            this.MaxSpeed = maxSpeed;
            this.StartSpeed = startSpeed;
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
    }
}
