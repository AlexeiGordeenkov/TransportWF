using Model;
using Model.InterfacesForServices;
using Ninject;
using Presentation.FactoryMethod.ForMuscleVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class AddMuscleVehiclePresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IAddMuscleVehicleView _view;
        private readonly ITransportService _transportService;
        private readonly IVerificationDataForMuscleVehicleService _verificatinService;
        private ICreatorMuscleVehicle _creator;

        public AddMuscleVehiclePresenter(IKernel kernel, IAddMuscleVehicleView view, ITransportService transportService, IVerificationDataForMuscleVehicleService vrifiactionService)
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
            string maxRange;
            string message = "";
            _view.GetData(out name, out startSpeed, out maxSpeed, out maxRange);
            if (_verificatinService.VerificationDataForMuscleVehicle(name, maxSpeed, startSpeed, maxRange, ref message))
            {
                MuscleVehicle motorVehicle = _creator.Creator(name, Double.Parse(startSpeed), Double.Parse(maxSpeed), Double.Parse(maxRange));
                Vehicle vehicle = motorVehicle;
                if (!_transportService.AddVehicle(vehicle, ref message))
                {
                    _view.ShowMessage(message);
                }
                else
                    _view.Close();
            }
            else
            {
                _view.ShowMessage(message);
            }
            
        }
        public void Run(ICreatorMuscleVehicle creator)
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
