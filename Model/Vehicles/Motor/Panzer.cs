using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Panzer : MotorVehicle
    {

        public Panzer(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption) : base(name, fuel, maxSpeed, startSpeed, tankCapacity, fuelConsumption)
        {
            PathToPictures = System.IO.Directory.GetCurrentDirectory() + "\\Resources\\Panzer.png";
        }
    }
}
