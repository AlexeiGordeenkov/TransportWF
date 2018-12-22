using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TroleyBus : ElectricVehicle
    {
        public TroleyBus(string name, double startingSpeed, double maxSpeed)
        {
            Name = name;
            StartSpeed = startingSpeed;
            MaxSpeed = maxSpeed;
            SetAcceleration();
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
            TroleyBus copy = new TroleyBus(Name, StartSpeed, MaxSpeed)
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
