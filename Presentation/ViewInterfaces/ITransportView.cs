using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ITransportView:IView
    {
        event Action SetUp;
        event Action ShowLog;
        event Action StartSimulation;
        event Action StopSimulation;
        void WriteTempLabel(string s);
    }
}
