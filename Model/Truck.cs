using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Truck : MotorVehicle
    {
        public static string TYPE = "Грузовик";
        protected Truck()
        {
            
        }


        public override void saveDate()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return TYPE;
        }
    }
}
