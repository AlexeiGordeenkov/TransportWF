using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.FactoryMethod.ForElectricVehicle;
using Model.InterfacesForServices;
using Ninject;
using Model;

namespace Presentation.Presenters
{
    public class AddElectricVehiclePresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IAddElectricVehicleView _view;
        private readonly ITransportService _transportService;
        private readonly IVerificationDataForElectricVehicle _verificatinService;
        private ICreatorElectricVehicle _creator;

        public void Run()
        {
            throw new NotImplementedException();
        }

        internal void Run(ICreatorElectricVehicle creator)
        {
            throw new NotImplementedException();
        }
    }
}
