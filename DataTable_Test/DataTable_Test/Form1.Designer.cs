namespace DataTable_Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxRegClass = new System.Windows.Forms.ComboBox();
            this.cboxViewClass = new System.Windows.Forms.ComboBox();
            this.tboxRegName = new System.Windows.Forms.TextBox();
            this.tboxRefRef = new System.Windows.Forms.TextBox();
            this.rdoRegSexMale = new System.Windows.Forms.RadioButton();
            this.rdoRegSexFemale = new System.Windows.Forms.RadioButton();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnViewDataDel = new System.Windows.Forms.Button();
            this.dgViewInfo = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록하기";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgViewInfo);
            this.groupBox2.Controls.Add(this.btnViewDataDel);
            this.groupBox2.Controls.Add(this.cboxViewClass);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내용 확인";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "반";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "성별";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "특기";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxRegClass
            // 
            this.cboxRegClass.FormattingEnabled = true;
            this.cboxRegClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반"});
            this.cboxRegClass.Location = new System.Drawing.Point(73, 3);
            this.cboxRegClass.Name = "cboxRegClass";
            this.cboxRegClass.Size = new System.Drawing.Size(112, 26);
            this.cboxRegClass.TabIndex = 4;
            // 
            // cboxViewClass
            // 
            this.cboxViewClass.FormattingEnabled = true;
            this.cboxViewClass.Items.AddRange(new object[] {
            "1반",
            "2반",
            "3반"});
            this.cboxViewClass.Location = new System.Drawing.Point(6, 25);
            this.cboxViewClass.Name = "cboxViewClass";
            this.cboxViewClass.Size = new System.Drawing.Size(119, 26);
            this.cboxViewClass.TabIndex = 5;
            this.cboxViewClass.SelectedIndexChanged += new System.EventHandler(this.cboxViewClass_SelectedIndexChanged);
            // 
            // tboxRegName
            // 
            this.tboxRegName.Location = new System.Drawing.Point(73, 38);
            this.tboxRegName.Name = "tboxRegName";
            this.tboxRegName.Size = new System.Drawing.Size(112, 26);
            this.tboxRegName.TabIndex = 2;
            // 
            // tboxRefRef
            // 
            this.tboxRefRef.Location = new System.Drawing.Point(73, 108);
            this.tboxRefRef.Name = "tboxRefRef";
            this.tboxRefRef.Size = new System.Drawing.Size(212, 26);
            this.tboxRefRef.TabIndex = 5;
            // 
            // rdoRegSexMale
            // 
            this.rdoRegSexMale.AutoSize = true;
            this.rdoRegSexMale.Location = new System.Drawing.Point(3, 5);
            this.rdoRegSexMale.Name = "rdoRegSexMale";
            this.rdoRegSexMale.Size = new System.Drawing.Size(55, 22);
            this.rdoRegSexMale.TabIndex = 6;
            this.rdoRegSexMale.TabStop = true;
            this.rdoRegSexMale.Text = "남자";
            this.rdoRegSexMale.UseVisualStyleBackColor = true;
            // 
            // rdoRegSexFemale
            // 
            this.rdoRegSexFemale.AutoSize = true;
            this.rdoRegSexFemale.Location = new System.Drawing.Point(91, 5);
            this.rdoRegSexFemale.Name = "rdoRegSexFemale";
            this.rdoRegSexFemale.Size = new System.Drawing.Size(55, 22);
            this.rdoRegSexFemale.TabIndex = 7;
            this.rdoRegSexFemale.TabStop = true;
            this.rdoRegSexFemale.Text = "여자";
            this.rdoRegSexFemale.UseVisualStyleBackColor = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(323, 118);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(79, 48);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "등록";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnViewDataDel
            // 
            this.btnViewDataDel.Location = new System.Drawing.Point(535, 24);
            this.btnViewDataDel.Name = "btnViewDataDel";
            this.btnViewDataDel.Size = new System.Drawing.Size(88, 26);
            this.btnViewDataDel.TabIndex = 3;
            this.btnViewDataDel.Text = "삭제";
            this.btnViewDataDel.UseVisualStyleBackColor = true;
            this.btnViewDataDel.Click += new System.EventHandler(this.btnViewDataDel_Click);
            // 
            // dgViewInfo
            // 
            this.dgViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewInfo.Location = new System.Drawing.Point(6, 57);
            this.dgViewInfo.Name = "dgViewInfo";
            this.dgViewInfo.RowHeadersWidth = 51;
            this.dgViewInfo.RowTemplate.Height = 27;
            this.dgViewInfo.Size = new System.Drawing.Size(617, 171);
            this.dgViewInfo.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboxRegClass, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxRegName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tboxRefRef, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 141);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoRegSexMale);
            this.panel1.Controls.Add(this.rdoRegSexFemale);
            this.panel1.Location = new System.Drawing.Point(73, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 29);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewInfo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoRegSexFemale;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.RadioButton rdoRegSexMale;
        private System.Windows.Forms.TextBox tboxRefRef;
        private System.Windows.Forms.TextBox tboxRegName;
        private System.Windows.Forms.ComboBox cboxRegClass;
        private System.Windows.Forms.DataGridView dgViewInfo;
        private System.Windows.Forms.Button btnViewDataDel;
        private System.Windows.Forms.ComboBox cboxViewClass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

