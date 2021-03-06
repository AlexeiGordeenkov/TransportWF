﻿using Presentation.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportWF
{
    public partial class AddMuscleVehicleTypeSelectionView : Form, IAddMuscleVehicleTypeSelectionView
    {

        public AddMuscleVehicleTypeSelectionView()
        {
            InitializeComponent();
        }

       
        public event Action GoBackToSetUpVehicleView;
        public event Action BicycleSelected;
        public event Action ScooterSelected;
        public event Action HorseDrawnWagonSelected;
        public event Action Home;

        private void AddScooterVehicleButton_Click(object sender, EventArgs e)
        {
           ScooterSelected?.Invoke();
        }

        private void GoBackToSetUpVehicleViewButton_Click(object sender, EventArgs e)
        {
            GoBackToSetUpVehicleView?.Invoke();
        }

        private void AddBicycleVehicleButton_Click(object sender, EventArgs e)
        {
            BicycleSelected?.Invoke();
        }

        private void HourseWagonSelectedButton_Click(object sender, EventArgs e)
        {
            HorseDrawnWagonSelected?.Invoke();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home?.Invoke();
        }
    }
}
