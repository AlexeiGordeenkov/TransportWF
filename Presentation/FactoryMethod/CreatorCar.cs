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
        public Vehicle Creator()
        {
            return new Car();
        }
    }
}
