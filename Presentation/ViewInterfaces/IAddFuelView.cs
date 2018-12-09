using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ViewInterfaces
{
    public interface IAddFuelView:IView
    {
        event Action AddFuel;
        event Action AddFuelViewLoad;
        string GetNameFuel();
        void ShowListFuel(List<string> ListNameFuel);
    }
}
