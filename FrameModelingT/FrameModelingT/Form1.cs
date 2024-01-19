using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrameModelingT
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        ucPanel.ucScreen1 ucSc1 = new ucPanel.ucScreen1();
        ucPanel.ucScreen2 ucSc2 = new ucPanel.ucScreen2();
        ucPanel.ucScreen3 ucSc3 = new ucPanel.ucScreen3();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ucSc1.eLogSender += UcSc_eLogSender;
            ucSc2.eLogSender += UcSc_eLogSender;
            ucSc3.eLogSender += UcSc_eLogSender;

            pMain.Controls.Add(ucSc1);
        }

        #region del Event
        private void UcSc_eLogSender(object oSender, enLogLevel eLevel, string strLog)
        {
            Log(eLevel, $"[{oSender.ToString()}] {strLog}");
        }
        #endregion

        #region 버튼 Event

        private void btnSc1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Log(enLogLevel.Info, $"{btn.Text} 버튼 Click");

            pMain.Controls.Clear();
            pMain.Controls.Add(ucSc1);
        }

        private void btnSc2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Log(enLogLevel.Info, $"{btn.Text} 버튼 Click");

            pMain.Controls.Clear();
            pMain.Controls.Add(ucSc2);
        }

        private void btnSc3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Log(enLogLevel.Info, $"{btn.Text} 버튼 Click");

            pMain.Controls.Clear();
            pMain.Controls.Add(ucSc3);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Log OverLoading  
        private void Log(enLogLevel eLevel, string LogDesc)    
        {    
            DateTime dTime = DateTime.Now;     
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";   
            lboxLog.Items.Insert(0, LogInfo);      
        }  
        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)     
        {       
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";      
            lboxLog.Items.Insert(0, LogInfo);   
        }    
        #endregion


    }
}
