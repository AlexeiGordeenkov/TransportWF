using Presentation.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportWF.Resources
{
    public partial class AddElectricVehicleTypeSelectionView : Form, IAddElectricVehicleTypeSelectionView
    {
        public AddElectricVehicleTypeSelectionView()
        {
            InitializeComponent();
        }

        public event Action TramTypeSelected;
        public event Action TroleyBusTypeSelected;
        public event Action GoBackToSetUpVehicleView;
        public event Action Home;

        private void AddTroleyBusButton_Click(object sender, EventArgs e)
        {
            TroleyBusTypeSelected?.Invoke();
        }

        private void AddTramButton_Click(object sender, EventArgs e)
        {
            TramTypeSelected?.Invoke();
        }

        private void GoBackToSetUpVehicleViewButton_Click(object sender, EventArgs e)
        {
            GoBackToSetUpVehicleView?.Invoke();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home?.Invoke();
        }
    }
}
