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
        public override Vehicle Clone()
        {
            Tram copy = new Tram(Name, StartSpeed, MaxSpeed)
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
