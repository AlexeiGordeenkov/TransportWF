﻿using Presentation;
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
    public partial class SetUpRoadView : Form,ISetUpRoadView
    {
        public SetUpRoadView()
        {
            InitializeComponent();
        }

        public event Action Apply;

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Apply?.Invoke();
        }
    }
}