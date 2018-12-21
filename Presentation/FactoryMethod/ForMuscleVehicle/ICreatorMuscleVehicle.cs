using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.FactoryMethod.ForMuscleVehicle
{
    public interface ICreatorMuscleVehicle
    {
        MuscleVehicle Creator(string name, double startingSpeed, double maxSpeed, double maxRange);
    }
}
