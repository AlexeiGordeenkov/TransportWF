using Microsoft.Office.Interop.Excel;
using Model;
using Ninject;
using Presentation.ViewInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Presentation.Presenters
{
    public class SaveLogPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISaveLogView _view;
        private readonly ITransportService _service;
        public SaveLogPresenter(IKernel kernel, ISaveLogView view, ITransportService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.Save += Save;
            _view.ViewLoad += ViewLoad;
        }

        private void ViewLoad()
        {
            List<string> l = new List<string>();
            foreach (var item in _kernel.Get<ITransportService>().GetListOfMovingVehicles())
            {
                l.Add(item.ToString());
            }
            _view.ShowList(l);
        }
        public void Save()
        {
            var vehicle = _kernel.Get<ITransportService>().GetListOfMovingVehicles()[_view.GetIndexOfSelectedVehicle()];
            var log = vehicle.log;
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

            workbook.SaveAs(Path.Combine(Environment.CurrentDirectory, vehicle.Name + ".xlsx"));
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
