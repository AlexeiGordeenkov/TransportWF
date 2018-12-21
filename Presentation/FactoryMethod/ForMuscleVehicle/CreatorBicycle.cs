using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation.FactoryMethod.ForMuscleVehicle
{
    public class CreatorBicycle : ICreatorMuscleVehicle
    {
        public MuscleVehicle Creator(string name, double startingSpeed, double maxSpeed, double maxRange)
        {
            return new Bycicle(name, startingSpeed, maxSpeed, maxRange);
        }
    }
}
