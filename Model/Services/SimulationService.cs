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

        private double divider = 3600000.0;
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
        private void Simulate()//Работает в новом потоке и считает координаты машин
        {
            while (true)
            {       
                foreach (var vehicle in listOFVehicles)
                {
                    if (!vehicle.ReachedMaxSpeed)
                    {
                        if (vehicle.StartSpeed + vehicle.GetTimeFromStart() * vehicle.Acceleration > vehicle.MaxSpeed)
                        {
                            vehicle.ReachedMaxSpeed = true;
                            vehicle.StartCoordinate = vehicle.CurrentCoordinate;
                            vehicle.StartTime = DateTime.Now;
                        }
                    }
                    double t = ((double)vehicle.GetTimeFromStart()) / divider;
                    if (vehicle.ReachedMaxSpeed)
                    {
                        vehicle.CurrentCoordinate = vehicle.StartCoordinate + vehicle.MaxSpeed * t + (vehicle.Acceleration/2)*t*t;
                    }
                    else
                    {
                        
                        vehicle.CurrentCoordinate = vehicle.StartCoordinate + vehicle.StartSpeed *t;
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
            foreach (var vehicle in listOFVehicles)
            {
                vehicle.StartSpeed = 0;
                vehicle.StartCoordinate = vehicle.CurrentCoordinate;
                vehicle.ReachedMaxSpeed = false;
            }
        }
    }
}
