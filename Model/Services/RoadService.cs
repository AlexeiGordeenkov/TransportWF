using Model.InterfacesForServices;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class RoadService:IRoadService
    {
        private readonly IKernel _kernel;
        private List<Lane> listofLanes;
        
        public RoadService(IKernel kernel)
        {
            _kernel = kernel;
            listofLanes = new List<Lane>(5);
            for(int i = 0; i < 5; i++)
            {
                listofLanes.Add(new Lane());
            }
        }

        public void ClearRoad()
        {
            foreach(Lane lane in listofLanes)
            {
                lane.Clear();
            }
            _kernel.Get<ITransportService>().ClearListOfMovingVehicles();
        }

        public Vehicle GetVehicleFromLane(int index)
        {
            return listofLanes[index]?._Vehicle;
        }

        public bool IsThereRailsOnLane(int index)
        {
            return listofLanes[index].IsThereRails();
        }

        public bool IsThereWiresOnLane(int index)
        {
            return listofLanes[index].IsThereWires();
        }

        public void SetVehiceOnLane(int index, Vehicle vehicle)
        {
            listofLanes[index]._Vehicle = vehicle;
            _kernel.Get<ITransportService>().AddVehicleToMovingVehicleList(vehicle);
        }
    }
}
