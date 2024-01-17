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
        public delegate int delEvent(object Sender, String strText);    // delegate 선언
        public event delEvent eventdelSender;   // delegate event 선언


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
            string strText = string.Empty;

            Button oBtn = sender as Button;

            switch (oBtn.Name)
            {
                case "btnReg":
                    this.BackColor = Color.Red;
                    strText = string.Format("{0}은 금액 {1}으로 수배중 입니다.", lblName.Text ,lblGold.Text);
                    break;
                case "btnIdle":
                    this.BackColor = Color.Yellow;
                    strText = string.Format("{0}은 수배 중지 상태 입니다.", lblName.Text);
                    break;
                case "btnCatch":
                    this.BackColor = Color.Green;
                    strText = string.Format("{0}은 금액 잡혔습니다.", lblName.Text);
                    break;
                default:
                    break;
            }

            if (eventdelSender != null) // 부모가 Event를 생성하지 않았을 수 있으므로 생성 했을 경우에만
            {
                eventdelSender(this, strText);
            }
        }
    }
}
