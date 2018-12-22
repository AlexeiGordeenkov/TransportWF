using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TroleyBus : ElectricVehicle
    {
        public TroleyBus(string name, double startingSpeed, double maxSpeed)
        {
            PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\TroleyBusIcon.png";
            Name = name;
            StartSpeed = startingSpeed;
            MaxSpeed = maxSpeed;
            Init();
        }
    }
}
