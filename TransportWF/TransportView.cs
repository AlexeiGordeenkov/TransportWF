using Presentation;
using System;
using System.Windows.Forms;

namespace TransportWF
{
    public partial class TransportView : Form,ITransportView
    {
        public TransportView()
        {
            InitializeComponent();
        }

        public event Action SetUp;
        public event Action ShowLog;
        public event Action StartSimulation;
        public event Action StopSimulation;

        string _s;

        public void WriteTempLabel(String s)
        {
            _s = s;
        }

        private void SetUpSimulationButton_Click(object sender, EventArgs e)
        {
            SetUp?.Invoke();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
           
            StartSimulation?.Invoke();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StopSimulation?.Invoke();
        }

        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            TempLabel.Text = _s;
        }
        public new void Close()
        {
            Hide();
        }
    }
}
