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
        public Scooter(string name, double startingSpeed, double maxSpeed, double maxRange)
        {
            PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\Scooter.png";
            Name = name;
            StartSpeed = startingSpeed;
            MaxSpeed = maxSpeed;
            MaxRange = maxRange;
            Init();
        }
    }
}
