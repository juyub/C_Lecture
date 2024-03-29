﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Layout_34
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ucCMenu.eColorSender += UcCMenu_eColorSender;
            ucCMenu.eColorAction += UcCMenu_eColorAction;

            ucPanelTop.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter1.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter2.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelRight.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
        }

        //private void UcCMenu_eColorSender(object oSender, Color oColor)
        //{
        //    throw new NotImplementedException();
        //}

        private void UcCMenu_eColorAction(Button arg1, Color arg2)
        {
            // Button obtn = arg1 as Button;

            string strPanelName = string.Empty;

            switch (arg1.Name)
            {
                case "btn1":
                    ucPanelTop.BackColor = arg2;
                    strPanelName = "Panel Top";
                    break;
                case "btn2":
                    ucPanelCenter1.BackColor = arg2;
                    strPanelName = "Panel Center1";
                    break;
                case "btn3":
                    ucPanelCenter2.BackColor = arg2;
                    strPanelName = "Panel Center2";
                    break;
                case "btn4":
                    ucPanelRight.BackColor = arg2;
                    strPanelName = "Panel Right";
                    break;
                default:
                    break;
            }

            string strResult = string.Format("선택 : {0}, {1}의 색상을 {2}로 변경", arg1.Name, strPanelName, arg2.ToString());
            lBoxLog.Items.Add(strResult);
        }

        private void UcPanel_eLabelDoubleClickHandler(object sender, EventArgs e)
        {
            string strResult = ucCMenu.fButtonColorChange((ucPanel)sender);

            lBoxLog.Items.Add(strResult);
        }
    }
}
