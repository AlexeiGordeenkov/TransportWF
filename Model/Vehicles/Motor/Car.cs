using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car : MotorVehicle
    {
      
        public Car(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption ):base(name,fuel,maxSpeed,startSpeed,tankCapacity,fuelConsumption)
        {
            PathToPictures = System.IO.Directory.GetCurrentDirectory() + "\\Resources\\CarIcon.png";
        }
        public override Vehicle Clone()
        {
            Car copy = new Car(Name, Fuel, MaxSpeed, StartSpeed, TankCapacity, FuelConsumption)
            {
                CurrentCoordinate = CurrentCoordinate,
                StartSpeed = StartSpeed,
                MaxSpeed = MaxSpeed,
                FuelConsumption = FuelConsumption,
                TankCapacity = TankCapacity,
                Acceleration = Acceleration,
                StartCoordinate = StartCoordinate,
                StartTime = StartTime,
                ReachedMaxSpeed = ReachedMaxSpeed
            };
            return copy;
        }
    }
}
