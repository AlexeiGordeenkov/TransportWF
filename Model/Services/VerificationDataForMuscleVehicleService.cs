using Model.InterfacesForServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class VerificationDataForMuscleVehicleService : IVerificationDataForMuscleVehicleService
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
        private bool ValidateMaxRange(string maxRange)
        {
            if (Double.Parse(maxRange) >= 0)
                return true;
            return false;
        }
        public bool VerificationDataForMuscleVehicle(string name, string maxSpeed, string startingSpeed, string maxRange , ref string message)
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
                if (maxRange == null || maxRange == "")
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
                Double.Parse(maxRange);
            }
            catch (FormatException exeption)
            {
                message += "Ошибка формата поля максимальное растояние" + Environment.NewLine;
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
                if (!ValidateMaxRange(maxRange))
                {
                    message += "Максимальный путь не может быть менше нуля" + Environment.NewLine;
                    check = false;
                }


            }

            return check;
        }
    }
}
