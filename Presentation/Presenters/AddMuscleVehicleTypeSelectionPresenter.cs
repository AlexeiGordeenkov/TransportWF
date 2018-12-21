using Model;
using Ninject;
using Presentation.FactoryMethod.ForMuscleVehicle;
using Presentation.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class AddMuscleVehicleTypeSelectionPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IAddMuscleVehicleTypeSelectionView _view;
        private readonly ITransportService _service;


        public AddMuscleVehicleTypeSelectionPresenter(IKernel kernel, IAddMuscleVehicleTypeSelectionView view, ITransportService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            view.ScooterSelected += ScooterSelected;
            view.BicycleSelected += BicycleSelected;
            view.GoBackToSetUpVehicleView += GoBackToSetUpVehicleView;
        }

        private void BicycleSelected()
        {
            _kernel.Get<AddMuscleVehiclePresenter>().Run(new CreatorBicycle());
        }

        private void ScooterSelected()
        {
            _kernel.Get<AddMuscleVehiclePresenter>().Run(new CreatorScooter());
        }

        private void GoBackToSetUpVehicleView()
        {
            _kernel.Get<SetUpVehiclesPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
