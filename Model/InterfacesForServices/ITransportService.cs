using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ITransportService
    {
        List<Vehicle> GetListOfVehicles();
        List<Vehicle> GetListOfMovingVehicles();
        void AddVehicle(Vehicle vehicle);
        void AddVehicleToMovingVehicleList(Vehicle vehicle);
        void ClearListOfMovingVehicles();
    }
}
