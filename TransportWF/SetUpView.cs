using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Presentation;

namespace TransportWF
{
    public partial class SetUpView : Form, ISetUpView
    {
        public SetUpView()
        {
            InitializeComponent();
        }

        public event Action SetUpVehicles;
        public event Action SetUpRoad;

        private void SetUpVehiclesButton_Click(object sender, EventArgs e)
        {
            SetUpVehicles?.Invoke();
        }

        private void SetUpRoadButton_Click(object sender, EventArgs e)
        {
            SetUpRoad?.Invoke();
        }
    }
}

