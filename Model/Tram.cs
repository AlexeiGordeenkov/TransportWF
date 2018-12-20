using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tram : ElectricVehicle
    {
        public Tram(string name, double startingSpeed, double maxSpeed)
        {
            this.Name = name;
            this.StartSpeed = startingSpeed;
            this.MaxSpeed = maxSpeed;
        }

        public override void SaveDate()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Step()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
