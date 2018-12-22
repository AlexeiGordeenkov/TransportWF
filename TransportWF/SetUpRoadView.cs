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
            if(Lane1ComboBox.SelectedItem!= null && Lane1ComboBox.SelectedItem.ToString() != "")
                list.Add(Lane1ComboBox.SelectedIndex);
            else
                list.Add(-1);
            if (Lane2ComboBox.SelectedItem != null && Lane2ComboBox.SelectedItem.ToString() != "")
                list.Add(Lane2ComboBox.SelectedIndex);
            else
                list.Add(-1);
            if (Lane3ComboBox.SelectedItem != null && Lane3ComboBox.SelectedItem.ToString() != "")
                list.Add(Lane3ComboBox.SelectedIndex);
            else
                list.Add(-1);
            if (Lane4ComboBox.SelectedItem != null && Lane4ComboBox.SelectedItem.ToString() != "")
                list.Add(Lane4ComboBox.SelectedIndex);
            else
                list.Add(-1);
            if (Lane5ComboBox.SelectedItem != null && Lane5ComboBox.SelectedItem.ToString() != "")
                list.Add(Lane5ComboBox.SelectedIndex);
            else
                list.Add(-1);
            return list;
        }

        public void LoadDataForSetUpRoadView(List<string> list)
        {
            foreach(string name in list)
            {
                Lane1ComboBox.Items.Add(name);
                Lane2ComboBox.Items.Add(name);
                Lane3ComboBox.Items.Add(name);
                Lane4ComboBox.Items.Add(name);
                Lane5ComboBox.Items.Add(name);
            }
            Lane1ComboBox.Items.Add("");
            Lane2ComboBox.Items.Add("");
            Lane3ComboBox.Items.Add("");
            Lane4ComboBox.Items.Add("");
            Lane5ComboBox.Items.Add("");
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

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
