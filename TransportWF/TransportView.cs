﻿using Presentation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TransportWF
{
    public partial class TransportView : Form,ITransportView
    {

        private List<PictureBox> listOfVehicles;
        private List<PictureBox> listOfCarPointers;

        public TransportView()
        {
            InitializeComponent();
            listOfVehicles = new List<PictureBox>();
            listOfVehicles.Add(Vehicle1);
            listOfVehicles.Add(Vehicle2);
            listOfVehicles.Add(Vehicle3);
            listOfVehicles.Add(Vehicle4);
            listOfVehicles.Add(Vehicle5);
            listOfCarPointers = new List<PictureBox>();
            listOfCarPointers.Add(CarPointer1);
            listOfCarPointers.Add(CarPointer2);
            listOfCarPointers.Add(CarPointer3);
            listOfCarPointers.Add(CarPointer4);
            listOfCarPointers.Add(CarPointer5);
        }

        public event Action SetUp;
        public event Action ShowLog;
        public event Action StartSimulation;
        public event Action StopSimulation;
        public  event EventHandler<ScrollEventArgs> Scroll;
        public event Action ViewLoad;
        public event Action Tick;

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
            foreach (var item in listOfVehicles)
            {
                l.Add(item.Location.Y);
            }
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

        public void DrawCar(int index,string pathToImage, int _xCoordinate, int _yCoordinate)
        {
            int xCoordinate = _xCoordinate;
            int yCoordinate = _yCoordinate;
           if(pathToImage!=null)
            {
                listOfVehicles[index].Image =(Bitmap)Image.FromFile(pathToImage);
                listOfVehicles[index].Location = new Point(xCoordinate, yCoordinate);
                listOfVehicles[index].Visible = true;
                listOfVehicles[index].BringToFront();
                listOfCarPointers[index].Visible = true;
            }
            else
            {
                listOfVehicles[index].Image = null;
                listOfCarPointers[index].Visible = false;
            }
        }

        public void MoveCar(int index, int _xCoordinate, int _yCoordinate)
        {
            int xCoordinate = _xCoordinate;
            int yCoordinate = _yCoordinate;
            listOfVehicles[index].Location = new Point(xCoordinate, yCoordinate);
            listOfVehicles[index].Visible = true;
            listOfVehicles[index].Update();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Tick?.Invoke();
        }

        public void StartTimer()
        {
            throw new NotImplementedException();
        }

        public void StopTimer()
        {
            throw new NotImplementedException();
        }

        public void HideCar(int index)
        {
            listOfVehicles[index].Visible = false;
        }

        public void MoveCarPointer(int index,int x)
        {
            listOfCarPointers[index].Location = new Point(x + ScrollBar.Location.X + 17, listOfCarPointers[index].Location.Y);
            listOfCarPointers[index].Update();
        }
    }
}
