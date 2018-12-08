using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using Model;
using Ninject;
using Presentation.Presenters;

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
            kernel.Bind<ITransportView>().To<TransportView>();

            kernel.Bind<IAddElectricVehicleView>().To<AddElectricVehicleView>();
            kernel.Bind<IAddGasolineVehicleView>().To<AddGasolineVehicleView>();
            kernel.Bind<IAddGooseVehicleView>().To<AddGooseVehicleView>();
            kernel.Bind<IAddMuscleVehicleView>().To<AddMuscleVehicleView>();

            kernel.Bind<SetUpPresenter>().ToSelf();
            kernel.Bind<SetUpRoadPresenter>().ToSelf();
            kernel.Bind<SetUpVehiclesPresenter>().ToSelf();
            kernel.Bind<TransportPresenter>().ToSelf();

            kernel.Bind<AddElectricVehiclePresenter>().ToSelf();
            kernel.Bind<AddGooseVehiclePresenter>().ToSelf();
            kernel.Bind<AddGasolineVehiclePresenter>().ToSelf();
            kernel.Bind<AddMuscleVehiclePresenter>().ToSelf();

            kernel.Bind<ITransportService>().To<TransportService>().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<TransportPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
