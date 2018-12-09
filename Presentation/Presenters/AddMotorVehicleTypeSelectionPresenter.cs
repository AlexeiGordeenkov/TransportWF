using Model;
using Ninject;
using Presentation.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class AddMotorVehicleTypeSelectionPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IAddMotorVehicleTypeSelectionView _view;
        private readonly ITransportService _service;

        public AddMotorVehicleTypeSelectionPresenter(IKernel kernel, IAddMotorVehicleTypeSelectionView view, ITransportService service)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            _view.CarTypeSelected += CarTypeSelected;
            _view.TrukTypeSelected += TrukTypeSelected;
            _view.PanzerTypeSelected += PanzerTypeSelected;
        }

        private void PanzerTypeSelected()
        {
            _kernel.Get<AddMotorVehiclePresenter>().Run();
            _view.Close();
        }

        private void TrukTypeSelected()
        {
            _kernel.Get<AddMotorVehiclePresenter>().Run();
            _view.Close();
        }

        private void CarTypeSelected()
        {
            _kernel.Get<AddMotorVehiclePresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
