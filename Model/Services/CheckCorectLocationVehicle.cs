using Model.InterfacesForServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class CheckCorectLocationVehicle : ICheckCorectLocationVehicle
    {
       /* bool IsPanzer(Vehicle vehicle)
        {

        }
        bool IsMuscleVehicle(Vehicle vehicle)
        {

        }*/
        bool ICheckCorectLocationVehicle.CheckCorectLocationVehicle(List<Vehicle> list, ref string message)
        {
            return true;
        }
    }
}
