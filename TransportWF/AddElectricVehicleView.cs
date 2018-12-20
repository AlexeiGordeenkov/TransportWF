﻿using Presentation;
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
    public partial class AddElectricVehicleView : Form, IAddElectricVehicleView
    {
        public AddElectricVehicleView()
        {
            InitializeComponent();
        }

        public event Action AddVehicle;
        public event Action AddElectricVehicleViewLoad;

        public void GetData(out string name, out string maxSpeed, out string startingSpeed)
        {
            name = NameTextBox.Text;
            maxSpeed = MaxSpeedTextBox.Text;
            startingSpeed = StartingSpeedTextBox.Text;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }



        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Clear();
            MaxSpeedTextBox.Clear();
            StartingSpeedTextBox.Clear();
            AddVehicle?.Invoke();
        }
    }
}
