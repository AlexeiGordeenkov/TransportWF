using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    abstract public class Vehicle
    {
        //Variables
        public string Name { get; set; }
        public string PathToPictures { get; set; }
        public double MaxSpeed { get; set; }
        protected double BrakingDistances { get; set; }
        public double Acceleration { get; set; }
        public double StartSpeed { get; set; }
        public double CurentSpeed { get; set; }
        public double CurrentCoordinate { get; set; }
        public double StartCoordinate { get; set; }
        public DateTime StartTime { get; set; }
        public bool ReachedMaxSpeed { get; set; }


        //methods
        abstract public void Start();
        abstract public void Stop();
        abstract public void SaveDate();
        abstract public void Step();
        abstract public double GetMaxDistance();
        abstract public double GetAcceleratingDistance();

        protected void SetAcceleration()
        {
            double t = GetMaxDistance() > GetAcceleratingDistance() ? GetAcceleratingDistance() : GetMaxDistance();
            Acceleration = (MaxSpeed * MaxSpeed - StartSpeed * StartSpeed) /t;
        }

        public double GetTimeFromStart()
        {
            TimeSpan differensTime = (DateTime.Now).Subtract(StartTime);
            return (double)differensTime.TotalMilliseconds/3600000f;
        }

        public abstract Vehicle Clone();

        public override string ToString()
        {
            return Name;
        }
    }
}
