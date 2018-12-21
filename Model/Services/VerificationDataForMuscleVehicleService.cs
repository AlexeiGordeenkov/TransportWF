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

            return check;
        }
    }
}
