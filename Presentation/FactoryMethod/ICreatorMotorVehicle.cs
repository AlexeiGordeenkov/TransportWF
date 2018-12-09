using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.FactoryMethod
{
    public interface ICreatorMotorVehicle
    {
        MotorVehicle Creator(string name, Fuel fuel, double maxSpeed, double startSpeed, double tankCapacity, double fuelConsumption);
    }
}
