using Model.InterfacesForServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class CheckCorectLocationVehicleService : ICheckCorectLocationVehicleService
    {
        private bool IsPanzer(Vehicle vehicle)
        {
            if (vehicle == null)
                return false;
            if (vehicle.GetType() == typeof(Panzer))
                return true;
            return false;
        }
        private bool IsMuscleVehicle(Vehicle vehicle)
        {
            if (vehicle == null)
                return false;
            if (vehicle.GetType() == typeof( Bycicle))
                return true;
            if (vehicle.GetType() == typeof(Scooter))
                return true;
            if (vehicle.GetType() == typeof(HorseDrawnWagon))
                return true;
            return false;
        }
        public  bool CheckCorectLocationVehicle(List<Vehicle> list, ref string message)
        { 
            for(int i =1; i< list.Count-1; i++)
            {
                if (IsPanzer(list[i]))
                {
                    message = "Танк можно добавить только на крайние полосы";
                    return false;
                }
                if (IsMuscleVehicle(list[i]))
                {
                    message = "ТС приводимые в движение мышечной силой могут двигаться только по крайним полосам";
                    return false;
                }
            
            }
            return true;
        }
    }
}
