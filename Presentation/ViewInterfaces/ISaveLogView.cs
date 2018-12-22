using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ViewInterfaces
{
    public interface ISaveLogView : IView
    {
        event Action Save;
        event Action ViewLoad;
        int GetIndexOfSelectedVehicle();
        void ShowList(List<string> list);
    }
}
