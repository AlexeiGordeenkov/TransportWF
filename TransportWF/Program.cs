using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using Model;
using Ninject;
using Presentation.Presenters;
using Presentation.ViewInterfaces;
using Model.Services;
using Model.InterfacesForServices;

namespace TransportWF
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            kernel.Bind<ISetUpView>().To<SetUpView>();
            kernel.Bind<ISetUpRoadView>().To<SetUpRoadView>();
            kernel.Bind<ISetUpVehiclesView>().To<SetUpVehiclesView>();
            kernel.Bind<ITransportView>().To<TransportView>().InSingletonScope();
            kernel.Bind<IAddFuelView>().To<AddFuelView>();

            kernel.Bind<IAddElectricVehicleView>().To<AddElectricVehicleView>();
            kernel.Bind<IAddMotorVehicleView>().To<AddMotorVehicleView>();
            kernel.Bind<IAddHorseDrawnVehicleView>().To<AddHorseDrawnVehicleView>();
            kernel.Bind<IAddMuscleVehicleView>().To<AddMuscleVehicleView>();
            kernel.Bind<IAddMotorVehicleTypeSelectionView>().To<AddMotorVehicleTypeSelectionView>();

            kernel.Bind<SetUpPresenter>().ToSelf();
            kernel.Bind<SetUpRoadPresenter>().ToSelf();
            kernel.Bind<SetUpVehiclesPresenter>().ToSelf();
            kernel.Bind<TransportPresenter>().ToSelf().InSingletonScope();

            kernel.Bind<AddElectricVehiclePresenter>().ToSelf();
            kernel.Bind<AddHorseDrawnVehiclePresenter>().ToSelf();
            kernel.Bind<AddMotorVehiclePresenter>().ToSelf();
            kernel.Bind<AddMuscleVehiclePresenter>().ToSelf();

            kernel.Bind<AddMotorVehicleTypeSelectionPresenter>().ToSelf();

            kernel.Bind<ITransportService>().To<TransportService>().InSingletonScope();
            kernel.Bind<IFuelService>().To<FuelService>().InSingletonScope();
            kernel.Bind<ISimulationService>().To<SimulationService>().InSingletonScope();
            kernel.Bind<IVerificationDataForVehicleService>().To<VerificationDataForVehicleService>().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<TransportPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
