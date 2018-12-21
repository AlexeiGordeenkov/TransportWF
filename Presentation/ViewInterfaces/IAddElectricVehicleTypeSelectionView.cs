using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ViewInterfaces
{
    public interface IAddElectricVehicleTypeSelectionView : IView
    {
        event Action TramTypeSelected;
        event Action TroleyBusTypeSelected;
        event Action GoBackToSetUpVehicleView;
        event Action Home;
    }
}
