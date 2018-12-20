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
        protected string Name { get; set; }
        protected string PathToPictures { get; set; }
        protected double MaxSpeed { get; set; }
        protected double BrakingDistaces { get; set; }
        protected double StartSpeed { get; set; }
        protected double CurentSpeed { get; set; }
        public double CurrentCoordinate { get; set; }
        public double StartCoordinate { get; set; }
        public DateTime StartTime { get; set; }


        //methods
        abstract public void Start();
        abstract public void Stop();
        abstract public void SaveDate();
        abstract public void Step();

        public int GetTimeFromStart()
        {
            TimeSpan differensTime = (DateTime.Now).Subtract(StartTime);
            return (int)differensTime.TotalMilliseconds;
        }

    }
}
