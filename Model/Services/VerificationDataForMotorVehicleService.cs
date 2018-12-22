using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.InterfacesForServices;

namespace Model.Services
{
    public class VerificationDataForMotorVehicleService : IVerificationDataForMotorVehicleService
    {
        private bool ValidationMaxSpeed(string speed)
        {
            if (Double.Parse(speed) > 0)
                return true;
            return false;
        }

        private bool ValidationStartSpeedAndMaxSped(string startSpeed, string maxSpeed)
        {
            if (Double.Parse(startSpeed) <= Double.Parse(maxSpeed))
                return true;
            return false;
        }
        private bool ValidationStartSpeed(string speed)
        {
            if (Double.Parse(speed) >= 0)
                return true;
            return false;
        }
        private bool ValidatonCapacityTank(string capacity)
        {
            if (Double.Parse(capacity) > 0)
                return true;
            return false;
        }
        private bool ValidatonFuelConsption(string consption)
        {
            if (Double.Parse(consption) > 0)
                return true;
            return false;
        }
        public bool VerificationDataForMotorVehicle(string name, string maxSpeed, string startingSpeed, string capacityTank, string fuelConsption, ref string message)
        {
            bool check = true;
            try
            {
                if (name == null || name == "")
                    check = false;
                if (maxSpeed == null || maxSpeed == "")
                    check = false;
                if (startingSpeed == null || startingSpeed == "")
                    check = false;
                if (capacityTank == null || capacityTank == "")
                    check = false;
                if (fuelConsption == null || fuelConsption == "")
                    check = false;
                if (check == false)
                    throw new NullReferenceException();
            }
            catch (NullReferenceException ex)
            {
                message = "Заполните все поля";
                return check;
            }

            try
            {
                Double.Parse(maxSpeed);
            }
            catch (FormatException exeption)
            {
                message = "Ошибка формата поля максимльная скорость" + Environment.NewLine;
                check = false;
            }

            try
            {
                Double.Parse(startingSpeed);
            }
            catch (FormatException exeption)
            {
                message += "Ошибка формата поля начальная скорость" + Environment.NewLine;
                check = false;
            }

            try
            {
                Double.Parse(capacityTank);
            }
            catch (FormatException exeption)
            {
                message += "Ошибка формата поля емкость бака" + Environment.NewLine;
                check = false;
            }

            try
            {
                Double.Parse(fuelConsption);
            }
            catch (FormatException exeption)
            {
                message += "Ошибка формата поля расход топлива" + Environment.NewLine;
                check = false;
            }
            if (check)
            {
                if (!ValidationMaxSpeed(maxSpeed))
                {
                    message = "Максимальная скорость дожна быть больше 0";
                    check = false;
                }
                if (!ValidationStartSpeed(startingSpeed))
                {
                    message += "Начальная скорость не может быть отрицательной величиной" + Environment.NewLine;
                    check = false;
                }
                if (!ValidationStartSpeedAndMaxSped(startingSpeed, maxSpeed))
                {
                    message += "Начальная скорость не может быть больше максимаьной" + Environment.NewLine;
                    check = false;
                }
                if (!ValidatonCapacityTank(capacityTank))
                {
                    message += "Ёмкость бака не может быть меньше 0" + Environment.NewLine;
                    check = false;
                }
                if (!ValidatonFuelConsption(fuelConsption))
                {
                    message += "Расход топлива не отрицательная величина" + Environment.NewLine;
                    check = false;
                }

            }
            return check;
        }
        
            
            
         
    }
}
