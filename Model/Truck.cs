using System;
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
            this.Name = name;
            this.Fuel = fuel;
            this.MaxSpeed = maxSpeed;
            this.StartSpeed = startSpeed;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption;
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

        public override string ToString()
        {
            return TYPE;
        }
    }
}
