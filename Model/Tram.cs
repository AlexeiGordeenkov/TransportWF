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
            Tram copy = new Tram(Name, MaxSpeed, StartSpeed)
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
