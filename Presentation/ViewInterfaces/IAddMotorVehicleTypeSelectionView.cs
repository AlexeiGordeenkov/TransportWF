using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ViewInterfaces
{
    public interface IAddMotorVehicleTypeSelectionView:IView
    {
        event Action CarTypeSelected;
        event Action TrukTypeSelected;
        event Action PanzerTypeSelected;
    }
}
