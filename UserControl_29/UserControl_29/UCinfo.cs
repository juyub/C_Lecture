using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_29
{
    public partial class UCinfo : DevExpress.XtraEditors.XtraUserControl
    {

        [Category("UserProperty"), Description("Image")]
        public Image UserFace 
        {
            get
            {
                return this.pboxFace.BackgroundImage;
            }
            set
            {
                this.pboxFace.BackgroundImage = value; 
            }
        }

        [Category("UserProperty"), Description("No")]
        public string UserNo
        {
            get
            {
                return this.lblNo.Text;
            }
            set
            {
                this.lblNo.Text = value;
            }
        }

        [Category("UserProperty"), Description("현상범의 이름")]
        public string UserName
        {
            get
            {
                return this.lblName.Text;
            }
            set
            {
                this.lblName.Text = value;
            }
        }

        [Category("UserProperty"), Description("현상범의 금액")]
        public string UserGold
        {
            get
            {
                return this.lblGold.Text;
            }
            set
            {
                this.lblGold.Text = value;
            }
        }

        public UCinfo()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button oBtn = sender as Button;

            switch (oBtn.Name)
            {
                case "btnReg":
                    this.BackColor = Color.Red;
                    break;
                case "btnIdle":
                    this.BackColor = Color.Yellow;
                    break;
                case "btnCatch":
                    this.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }
    }
}
