using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataTable_Test
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckisTable = false;

            if(ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckisTable = true;  
            }

            //foreach (DataTable item in ds.Tables)
            //{
            //    if (item.TableName.Contains(cboxRegClass.Text))
            //    {
            //        bCheckisTable = true;
            //    }
            //}

            DataTable dt = null;

            if (!bCheckisTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboxRegClass.Text];  
            }

            // Row 자료를 등록
            DataRow row = dt.NewRow();

            row["NAME"] = tboxRegName.Text;

            if (rdoRegSexMale.Checked)
            {
                row["SEX"] = "남자";
            }
            else if (rdoRegSexFemale.Checked)
            {
                row["SEX"] = "여자";
            }

            row["REF"] = tboxRefRef.Text;

            // 생성된 Row를 Table에 등록
            //dt.Rows.Add(row);

            //if (bCheckisTable)
            //{ 
            //    ds.Tables.Remove(cboxRegClass.Text);
            //    ds.Tables.Add(dt);
            //}

            if(bCheckisTable)
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }

            ViewRefresh();
        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgViewInfo.SelectedRows[0].Index;
            ds.Tables[cboxRegClass.Text].Rows.RemoveAt(iSelectRow);

            ViewRefresh();
        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewRefresh();
        }

        private void ViewRefresh()
        { 
           dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];

            // DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
