using Presentation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TransportWF
{
    public partial class TransportView : Form,ITransportView
    {

        private List<PictureBox> listOfVehicles;

        public TransportView()
        {
            InitializeComponent();
            listOfVehicles = new List<PictureBox>();
            for(int i = 0; i < 5; i++)
            {
                listOfVehicles.Add(new PictureBox());
            }
        }

        public event Action SetUp;
        public event Action ShowLog;
        public event Action StartSimulation;
        public event Action StopSimulation;
        public  event EventHandler<ScrollEventArgs> Scroll;
        public event Action ViewLoad;

        string _s;

        public void WriteTempLabel(String s)
        {
            _s = s;
        }

        private void SetUpSimulationButton_Click(object sender, EventArgs e)
        {
            SetUp?.Invoke();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
           
            StartSimulation?.Invoke();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopSimulation?.Invoke();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            TempLabel.Text = _s;
        }
        public new void Close()
        {
            Hide();
        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Scroll?.Invoke(this, e);             
        }

        public List<int> GetYCoordinatesOfLanes()
        {
           List<int> l = new List<int>(5);
            l.Add(RailsForLine1.Location.Y);
            l.Add(RailsForLine2.Location.Y);
            l.Add(RailsForLine3.Location.Y);
            l.Add(RailsForLine4.Location.Y);
            l.Add(RailsForLine5.Location.Y);
            return l;
        }

        private void TransportView_Load(object sender, EventArgs e)
        {
            ViewLoad?.Invoke();
        }

        public int GetWidth()
        {
            return Size.Width;
        }

        public void DrawCar(int index,string pathToImage, int xCoordinate, int yCoordinate)
        {
           if(pathToImage!=null)
            {
                listOfVehicles[index].Location = new Point(xCoordinate, yCoordinate);
                listOfVehicles[index].Visible = true;
                listOfVehicles[index].BringToFront();
            }
            else
            {
                listOfVehicles[index].Image = null;
            }
        }

        public void MoveCar(int index, int xCoordinate, int yCoordinate)
        {
            listOfVehicles[index].Location = new Point(xCoordinate, yCoordinate);
            
        }
    }
}
