using Model;
using Ninject;
using Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SetUpVehiclesPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISetUpVehiclesView _view;
        private readonly ITransportService _service;

        public SetUpVehiclesPresenter(IKernel kernel, ISetUpVehiclesView view, ITransportService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.AddHorseDrawnVehicle += AddHorseDrawnVehicle;
            _view.AddMuscleVehicle += AddMuscleVehicle;
            _view.AddMotorVehicle += AddMotorVehicle;
            _view.GoBackToSetUpView += GoBackToSetUpView;
            _view.AddElectricVehicle += AddElectricVehicle;
        }

        private void AddElectricVehicle()
        {
            _kernel.Get<AddElectricVehicleTypeSelectionPresenter>().Run();
            _view.Close();
        }

        private void GoBackToSetUpView()
        {
            _kernel.Get<SetUpPresenter>().Run();
            _view.Close();
        }

        private void AddMotorVehicle()
        {
            _kernel.Get<AddMotorVehicleTypeSelectionPresenter>().Run();
            _view.Close();
        }

        private void AddMuscleVehicle()
        {
         //   _view.Close();
        }

        private void AddHorseDrawnVehicle()
        {
          //  _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
