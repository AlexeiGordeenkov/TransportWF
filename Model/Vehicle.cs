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
        protected string pathToPictures;
        protected double MaxSpedd;
        protected double brakingDistaces;
        protected double startSpeed;
        protected double curentSpeed;
        protected double coordinate;

        //methods
        abstract public void Start();
        abstract public void Stop();
        abstract public void SaveDate();
        abstract public void Step();
    }
}
