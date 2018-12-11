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
            try
            {
                if (name == null && name == "")
                {
                    message = " Введите имя ";
                    return false;
                }
                try
                {
                    Double.Parse(maxSpeed);
                }
                catch (FormatException exeption)
                {
                    message = "Ошибка формата поля максимльная скорость";
                    return false;
                }

                try
                {
                    Double.Parse(startingSpeed);
                }
                catch (FormatException exeption)
                {
                    message = "Ошибка формата поля начальная скорость";
                    return false;
                }

                try
                {
                    Double.Parse(capacityTank);
                }
                catch (FormatException exeption)
                {
                    message = "Ошибка формата поля емкость бака";
                    return false;
                }

                try
                {
                    Double.Parse(fuelConsption);
                }
                catch (FormatException exeption)
                {
                    message = "Ошибка формата поля расход топлива";
                    return false;
                }
            }
            catch(NullReferenceException ex)
            {
                message = "Заполните все поля";
                return false;
            }
            
            return true;
            
        }
    }
}
