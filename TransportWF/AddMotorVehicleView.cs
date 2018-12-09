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
        XDocument document = new XDocument();
        public AddMotorVehicleView()
        {
            InitializeComponent();
        }

        public event Action AddFuel;

        private void AddFuelButton_Click(object sender, EventArgs e)
        {
          
            AddFuel?.Invoke();
            
        }

      
    }
}
