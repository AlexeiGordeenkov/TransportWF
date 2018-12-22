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

            _view.ScooterSelected += ScooterSelected;
            _view.BicycleSelected += BicycleSelected;
            _view.HorseDrawnWagonSelected += HorseDrawnWagonSelected;
            _view.GoBackToSetUpVehicleView += GoBackToSetUpVehicleView;
            _view.Home += GoHome;
        }

        private void GoHome()
        {
            _view.Close();
            _kernel.Get<TransportPresenter>().Run();
        }

        private void HorseDrawnWagonSelected()
        {
            _kernel.Get<AddMuscleVehiclePresenter>().Run(new CreatorHorseDrawnWagon());
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
