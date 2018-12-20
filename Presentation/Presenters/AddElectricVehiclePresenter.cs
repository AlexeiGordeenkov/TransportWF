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
        private readonly IVerificationDataForElectricVehicleService _verificatinService;
        private ICreatorElectricVehicle _creator;

        public AddElectricVehiclePresenter(IKernel kernel, IAddElectricVehicleView view, ITransportService transportService, IVerificationDataForElectricVehicleService vrifiactionService)
        {
            _kernel = kernel;
            _transportService = transportService;
            _verificatinService = vrifiactionService;
            _view = view;

            _view.AddVehicle += AddVehicle;
        }

       

        private void AddVehicle()
        {
            string name;
            string maxSpeed;
            string startSpeed;
            string message = "";
            _view.GetData(out name, out maxSpeed, out startSpeed);
            if (_verificatinService.VerificationDataForElectricVehicle(name, maxSpeed, startSpeed, ref message))
            {
                ElectricVehicle motorVehicle = _creator.Creator(name, Double.Parse(maxSpeed), Double.Parse(startSpeed));
                Vehicle vehicle = motorVehicle;
                _transportService.AddVehicle(vehicle);
            }
            else
            {
                _view.ShowMessage(message);
            }

        }


        public void Run()
        {
            throw new NotImplementedException();
        }

        internal void Run(ICreatorElectricVehicle creator)
        {
            this._creator = creator;
            _view.Show();
        }
    }
}
