using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MotorVehicle : Vehicle
    {
        protected MotorVehicle(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption)
        {
            this.Name = name;
            this.Fuel = fuel;
            this.MaxSpeed = maxSpeed;
            this.StartSpeed = startSpeed;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption;
            Init();
        }
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
        public override Vehicle Clone()
        {
            Car copy = new Car(Name, Fuel, MaxSpeed, StartSpeed, TankCapacity, FuelConsumption)
            {
                CurrentCoordinate = CurrentCoordinate,
                CurentSpeed = CurentSpeed,
                Acceleration = Acceleration,
                StartCoordinate = StartCoordinate,
                StartTime = StartTime,
                ReachedMaxSpeed = ReachedMaxSpeed
            };
            return copy;
        }
    }
}
