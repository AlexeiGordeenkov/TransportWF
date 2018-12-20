using Model;
using Model.InterfacesForServices;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SetUpRoadPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISetUpRoadView _view;
        private readonly ITransportService _service;
        public SetUpRoadPresenter(IKernel kernel, ISetUpRoadView view, ITransportService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.Apply += Apply;
            _view.SetUpRoadLoad += SetUpRoadLoad;
        }

        private void SetUpRoadLoad()
        {
            List<string> nameVehicle = new List<string>();
            foreach(Vehicle vehicle in  _service.GetListOfVehicles())
            {
                nameVehicle.Add(vehicle.Name);
            }
            _view.LoadDataForSetUpRoadView(_service.GetListOfVehicles());
        }

        private void Apply()
        {
            _kernel.Get<IRoadService>().ClearRoad();
            List<int> listIndex = _view.GetListOfIndexes();
            for (int i = 0; i < listIndex.Count; i++)
            {

                if(listIndex[i] >= 0)
                {
                    _kernel.Get<IRoadService>().SetVehiceOnLane(i, ( _service.GetListOfVehicles())[ listIndex[i] ] );// добавление на i полосу ListIndex[i] того ТС
                }
            }
            _kernel.Get<TransportPresenter>().Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
