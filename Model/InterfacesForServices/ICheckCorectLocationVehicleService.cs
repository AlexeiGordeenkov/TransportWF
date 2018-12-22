using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfacesForServices
{
    public interface ICheckCorectLocationVehicleService
    {
        bool CheckCorectLocationVehicle(List<Vehicle> list, ref string message);
    }
}
