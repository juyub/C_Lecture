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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            // ucInfo1.eventdelSender += UCinfo1_eventdelSender;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var oControl in pMain.Controls)
            {
                if (oControl is UCinfo)
                {
                    UCinfo oInfo = oControl as UCinfo;

                    oInfo.eventdelSender += Oinfo_eventdelSender;
                }
            }
        }

        private int Oinfo_eventdelSender(object Sender, string strText)
        {
            UCinfo oInfo = Sender as UCinfo;

            lboxList.Items.Add(string.Format("{0}) {1}", oInfo.UserNo, strText));

            return 0;
        }

        //private int UCinfo1_eventdelSender(object Sender, string strText)
        //{
        //    lboxList.Items.Add(string.Format("{0}) {1}", ucInfo1.UserNo, strText));

        //    return 0;
        //}
    }
}