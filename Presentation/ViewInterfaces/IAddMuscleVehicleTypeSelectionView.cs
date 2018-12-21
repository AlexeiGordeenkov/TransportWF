using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ViewInterfaces
{
    public interface IAddMuscleVehicleTypeSelectionView : IView
    {
        event Action BicycleSelected;
        event Action ScooterSelected;
        event Action GoBackToSetUpVehicleView;
    }
}
