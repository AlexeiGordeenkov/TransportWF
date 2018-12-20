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
using Model;

namespace TransportWF
{
    public partial class SetUpRoadView : Form, ISetUpRoadView
    {
        public SetUpRoadView()
        {
            InitializeComponent();
        }

        public event Action Apply;
        public event Action SetUpRoadLoad;

        public List<int> GetListOfIndexes()
        {
            List<int> list = new List<int>();
            list.Add(Lane1ComboBox.SelectedIndex);
            list.Add(Lane2ComboBox.SelectedIndex);
            list.Add(Lane3ComboBox.SelectedIndex);
            list.Add(Lane4ComboBox.SelectedIndex);
            list.Add(Lane5ComboBox.SelectedIndex);
            return list;
        }

        public void LoadDataForSetUpRoadView(List<Vehicle> list)
        {
            foreach(Vehicle vehicle in list)
            {
                Lane1ComboBox.Items.Add(vehicle.Name);
                Lane2ComboBox.Items.Add(vehicle);
                Lane3ComboBox.Items.Add(vehicle);
                Lane4ComboBox.Items.Add(vehicle);
                Lane5ComboBox.Items.Add(vehicle);
            }
            
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }

        private void SetUpRoadView_Load(object sender, EventArgs e)
        {
            SetUpRoadLoad?.Invoke();
        }
    }
}
