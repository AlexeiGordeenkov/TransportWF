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
    public partial class SetUpVehiclesView : Form,ISetUpVehiclesView
    {
        public SetUpVehiclesView()
        {
            InitializeComponent();
        }

        public event Action GoBackToSetUpView;
        public event Action AddGooseVehicle;
        public event Action AddMuscleVehicle;
        public event Action AddGasolineVehicle;
        public event Action AddElectricVehicle;

        private void GoBackToSetUpViewButton_Click(object sender, EventArgs e)
        {
            GoBackToSetUpView?.Invoke();
        }

        private void AddGooseVehicleButton_Click(object sender, EventArgs e)
        {
            AddGooseVehicle?.Invoke();
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddGasolineVehicle?.Invoke();
        }

        private void AddMuscleVehicleButton_Click(object sender, EventArgs e)
        {
            AddMuscleVehicle?.Invoke();
        }

        private void AddElectricVehicleButton_Click(object sender, EventArgs e)
        {
            AddElectricVehicle?.Invoke();
        }
    }
}
