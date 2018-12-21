using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.InterfacesForServices
{
   public interface ISimulationService
    {
        void StartSimulation();
        void StopSimulation();
        void SetFirstStart();
        event Action Draw;
    }
}
