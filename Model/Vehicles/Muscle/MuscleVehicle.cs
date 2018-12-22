using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MuscleVehicle : Vehicle
    {
        protected MuscleVehicle(string name, double startingSpeed, double maxSpeed, double maxRange)
        {
            Name = name;
            StartSpeed = startingSpeed;
            MaxSpeed = maxSpeed;
            MaxRange = maxRange;
            Init();
        }
        public double MaxRange { get; set; }
        public override double GetMaxDistance()
        {
            return MaxRange;
        }
        public override double GetAcceleratingDistance()
        {
            return 1;
        }
        public override Vehicle Clone()
        {
            Bycicle copy = new Bycicle(Name, StartSpeed, MaxSpeed, MaxRange)
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
