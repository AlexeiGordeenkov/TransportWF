﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TransportService:ITransportService
    {
        List<Vehicle> listOFVehicle = new List<Vehicle>();
        public DateTime timeStarting = new DateTime();

        public void StartRuning()
        {
            timeStarting = DateTime.Now;
        }

        public int GetTimeFromStart()
        {
            TimeSpan differensTime = (DateTime.Now).Subtract(timeStarting);
            return (int)differensTime.TotalMilliseconds;
        }

        public void AddVehicle(Vehicle vehicle) => listOFVehicle.Add(vehicle);
       

    }
}
