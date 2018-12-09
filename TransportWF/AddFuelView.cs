using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.ViewInterfaces;

namespace TransportWF
{
    public partial class AddFuelView : Form, IAddFuelView
    {
        public AddFuelView()
        {
            InitializeComponent();
           
        }

        public string GetNameFuel() => NewFuelTextBox.Text;

        public void ShowListFuel(List<string> ListNameFuel) {
            ListFuelTextBox.Text = "";
            foreach(string name in ListNameFuel)
            {
                ListFuelTextBox.Text += name + Environment.NewLine;
            }
        }
        
        public event Action AddFuel;
        public event Action AddFuelViewLoad;

        private void AddFuelButton_Click(object sender, EventArgs e)
        {
            AddFuel?.Invoke();
        }

        private void AddFuelView_Load(object sender, EventArgs e)
        {
            AddFuelViewLoad?.Invoke();
        }
        public new void Show()
        {
            ShowDialog();
        }
    }
}
