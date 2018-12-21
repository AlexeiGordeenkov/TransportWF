using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAddMuscleVehicleView:IView
    {
        event Action AddVehicle;
        void GetData(out string name, out string startingSpeed, out string maxSpeed, out string maxRange);
        void ShowMessage(string message);
    }
}
