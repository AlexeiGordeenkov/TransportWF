using Model;
using Model.InterfacesForServices;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.FactoryMethod;

namespace Presentation.Presenters
{
    public class AddMotorVehiclePresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IAddMotorVehicleView _view;
        private readonly ITransportService _transportService;
        private readonly IFuelService  _fuelService;
        private readonly IVerificationDataForMotorVehicleService _verificatinService;
        private ICreatorMotorVehicle _creator;


        public AddMotorVehiclePresenter(IKernel kernel, IAddMotorVehicleView view, ITransportService transportService, IFuelService fuelService, IVerificationDataForMotorVehicleService vrifiactionService)
        {
            _kernel = kernel;
            _transportService = transportService;
            _fuelService = fuelService;
            _verificatinService = vrifiactionService;
            _view = view;

            _view.AddVehicle += AddVehicle;
            _view.AddMotorVehicleViewLoad += AddMotorVehicleViewLoad;
        }

        private void AddMotorVehicleViewLoad()
        {
            _view.ShowListFuel(_fuelService.GetListNameFuel());
        }

        private void AddVehicle()
        {
            string name;
            string index;
            string maxSpeed;
            string startSpeed;
            string tankCapacity;
            string fuelConsumption;
            string message = "";
            _view.GetData(out name, out index, out maxSpeed, out startSpeed, out tankCapacity, out fuelConsumption);
            if(_verificatinService.VerificationDataForMotorVehicle(name, maxSpeed, startSpeed, tankCapacity, fuelConsumption, ref message))
            {
                Fuel fuel = _fuelService.GetFuelFromList(Int32.Parse(index));
                MotorVehicle motorVehicle = _creator.Creator(name, fuel, Double.Parse(maxSpeed), Double.Parse(startSpeed), Double.Parse(tankCapacity), Double.Parse(fuelConsumption));
                Vehicle vehicle = motorVehicle;
                _transportService.AddVehicle(vehicle);
            }
            else
            {
                _view.ShowMessage(message);
            }
  
        }
        

        public void Run(ICreatorMotorVehicle creator)
        {
            _creator = creator;
            _view.Show();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
