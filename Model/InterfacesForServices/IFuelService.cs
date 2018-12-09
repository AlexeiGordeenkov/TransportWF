using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfacesForServices
{
    public interface IFuelService
    {
        int GetSizeListOfFuel();
        Fuel GetFuelFromList(int index);
        void AddFuelInList(Fuel fuel);
        bool VerifiacationFuel(Fuel fuel);
        List<string> GetListNameFuel();
    }
}
