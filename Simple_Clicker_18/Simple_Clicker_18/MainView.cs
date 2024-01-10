using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Clicker_18
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        private double iTick = 0;  // 한 Tick 당 더할 값
        private double iTotal = 0;  // 전체 값 

        private int i1Add = 1;  // 1 * LEVEL 값  
        private int i1Level = 1;

        private int i3Add = 3;  // 3 * LEVEL 값     
        private int i3Level = 1;

        private int i50Add = 0;   // 50 * LEVEL 값    
        private int i50Level = 0;



        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer oTimer = new System.Windows.Forms.Timer();
            oTimer.Enabled = true;
            oTimer.Interval = 100;
            oTimer.Tick += OTimer_Tick;
            oTimer.Start();
        }

        private void OTimer_Tick(object sender, EventArgs e)
        {
            // throw new NotImplementedException();

            iTick = i1Add + i3Add + i50Add;
            iTotal = iTotal + iTick;

            lblTickPoint.Text = string.Format("{0} (1:{1}), (3:{2}), (50:{3})", iTick.ToString(), i1Level.ToString(), i3Level.ToString(), i50Level.ToString());
            lblTotal.Text = iTotal.ToString();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button;

            switch (obtn.Name)
            {
                case "btn1add":
                    if (iTotal > 100)
                    {
                        iTotal = iTotal - 100;

                        i1Level++;
                        i1Level = 1 * i1Level;
                    }
                    break;
                case "btn3add":
                    if (iTotal > 300)
                    { iTotal = iTotal - 300;

                        i3Level++;
                        i3Add = 3 * i3Level; 
                    }
                    break;
                case "btn50add":
                    if (iTotal > 5000)
                    {
                        iTotal = iTotal - 5000; 

                        i50Level++;
                        i50Add = 50 * i50Level;  
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
