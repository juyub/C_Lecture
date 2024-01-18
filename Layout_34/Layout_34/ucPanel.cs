using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_34
{
    public partial class ucPanel : UserControl
    {
        public event EventHandler eLabelDoubleClickHandler;

        public ucPanel()
        {
            InitializeComponent();
        }

        private void ucPanelSizeChanged(object sender, EventArgs e)
        {
            lblPanel.Text = string.Format("({0}.{1})", lblPanel.Width, lblPanel.Height);
        }

        private void lblPanel_DoubleClick(object sender, EventArgs e)
        {
            eLabelDoubleClickHandler(this, e);
        }
    }
}
