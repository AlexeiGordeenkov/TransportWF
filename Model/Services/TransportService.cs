using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TransportService:ITransportService
    {
        List<Vehicle> listOfVehicles = new List<Vehicle>();
        List<Vehicle> listOfMovingVehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle) => listOfVehicles.Add(vehicle);

        public List<Vehicle> GetListOfVehicles()
        {
            return listOfVehicles == null ? new List<Vehicle>() : listOfVehicles;
        }

        public List<Vehicle> GetListOfMovingVehicles()
        {
            return listOfVehicles == null ? new List<Vehicle>() : listOfMovingVehicles;
        }

        public void AddVehicleToMovingVehicleList(Vehicle vehicle) => listOfMovingVehicles.Add(vehicle);

        public void ClearListOfMovingVehicles()
        {
            listOfMovingVehicles.Clear();
        }

        public bool AddVehicle(Vehicle vehicle, ref string message)
        {
            foreach(Vehicle vehicleInList in listOfVehicles)
            {
                if(vehicle.Name == vehicleInList.Name)
                {
                    message = "Имеется транспортное средство с таким именем!";
                    return false;
                }
            }
            listOfVehicles.Add(vehicle);
            return true;
        }
    }
}
