using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameModelingT.ucPanel
{
    public partial class ucScreen1 : UserControl
    {
        public event delLogSender eLogSender;

        public ucScreen1()
        {
            InitializeComponent();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            eLogSender("Screen1 Button", enLogLevel.Info, "Button Click");
        }
    }
}
