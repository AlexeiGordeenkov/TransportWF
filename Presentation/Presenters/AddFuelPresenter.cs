﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.ViewInterfaces;
using Ninject;
using Model;

namespace Presentation.Presenters
{
    public class AddFuelPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IAddFuelView _view;
        private readonly ITransportService _service;

        public AddFuelPresenter(IKernel kernel, IAddFuelView view, ITransportService service)
        {
            _kernel = kernel;
            _view = view;
            _service = service;

            _view.AddFuel += AddFuel;
        }

        private void AddFuel()
        {
            string NameFuel = _view.GetNameFuel();
            if (_service.VerifiacationFuel(new Fuel(NameFuel)))
                _service.AddFuelInList(new Fuel(NameFuel));
            
            _view.ShowListFuel(_service.GetListNameFuel());
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
