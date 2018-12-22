using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bycicle : MuscleVehicle
    {
        public Bycicle(string name, double startingSpeed, double maxSpeed, double maxRange) : base(name, startingSpeed, maxSpeed, maxRange)
        {
            PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\BicycleIcon.png";
        }
        public override Vehicle Clone()
        {
            Bycicle copy = new Bycicle(Name, StartSpeed, MaxSpeed, MaxRange)
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
