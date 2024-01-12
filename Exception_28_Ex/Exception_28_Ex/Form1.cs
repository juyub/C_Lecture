using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exception_28_Ex
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<string, Color> dColor = new Dictionary<string, Color>();
        Color oSelectColor = new Color();

        public Form1()
        {
            InitializeComponent();
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();

            if (dRet == DialogResult.OK)
            { 
                pColor.BackColor = cDialogColor.Color;
            }

            lblColorinfo.Text = pColor.BackColor.ToString();
        }

        private void tbarAlpha_Scroll(object sender, EventArgs e)
        {
            pColor.BackColor = Color.FromArgb(tbarAlpha.Value, pColor.BackColor);
            lblColorinfo.Text = pColor.BackColor.ToString();
        }

        private void btnColorSave_Click(object sender, EventArgs e)
        {
            try
            {
                Color oColor = pColor.BackColor;
                dColor.Add(oColor.ToString(), oColor);

                LBoxRefresh();                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LBoxRefresh()
        { 
            try 
            {
                lboxColor.Items.Clear();

                foreach (string okey in dColor.Keys)
                {
                    lboxColor.Items.Add(okey);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 

        }

        private void btnColorDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                // 사전에 있는 색상을 삭제하고
                if (lboxColor.SelectedItem != null && dColor.ContainsKey(lboxColor.SelectedItem.ToString()))
                {
                    dColor.Remove(lboxColor.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("삭제할 Item이 없거나 사전에 키가 없습니다.");
                }
           
                // List를 다시 화면에 뿌려준다
                LBoxRefresh();            
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            oSelectColor = dColor[lboxColor.SelectedItem.ToString()];
        }

        private void Panel_Click(object sender, MouseEventArgs e)
        {
            try
            {
                // TextBox oTbox = sender as Panel;
                // TextBox oTbox = (TextBox)sender;

                if (sender is Panel)
                {
                    Panel oPanel = sender as Panel;
                    oPanel.BackColor = oSelectColor;
                }
                else if (sender is Panel)
                { 
            
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
