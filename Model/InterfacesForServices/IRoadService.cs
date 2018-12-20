using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfacesForServices
{
    public interface IRoadService
    {
        bool IsThereRailsOnLane(int index);
        bool IsThereWiresOnLane(int index);
        void SetVehiceOnLane(int index,Vehicle vehicle);
        Vehicle GetVehicleFromLane(int index);
    }
}
