using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Model
{
    abstract public class Vehicle
    {
        //Variables
        public string Name { get; set; }
        public string PathToPictures { get; set; }
        public double MaxSpeed { get; set; }
        public double StopPoint { get; set; }
        public double Acceleration { get; set; }
        public double StartSpeed { get; set; }
        public double CurentSpeed { get; set; }
        public double CurrentCoordinate { get; set; }
        public double StartCoordinate { get; set; }
        public DateTime StartTime { get; set; }
        public bool ReachedMaxSpeed { get; set; }
        public List<ArrayList> log;
        public double LastLogCoordinate { get; set; }
        public bool Finished { get; set; }

        //methods
        abstract public double GetMaxDistance();
        abstract public double GetAcceleratingDistance();

        public void SaveData()
        {
            if (log == null)
                return;

            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            // Файл шаблона
            const string template = "template.xlsx";

            // Открываем книгу
            workbook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));

            // Получаем активную таблицу
            worksheet = workbook.ActiveSheet as Worksheet;
            int row = 1;
            foreach (ArrayList arrayList in log)
            {
                for(int col = 1; col <= arrayList.Count; col++)
                {
                    worksheet.Cells[row, col].Value = arrayList[col - 1];
                }
            }
           // worksheet.Cells[1,1].Value = DateTime.Now;
            //worksheet.Cells[1,2].Value = this.Name;
          //  worksheet.Cells[1,3].Value = MaxSpeed;
          //  worksheet.Cells[1, 4].Value = MaxSpeed;


            // Показываем приложение
            application.Visible = true;

            workbook.SaveAs(Path.Combine(Environment.CurrentDirectory, Name + ".xlsx"));

        }
        public void SaveData(string nameFile)
        {
            if (log == null)
                return;

            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            // Файл шаблона
            const string template = "template.xlsx";

            // Открываем книгу
            workbook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));

            // Получаем активную таблицу
            worksheet = workbook.ActiveSheet as Worksheet;
            int row = 1;
            foreach (ArrayList arrayList in log)
            {
                for (int col = 1; col <= arrayList.Count; col++)
                {
                    worksheet.Cells[row, col].Value = arrayList[col - 1];
                }
            }
            // worksheet.Cells[1,1].Value = DateTime.Now;
            //worksheet.Cells[1,2].Value = this.Name;
            //  worksheet.Cells[1,3].Value = MaxSpeed;
            //  worksheet.Cells[1, 4].Value = MaxSpeed;


            // Показываем приложение
            application.Visible = true;

            workbook.SaveAs(Path.Combine(Environment.CurrentDirectory,  nameFile + ".xlsx"));

        }
        protected void Init()
        {
            SetStopPoint();
            SetAcceleration();
            Finished = false;
        }
        protected void SetStopPoint()
        {
            StopPoint = StartCoordinate + GetMaxDistance();
        }
        protected void SetAcceleration()
        {
            double t = GetMaxDistance() > GetAcceleratingDistance() ? GetAcceleratingDistance() : GetMaxDistance();
            Acceleration = (MaxSpeed * MaxSpeed - StartSpeed * StartSpeed) /t;
        }
        public void ResetAcceleration()
        {
            SetAcceleration();
        }

        public double GetTimeFromStart()
        {
            TimeSpan differensTime = (DateTime.Now).Subtract(StartTime);
            return (double)differensTime.TotalMilliseconds/3600000f;
        }

        public abstract Vehicle Clone();

        public override string ToString()
        {
            return Name;
        }
    }
}
