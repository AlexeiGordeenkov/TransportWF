using Model.InterfacesForServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Ninject;
using System.Threading.Tasks;
using System.Collections;

namespace Model.Services
{
    public class SimulationService : ISimulationService
    {
        private readonly IKernel _kernel;

        private bool simulationInProces = false;
        private bool firstStart = true;
        public int timeKoef=1;

        private Thread simulationThread;

        private List<Vehicle> listOFMovingVehicles = new List<Vehicle>();

        public event Action Draw;

        public SimulationService(IKernel kernel)
        {
            _kernel = kernel;
        }

        private void CreateLog(Vehicle vehicle, string mess)
        {
            var t = new ArrayList();
            t.Add(DateTime.Now);
            t.Add(vehicle.CurrentCoordinate);
            t.Add(vehicle.CurentSpeed);
            t.Add(mess);
            vehicle.log.Add(t);//Записываем первый лог
            vehicle.LastLogCoordinate = vehicle.CurrentCoordinate;
        }

        public void StartSimulation()
        {
            if (firstStart)
            {
                listOFMovingVehicles = _kernel.Get<ITransportService>().GetListOfMovingVehicles();
                simulationInProces = true;
                foreach (var item in listOFMovingVehicles)
                {
                    item.StartTime = DateTime.Now;
                    item.log = new List<ArrayList>();
                    CreateLog(item, "FirstStart");
                }
                simulationThread = new Thread(Simulate);
                simulationThread.Start();
                firstStart = false;
            }
            else
            {
                if (!simulationInProces)
                {
                    foreach (var item in listOFMovingVehicles)
                    {
                        item.StartTime = DateTime.Now;
                        item.StartCoordinate = item.CurrentCoordinate;
                        CreateLog(item, "Resume");
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
                foreach (var vehicle in listOFMovingVehicles)
                {
                    if (vehicle.CurrentCoordinate - vehicle.LastLogCoordinate >= 50)
                    {
                        CreateLog(vehicle, "50 километров проехал");
                    }
                    if (vehicle.CurrentCoordinate < vehicle.StopPoint)
                    {
                        if (!vehicle.ReachedMaxSpeed)
                        {
                            if (vehicle.StartSpeed + vehicle.GetTimeFromStart() * timeKoef * vehicle.Acceleration > vehicle.MaxSpeed)
                            {
                                vehicle.ReachedMaxSpeed = true;
                                vehicle.StartCoordinate = vehicle.CurrentCoordinate;
                                vehicle.StartTime = DateTime.Now;
                                vehicle.StartSpeed = vehicle.MaxSpeed;
                                vehicle.CurentSpeed = vehicle.MaxSpeed;
                            }
                        }
                        double t = ((double)vehicle.GetTimeFromStart()) * timeKoef;
                        if (!vehicle.ReachedMaxSpeed)
                        {
                            vehicle.CurrentCoordinate = vehicle.StartCoordinate + vehicle.StartSpeed * t + (vehicle.Acceleration / 2) * t * t;
                            vehicle.CurentSpeed = vehicle.Acceleration * t + vehicle.StartSpeed; ;
                        }
                        else
                        {
                            vehicle.CurrentCoordinate = vehicle.StartCoordinate + vehicle.StartSpeed * t;
                        }
                    }
                    else
                    {
                        if (!vehicle.Finished)

                        {
                            CreateLog(vehicle, "Finish");
                            vehicle.Finished = true;
                        }
                    }
                }
                Draw?.Invoke();
            }
        }

        public void StopSimulation()
        {
            if (!simulationInProces) return;
            simulationInProces = false;
            simulationThread.Suspend();
            foreach (var vehicle in listOFMovingVehicles)
            {
                vehicle.StartSpeed = 0;
                vehicle.CurentSpeed = 0;
                vehicle.StartCoordinate = vehicle.CurrentCoordinate;
                vehicle.ReachedMaxSpeed = false;
                vehicle.ResetAcceleration();
                CreateLog(vehicle, "StopAll");
            }
        }

        public void SetFirstStart()
        {
            firstStart = true;
        }

        public void SetTimeKoef(int _timeKoef)
        {
            simulationThread.Suspend();
            foreach (var vehicle in listOFMovingVehicles)
            {
                vehicle.StartCoordinate = vehicle.CurrentCoordinate;
                vehicle.StartSpeed = vehicle.CurentSpeed;
                vehicle.StartTime = DateTime.Now;
            }
            timeKoef = _timeKoef;
            simulationThread.Resume();
        }
    }
}
