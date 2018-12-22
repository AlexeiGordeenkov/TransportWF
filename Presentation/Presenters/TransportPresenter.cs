using System;
using Ninject;
using Model;
using System.Threading;
using Model.InterfacesForServices;
using System.Collections.Generic;

namespace Presentation
{
    public class TransportPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ITransportView _view;
        private readonly ITransportService _transportService;
        private readonly ISimulationService _simulationService;

        private int currentKilometr;
        private List<int> YCoordinatesOfLanes { get; set; }
        private bool draw = false;
    
        public TransportPresenter(IKernel kernel, ITransportView view, ITransportService transportService, ISimulationService simulationService)
        {
            _kernel = kernel;
            _transportService = transportService;
            _simulationService = simulationService;
            _view = view;
            currentKilometr = 1;

            _view.SetUp += SetUp;
            _view.StartSimulation += StartSimulation;
            _view.StopSimulation += StopSimulation;
            _view.Scroll += Scroll;
            _view.TrackBarScroll += TrackBarScroll;
            _view.ViewLoad += ViewLoad;
            _view.Tick += Draw;
            _simulationService.Draw += SetDraw;
        }

        private void TrackBarScroll()
        {
            _kernel.Get<ISimulationService>().SetTimeKoef(_view.GetTimeKoef());
        }

        private void SetDraw()
        {
            draw = true;
        }

        private void ViewLoad()
        {
            YCoordinatesOfLanes = _kernel.Get<ITransportView>().GetYCoordinatesOfLanes();
            for (int i = 0; i < 5; i++)
            {
                var vehicle = _kernel.Get<IRoadService>().GetVehicleFromLane(i);
                if (vehicle != null)
                {                
                        int x = (int)((double)currentKilometr - vehicle.CurrentCoordinate) * _view.GetWidth();
                        _view.DrawCar(i,vehicle.PathToPictures, x, YCoordinatesOfLanes[i]);                   
                }
                else
                {
                    _view.DrawCar(i,null, 0, 0);
                }
                if (_kernel.Get<IRoadService>().IsThereRailsOnLane(i))
                {
                    _view.PutRailsOnLane(i);
                }
                else
                {
                    _view.HideRailsFromLane(i);
                }
                if (_kernel.Get<IRoadService>().IsThereWiresOnLane(i))
                {
                    _view.PutWiresOnLane(i);
                }
                else
                {
                    _view.HideWiresFromLane(i);
                }
            }        
        }

        private void Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            currentKilometr = e.NewValue;
            SetDraw();
        }

        private void SetUp()
        {
            _kernel.Get<SetUpPresenter>().Run();
            Close();
            
        }

        private void StartSimulation()
        {
            _kernel.Get<ISimulationService>().StartSimulation();
        }
        private void StopSimulation()
        {
            _kernel.Get<ISimulationService>().StopSimulation();
        }

        private void Draw()//Рисует наше перемещение машин.
        {
            if (!draw) return;
            for (int i = 0; i< 5; i++)
            {
                var vehicle = _kernel.Get<IRoadService>().GetVehicleFromLane(i);
                if (vehicle != null)
                {
                    _view.MoveCarPointer(i, (int)vehicle.CurrentCoordinate);
                    if ((vehicle.CurrentCoordinate< currentKilometr) && (vehicle.CurrentCoordinate >= currentKilometr - 1))//Если машина находится в отображаемом километре
                    {
                        int x = (int)((1f - (double)currentKilometr + vehicle.CurrentCoordinate) * (double)_view.GetWidth());
                        _view.MoveCar(i, x, YCoordinatesOfLanes[i]);                     
                    }
                    else
                    {
                        _view.HideCar(i);
                    }
                }
            }
            draw = false;
        }

        private void Close()
        {
            StopSimulation();
            _view.Close();
        }
        public void Run()
        {
            ViewLoad();
            _view.Show();
        }
    }
}
