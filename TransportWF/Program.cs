using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;
using Model;
using Ninject;


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
            kernel.Bind<SetUpPresenter>().ToSelf();
            kernel.Bind<SetUpRoadPresenter>().ToSelf();
            kernel.Bind<SetUpVehiclesPresenter>().ToSelf();
            kernel.Bind<TransportPresenter>().ToSelf();
            kernel.Bind<ITransportService>().To<TransportService>().InSingletonScope();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<TransportPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
