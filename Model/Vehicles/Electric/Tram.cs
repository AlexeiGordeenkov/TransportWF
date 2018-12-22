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
        public Tram(string name, double startingSpeed, double maxSpeed) : base(name, startingSpeed, maxSpeed)
        {
            PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\TramIcon.png";           
        }
    }
}
