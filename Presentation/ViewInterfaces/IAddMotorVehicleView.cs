using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IAddMotorVehicleView:IView
    {
        event Action AddVehicle;
        event Action AddMotorVehicleViewLoad;
        void ShowListFuel(List<string> ListNameFuel);
        void GetData(out string name, out string IndexFuel, out string maxSpeed, out string startingSpeed, out string capacityTank, out string fuelConsption  );
        void ShowMessage(string message);
    }
}
