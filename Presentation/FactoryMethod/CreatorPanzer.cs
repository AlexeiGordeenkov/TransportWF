using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation.FactoryMethod
{
    public class CreatorPanzer : ICreatorMotorVehicle
    {
        public MotorVehicle Creator(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption)
        {
            return new Truck(name, fuel, maxSpeed, startSpeed, tankCapacity, fuelConsumption);
        }
    }
}
