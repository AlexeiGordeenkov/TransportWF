using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ISetUpRoadView:IView
    {
        event Action Apply;
        event Action SetUpRoadLoad;
        void ShowMessage(string message);
        void LoadDataForSetUpRoadView(List<string> list);
        List<int> GetListOfIndexes();
    }
}
