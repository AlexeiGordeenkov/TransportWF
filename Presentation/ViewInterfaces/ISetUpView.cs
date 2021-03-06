﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ISetUpView : IView
    {
        event Action SetUpVehicles;
        event Action SetUpRoad;
        event Action AddFuelInList;
        event Action GoBackToTransportView;
        event Action Home;
    }
}
