using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfacesForServices
{
    public interface IVerificationDataForMuscleVehicleService
    {
        bool VerificationDataForMuscleVehicle(string name, string maxSpeed, string startingSpeed, string maxRange, ref string message );
    }
}
