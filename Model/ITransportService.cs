using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ITransportService
    {
        int GetSizeListOfFuel();
        Fuel GetFuelFromList(int index);
        void AddFuelInList(Fuel fuel);
        bool VerifiacationFuel(Fuel fuel);
        List<string> GetListNameFuel();

    }
}
