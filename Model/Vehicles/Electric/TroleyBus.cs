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
        public TroleyBus(string name, double startingSpeed, double maxSpeed) : base(name, startingSpeed, maxSpeed)
        {
            PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\TroleyBus.png";
        }
        public override Vehicle Clone()
        {
            TroleyBus copy = new TroleyBus(Name, StartSpeed, MaxSpeed)
            {
                CurrentCoordinate = CurrentCoordinate,
                MaxSpeed = MaxSpeed,
                StartSpeed = StartSpeed,
                Acceleration = Acceleration,
                StartCoordinate = StartCoordinate,
                StartTime = StartTime,
                ReachedMaxSpeed = ReachedMaxSpeed
            };
            return copy;
        }
    }
}
