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

namespace TransportWF
{
    public partial class AddMotorVehicleTypeSelectionView : Form , IAddMotorVehicleTypeSelectionView
    {
        public AddMotorVehicleTypeSelectionView()
        {
            InitializeComponent();
        }

        public event Action CarTypeSelected;
        public event Action TrukTypeSelected;
        public event Action PanzerTypeSelected;
        public event Action GoBackToSetUpVehicleView;

        private void CarTypeButton_Click(object sender, EventArgs e)
        {
            CarTypeSelected?.Invoke();
        }

        private void TrukTypeButton_Click(object sender, EventArgs e)
        {
            TrukTypeSelected?.Invoke();
        }

        private void PanzerTypeButton_Click(object sender, EventArgs e)
        {
            PanzerTypeSelected?.Invoke();
        }

        private void GoBackToSetUpVihiclesViewButton_Click(object sender, EventArgs e)
        {
            GoBackToSetUpVehicleView?.Invoke();
        }
    }
}
