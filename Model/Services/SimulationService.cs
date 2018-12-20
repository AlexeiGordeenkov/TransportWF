using Model.InterfacesForServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Ninject;
using System.Threading.Tasks;

namespace Model.Services
{
    public class SimulationService : ISimulationService
    {
        private readonly IKernel _kernel;

        private bool simulationInProces = false;
        private bool firstStart = true;

        private Thread simulationThread;

        private List<Vehicle> listOFVehicles = new List<Vehicle>();

        public event Action Draw;

        public SimulationService(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void StartSimulation()
        {
            if (firstStart)
            {
                listOFVehicles = _kernel.Get<ITransportService>().GetListOfVehicles();
                simulationInProces = true;
                foreach (var item in listOFVehicles)
                {
                    item.StartTime = DateTime.Now;
                }
                simulationThread = new Thread(Simulate);
                simulationThread.Start();
                firstStart = false;
            }
            else
            {
                if (!simulationInProces)
                {
                    foreach (var item in listOFVehicles)
                    {
                        item.StartTime = DateTime.Now;
                        item.StartCoordinate = item.CurrentCoordinate;
                    }
                    simulationThread.Resume();
                    simulationInProces = true;
                }
            }
        }
        private void Simulate()
        {
            while (true)
            {       
                foreach (var vehicle in listOFVehicles)
                {
                    if (vehicle.StartSpeed+vehicle.GetTimeFromStart()*vehicle.Acceleration > vehicle.MaxSpeed)
                    {

                    }
                }
                Draw?.Invoke();
                System.Threading.Thread.Sleep(100);
            }
        }

        public void StopSimulation()
        {
            if (!simulationInProces) return;
            simulationInProces = false;
            simulationThread.Suspend();
        }
    }
}
