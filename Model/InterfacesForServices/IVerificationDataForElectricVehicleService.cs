using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfacesForServices
{
    public interface IVerificationDataForElectricVehicleService
    {
        bool VerificationDataForElectricVehicle(string name, string maxSpeed, string startingSpeed, ref string message);
    }
}
