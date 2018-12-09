using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TransportService:ITransportService
    {
        //Variables//
        private List<Fuel> listOfFuel = new List<Fuel>();


        //Methods//
        public int GetSizeListOfFuel() => listOfFuel.Count;

        public Fuel GetFuelFromList(int index) => listOfFuel[index];

        public List<string> GetListNameFuel()
        {
            List<string> listNameFuel = new List<string>();
            foreach (Fuel fuel in listOfFuel)
                listNameFuel.Add(fuel.GetName());
            return listNameFuel;
        }

        public void AddFuelInList(Fuel fuel) =>   listOfFuel.Add(fuel);

        public bool VerifiacationFuel(Fuel fuel)// метод возвращает true в случае отсутствия еще такого топлива в списке
        {  
            foreach (Fuel iteratorFuel in listOfFuel)
                if (fuel.GetName() == iteratorFuel.GetName())
                    return false;
            return true;
        }

    }
}
