using System;
using Ninject;
using Model;

namespace Presentation
{
    public class TransportPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ITransportView _view;
        private readonly ITransportService _service;

        public TransportPresenter(IKernel kernel,ITransportView view, ITransportService service)
        {
            _kernel = kernel;
            _service = service;
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

        }

        private void StopSimulation()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
