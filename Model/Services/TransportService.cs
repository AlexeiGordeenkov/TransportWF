using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TransportService:ITransportService
    {
        List<Vehicle> listOFVehicles = new List<Vehicle>();
        

        public void AddVehicle(Vehicle vehicle) => listOFVehicles.Add(vehicle);

        public List<Vehicle> GetListOfVehicles()
        {
            return listOFVehicles == null ? new List<Vehicle>() : listOFVehicles;
        }
    }
}
