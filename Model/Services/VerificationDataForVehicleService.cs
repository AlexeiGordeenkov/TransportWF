using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.InterfacesForServices;

namespace Model.Services
{
    public class VerificationDataForVehicleService : IVerificationDataForVehicleService
    {
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
            return check;
        }
        
            
            
         
    }
}
