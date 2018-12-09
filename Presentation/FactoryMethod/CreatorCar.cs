using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation.FactoryMethod
{
    class CreatorCar : ICreatorMotorVehicle
    {
        public MotorVehicle Creator(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption)
        {
            return new Car(name, fuel, maxSpeed, startSpeed, tankCapacity, fuelConsumption);
        }
    }
}
