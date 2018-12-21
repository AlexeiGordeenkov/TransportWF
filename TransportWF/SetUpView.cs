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
        public event Action GoBackToTransportView;
        public event Action AddFuelInList;
        public event Action Home;

        private void SetUpVehiclesButton_Click(object sender, EventArgs e)
        {
            SetUpVehicles?.Invoke();
        }

        private void SetUpRoadButton_Click(object sender, EventArgs e)
        {
            SetUpRoad?.Invoke();
        }

        private void GoBackToTransportViewButton_Click(object sender, EventArgs e)
        {
            GoBackToTransportView?.Invoke();
        }

        private void AddFuelInList_Click(object sender, EventArgs e)
        {
            AddFuelInList?.Invoke();
        }

<<<<<<< HEAD
        private void SetUpView_Load(object sender, EventArgs e)
        {

=======
        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home?.Invoke();
>>>>>>> bdc774502681cb133edc5cea3bc4318f14bc175a
        }
    }
}

