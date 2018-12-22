using System;
using System.Collections;
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
        public double StopPoint { get; set; }
        public double Acceleration { get; set; }
        public double StartSpeed { get; set; }
        public double CurentSpeed { get; set; }
        public double CurrentCoordinate { get; set; }
        public double StartCoordinate { get; set; }
        public DateTime StartTime { get; set; }
        public bool ReachedMaxSpeed { get; set; }
        public List<ArrayList> log;
        public double LastLogCoordinate { get; set; }
        public bool Finished { get; set; }

        //methods
        abstract public double GetMaxDistance();
        abstract public double GetAcceleratingDistance();

        protected void Init()
        {
            SetStopPoint();
            SetAcceleration();
            Finished = false;
        }
        protected void SetStopPoint()
        {
            StopPoint = StartCoordinate + GetMaxDistance();
        }
        protected void SetAcceleration()
        {
            double t = GetMaxDistance() > GetAcceleratingDistance() ? GetAcceleratingDistance() : GetMaxDistance();
            Acceleration = (MaxSpeed * MaxSpeed - StartSpeed * StartSpeed) /t;
        }
        public void ResetAcceleration()
        {
            SetAcceleration();
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
