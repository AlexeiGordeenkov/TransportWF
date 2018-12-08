using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ISetUpVehiclesView : IView
    {
        event Action GoBackToSetUpView;
        event Action AddGooseVehicle;
        event Action AddMuscleVehicle;
        event Action AddGasolineVehicle;
        event Action AddElectricVehicle;
    }
}
