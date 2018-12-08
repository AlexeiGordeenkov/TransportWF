using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SetUpRoadPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISetUpRoadView _view;
        private readonly ITransportService _service;
        public SetUpRoadPresenter(IKernel kernel, ISetUpRoadView view, ITransportService service)
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
