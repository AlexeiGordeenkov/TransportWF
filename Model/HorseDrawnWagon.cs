﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HorseDrawnWagon : MuscleVehicle
    {
        public HorseDrawnWagon(string name, double startingSpeed, double maxSpeed, double maxRange)
        {
            // PathToPictures = Directory.GetCurrentDirectory() + "\\Resources\\TramIcon.png";
            Name = name;
            StartSpeed = startingSpeed;
            MaxSpeed = maxSpeed;
            MaxRange = maxRange;
            // SetAcceleration();
        }
        public override double GetAcceleratingDistance()
        {
            throw new NotImplementedException();
        }

        public override double GetMaxDistance()
        {
            throw new NotImplementedException();
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
    }
}