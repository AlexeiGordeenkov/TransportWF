using Model;
using Ninject;
using Presentation.FactoryMethod.ForElectricVehicle;
using Presentation.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class AddElectricVehicleTypeSelectionPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IAddElectricVehicleTypeSelectionView _view;
        private readonly ITransportService _service;


        public AddElectricVehicleTypeSelectionPresenter(IKernel kernel, IAddElectricVehicleTypeSelectionView view, ITransportService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            view.TramTypeSelected += TramTypeSelected;
            view.TroleyBusTypeSelected += TroleyBusTypeSelected;
        }

        private void TroleyBusTypeSelected()
        {
            _kernel.Get<AddElectricVehiclePresenter>().Run(new CreatorTroleyBus());
            
        }

        private void TramTypeSelected()
        {
            _kernel.Get<AddElectricVehiclePresenter>().Run(new CreatorTroleyBus());
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
