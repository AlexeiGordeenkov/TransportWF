using Model;
using Ninject;
using Presentation.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
