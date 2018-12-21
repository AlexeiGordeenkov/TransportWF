using Presentation;
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
    public partial class AddMuscleVehicleView : Form, IAddMuscleVehicleView
    {
        public AddMuscleVehicleView()
        {
            InitializeComponent();
        }

        public event Action AddVehicle;

        public void GetData(out string name, out string startingSpeed, out string maxSpeed, out string maxRange)
        {
            name = NameTextBox.Text;
            startingSpeed = StartingSpeedTextBox.Text;
            maxSpeed = MaxSpeedTextBox.Text;
            maxRange = MaxRangeTextBox.Text;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicle?.Invoke();
        }
         public new void Show()
        {
            ShowDialog();
        }
    }
}
