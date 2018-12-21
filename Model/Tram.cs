using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tram : ElectricVehicle
    {
        public Tram(string name, double startingSpeed, double maxSpeed)
        {
            PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\TramIcon.png";
            this.Name = name;
            this.StartSpeed = startingSpeed;
            this.MaxSpeed = maxSpeed;
            SetAcceleration();
        }

        public override double GetAcceleratingDistance()
        {
            return 1;
        }

        public override double GetMaxDistance()
        {
            return 500f - StartCoordinate;
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
