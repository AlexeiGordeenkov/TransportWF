using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ElectricVehicle : Vehicle
    {
        protected ElectricVehicle(string name, double startingSpeed, double maxSpeed)
        {
            this.Name = name;
            this.StartSpeed = startingSpeed;
            this.MaxSpeed = maxSpeed;
            Init();
        }
        public override double GetAcceleratingDistance()
        {
            return 1;
        }

        public override double GetMaxDistance()
        {
            return 500f - StartCoordinate;
        }
        public override Vehicle Clone()
        {
            TroleyBus copy = new TroleyBus(Name, StartSpeed, MaxSpeed)
            {
                CurrentCoordinate = CurrentCoordinate,
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
