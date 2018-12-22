using System;
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
    }
}
