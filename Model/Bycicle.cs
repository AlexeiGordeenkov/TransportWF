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
        public Bycicle(string name, double startingSpeed, double maxSpeed, double maxRange)
        {
            PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\BicycleIcon.png";
            Name = name;
            StartSpeed = startingSpeed;
            MaxSpeed = maxSpeed;
            MaxRange = maxRange;
            Init();
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
        public override Vehicle Clone()
        {
            Bycicle copy = new Bycicle(Name,  StartSpeed, MaxSpeed, MaxRange)
            {
                CurrentCoordinate = CurrentCoordinate,
                BrakingDistances = BrakingDistances,
                CurentSpeed = CurentSpeed,
                Acceleration = Acceleration,
                StartCoordinate = StartCoordinate,
                StartTime = StartTime,
                ReachedMaxSpeed = ReachedMaxSpeed
            };
            return copy;
        }
    }
}
