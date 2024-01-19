namespace FrameModelingT
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSc1 = new System.Windows.Forms.Button();
            this.btnSc2 = new System.Windows.Forms.Button();
            this.btnSc3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboxLog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(990, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lboxLog
            // 
            this.lboxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 18;
            this.lboxLog.Location = new System.Drawing.Point(3, 3);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(984, 94);
            this.lboxLog.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSc2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSc3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 491);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(984, 74);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSc1
            // 
            this.btnSc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSc1.Location = new System.Drawing.Point(3, 3);
            this.btnSc1.Name = "btnSc1";
            this.btnSc1.Size = new System.Drawing.Size(94, 68);
            this.btnSc1.TabIndex = 0;
            this.btnSc1.Text = "Input";
            this.btnSc1.UseVisualStyleBackColor = true;
            this.btnSc1.Click += new System.EventHandler(this.btnSc1_Click);
            // 
            // btnSc2
            // 
            this.btnSc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSc2.Location = new System.Drawing.Point(103, 3);
            this.btnSc2.Name = "btnSc2";
            this.btnSc2.Size = new System.Drawing.Size(94, 68);
            this.btnSc2.TabIndex = 1;
            this.btnSc2.Text = "Chart";
            this.btnSc2.UseVisualStyleBackColor = true;
            this.btnSc2.Click += new System.EventHandler(this.btnSc2_Click);
            // 
            // btnSc3
            // 
            this.btnSc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSc3.Location = new System.Drawing.Point(203, 3);
            this.btnSc3.Name = "btnSc3";
            this.btnSc3.Size = new System.Drawing.Size(94, 68);
            this.btnSc3.TabIndex = 2;
            this.btnSc3.Text = "Config";
            this.btnSc3.UseVisualStyleBackColor = true;
            this.btnSc3.Click += new System.EventHandler(this.btnSc3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(887, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 68);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(3, 103);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(984, 382);
            this.pMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSc1;
        private System.Windows.Forms.Button btnSc2;
        private System.Windows.Forms.Button btnSc3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pMain;
    }
}

