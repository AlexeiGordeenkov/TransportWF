using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Scooter : MuscleVehicle
    {
        public Scooter(string name, double startingSpeed, double maxSpeed, double maxRange):base(name,startingSpeed,maxSpeed,maxRange)
        {
            PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\Scooter.png";
        }
        public override Vehicle Clone()
        {
            Scooter copy = new Scooter(Name, StartSpeed, MaxSpeed, MaxRange)
            {
                StartSpeed = StartSpeed,
                MaxSpeed = MaxSpeed,
                Acceleration = Acceleration,
                MaxRange = MaxRange,
                StartCoordinate = StartCoordinate,
                StartTime = StartTime,
                ReachedMaxSpeed = ReachedMaxSpeed
            };
            return copy;
        }
    }
}
