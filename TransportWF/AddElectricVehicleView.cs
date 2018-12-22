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
    public partial class AddElectricVehicleView : Form, IAddElectricVehicleView
    {
        public AddElectricVehicleView()
        {
            InitializeComponent();
        }

        public event Action AddVehicle;

        public void GetData(out string name,  out string startingSpeed, out string maxSpeed)
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
            AddVehicle?.Invoke();
           
        }
        public new void Show()
        {
            ShowDialog();
        }
    }
}
