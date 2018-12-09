using Model;
using Model.InterfacesForServices;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class AddMotorVehiclePresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IAddMotorVehicleView _view;
        private readonly ITransportService _transportService;
        private readonly IFuelService  _fuelService;

        public AddMotorVehiclePresenter(IKernel kernel, IAddMotorVehicleView view, ITransportService transportService, IFuelService fuelService)
        {
            _kernel = kernel;
            _transportService = transportService;
            _fuelService = fuelService;
            _view = view;

            
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
