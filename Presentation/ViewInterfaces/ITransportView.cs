using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public interface ITransportView:IView
    {
        event Action SetUp;
        event Action ShowLog;
        event Action StartSimulation;
        event Action StopSimulation;
        event Action ViewLoad;
        event Action Tick;
        event EventHandler<ScrollEventArgs> Scroll;
        void WriteTempLabel(string s);
        List<int> GetYCoordinatesOfLanes();
        int GetWidth();
        void DrawCar(int index,string pathToImage, int xCoordinate, int yCoordinate);
        void MoveCar(int index, int xCoordinate, int yCoordinate);
        void MoveCarPointer(int index, int x);
        void HideCar(int index);
        void StartTimer();
        void StopTimer();
    }
}
