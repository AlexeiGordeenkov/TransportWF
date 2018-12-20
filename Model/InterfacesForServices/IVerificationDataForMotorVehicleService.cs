using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfacesForServices
{
    public interface IVerificationDataForMotorVehicleService
    {
        bool VerificationDataForMotorVehicle(string name, string maxSpeed, string startingSpeed, string capacityTank, string fuelConsption, ref string message);  
    }
}
