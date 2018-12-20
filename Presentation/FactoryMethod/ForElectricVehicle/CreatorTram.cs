using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation.FactoryMethod.ForElectricVehicle
{
    class CreatorTram : ICreatorElectricVehicle
    {
        public ElectricVehicle Creator(string name, double startingSpeed, double maxSpeed)
        {
            return new Tram(name, startingSpeed, maxSpeed);
        }
    }
}
