﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_33
{
    public partial class ucPanel : UserControl
    {
        public ucPanel()
        {
            InitializeComponent();
        }

        private void ucPanelSizeChanged(object sender, EventArgs e)
        {
            lblPanel.Text = string.Format("({0}.{1})", lblPanel.Width, lblPanel.Height);
        }
    }
}
