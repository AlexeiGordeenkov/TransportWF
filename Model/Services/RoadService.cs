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
        private List<Lane> listofLanes = new List<Lane>(5);
        
        public RoadService(IKernel kernel)
        {
            _kernel = kernel;
        }

        public bool IsThereRailsOnLane(int index)
        {
            return listofLanes[index].IsThereRails;
        }

        public bool IsThereWiresOnLane(int index)
        {
            return listofLanes[index].IsThereWires;
        }

        public void SetVehiceOnLane(int index, Vehicle vehicle)
        {
            listofLanes[index].Vehicle = vehicle;
            _kernel.Get<ITransportService>().AddVehicleToMovingVehicleList(vehicle);
        }
    }
}
