using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Presentation;

namespace TransportWF
{
    public partial class AddMotorVehicleView : Form, IAddMotorVehicleView
    {
        //XDocument document = new XDocument();
        public AddMotorVehicleView()
        {
            InitializeComponent();
        }

        public event Action AddVehicle;
        public event Action AddMotorVehicleViewLoad;

        private void AddFuelButton_Click(object sender, EventArgs e)
        {
          
            AddVehicle?.Invoke();
            
        }

        private void FuelConsumptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMotorVehicleView_Load(object sender, EventArgs e)
        {
            AddMotorVehicleViewLoad?.Invoke();
        }

        public void ShowListFuel(List<string> ListNameFuel)
        {
            foreach (string nameFuel in ListNameFuel)
                FuelComboBox.Items.Add(nameFuel);
        }

        public void GetData(out string name, out string IndexFuel, out string maxSpeed, 
                            out string startingSpeed, out string capacityTank, out string fuelConsption)
        {
            name = NameTextBox.Text;
            IndexFuel = FuelComboBox.SelectedIndex.ToString();
            maxSpeed = MaxSpeddTextBox.Text;
            startingSpeed = StartingSpeedTextBox.Text;
            capacityTank = CapacityTextBox.Text;
            fuelConsption = FuelConsumptionTextBox.Text;

        }
        public new void Show()
        {
            ShowDialog();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
