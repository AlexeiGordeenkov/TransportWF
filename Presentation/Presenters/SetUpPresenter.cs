using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SetUpPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISetUpView _view;
        private readonly ITransportService _service;
        public SetUpPresenter(IKernel kernel, ISetUpView view, ITransportService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.SetUpVehicles += SetUpVehicles;
            _view.SetUpRoad += SetUpRoad;
            _view.GoBackToTransportView += GoBackToTransportView;
        }

        private void GoBackToTransportView()
        {
            _kernel.Get<TransportPresenter>().Run();
            _view.Close();
        }

        void SetUpVehicles()
        {
            _kernel.Get<SetUpVehiclesPresenter>().Run();
            _view.Close();
        }

        void SetUpRoad()
        {
            _kernel.Get<SetUpRoadPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
