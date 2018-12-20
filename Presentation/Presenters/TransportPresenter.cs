using System;
using Ninject;
using Model;
using System.Threading;
using Model.InterfacesForServices;

namespace Presentation
{
    public class TransportPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ITransportView _view;
        private readonly ITransportService _transportService;
        private readonly ISimulationService _simulationService;

      
    
        public TransportPresenter(IKernel kernel, ITransportView view, ITransportService transportService, ISimulationService simulationService)
        {
            _kernel = kernel;
            _transportService = transportService;
            _simulationService = simulationService;
            _view = view;

            _view.SetUp += SetUp;
            _view.StartSimulation += StartSimulation;
            _view.StopSimulation += StopSimulation;
        }

        private void SetUp()
        {
            _kernel.Get<SetUpPresenter>().Run();
            _view.Close();
        }

        private void StartSimulation()
        {
            _kernel.Get<ISimulationService>().StartSimulation();
        }
        private void StopSimulation()
        {
            _kernel.Get<ISimulationService>().StopSimulation();
        }
       

        public void Run()
        {
            _view.Show();
        }
    }
}
