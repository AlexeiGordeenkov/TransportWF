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
        protected string name { get; set; }
        protected string pathToPictures { get; set; }
        protected double maxSpeed { get; set; }
        protected double brakingDistaces { get; set; }
        protected double startSpeed { get; set; }
        protected double curentSpeed { get; set; }
        protected double coordinate { get; set; }

        //methods
        abstract public void Start();
        abstract public void Stop();
        abstract public void SaveDate();
        abstract public void Step();
    }
}
