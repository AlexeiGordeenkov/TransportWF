﻿using System;
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
    }
}
