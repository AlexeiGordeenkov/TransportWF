using Model;
using Ninject;
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

            _view.AddHorseDrawnVehicle += AddGooseVehicle;
            _view.AddMuscleVehicle += AddMuscleVehicle;
            _view.AddGasolineVehicle += AddVehicle;
            _view.GoBackToSetUpView += GoBackToSetUpView;
        }

        private void GoBackToSetUpView()
        {
            _kernel.Get<SetUpPresenter>().Run();
            _view.Close();
        }

        private void AddVehicle()
        {
            _view.Close();
        }

        private void AddMuscleVehicle()
        {
            _view.Close();
        }

        private void AddGooseVehicle()
        {
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
