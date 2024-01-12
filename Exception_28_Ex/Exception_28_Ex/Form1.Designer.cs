namespace Exception_28_Ex
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
            this.tbarAlpha = new System.Windows.Forms.TrackBar();
            this.lblColorinfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pColor = new System.Windows.Forms.Panel();
            this.btnColorSave = new System.Windows.Forms.Button();
            this.btnColorDelete = new System.Windows.Forms.Button();
            this.lboxColor = new System.Windows.Forms.ListBox();
            this.pBack = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cDialogColor = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).BeginInit();
            this.pBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbarAlpha);
            this.groupBox1.Controls.Add(this.lblColorinfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pColor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Select";
            // 
            // tbarAlpha
            // 
            this.tbarAlpha.Location = new System.Drawing.Point(87, 50);
            this.tbarAlpha.Maximum = 255;
            this.tbarAlpha.Name = "tbarAlpha";
            this.tbarAlpha.Size = new System.Drawing.Size(98, 56);
            this.tbarAlpha.TabIndex = 1;
            this.tbarAlpha.Value = 255;
            this.tbarAlpha.Scroll += new System.EventHandler(this.tbarAlpha_Scroll);
            // 
            // lblColorinfo
            // 
            this.lblColorinfo.AutoSize = true;
            this.lblColorinfo.Location = new System.Drawing.Point(84, 106);
            this.lblColorinfo.Name = "lblColorinfo";
            this.lblColorinfo.Size = new System.Drawing.Size(13, 18);
            this.lblColorinfo.TabIndex = 5;
            this.lblColorinfo.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alpha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(16, 50);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(45, 35);
            this.pColor.TabIndex = 0;
            this.pColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pColor_MouseClick);
            // 
            // btnColorSave
            // 
            this.btnColorSave.Location = new System.Drawing.Point(136, 155);
            this.btnColorSave.Name = "btnColorSave";
            this.btnColorSave.Size = new System.Drawing.Size(75, 23);
            this.btnColorSave.TabIndex = 1;
            this.btnColorSave.Text = "저장";
            this.btnColorSave.UseVisualStyleBackColor = true;
            this.btnColorSave.Click += new System.EventHandler(this.btnColorSave_Click);
            // 
            // btnColorDelete
            // 
            this.btnColorDelete.Location = new System.Drawing.Point(217, 155);
            this.btnColorDelete.Name = "btnColorDelete";
            this.btnColorDelete.Size = new System.Drawing.Size(75, 23);
            this.btnColorDelete.TabIndex = 2;
            this.btnColorDelete.Text = "삭제";
            this.btnColorDelete.UseVisualStyleBackColor = true;
            this.btnColorDelete.Click += new System.EventHandler(this.btnColorDelete_Click);
            // 
            // lboxColor
            // 
            this.lboxColor.FormattingEnabled = true;
            this.lboxColor.ItemHeight = 18;
            this.lboxColor.Location = new System.Drawing.Point(12, 188);
            this.lboxColor.Name = "lboxColor";
            this.lboxColor.Size = new System.Drawing.Size(285, 166);
            this.lboxColor.TabIndex = 3;
            this.lboxColor.SelectedIndexChanged += new System.EventHandler(this.lboxColor_SelectedIndexChanged);
            // 
            // pBack
            // 
            this.pBack.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pBack.BackgroundImage = global::Exception_28_Ex.Properties.Resources.Back;
            this.pBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBack.Controls.Add(this.panel4);
            this.pBack.Controls.Add(this.panel3);
            this.pBack.Controls.Add(this.panel5);
            this.pBack.Controls.Add(this.panel6);
            this.pBack.Controls.Add(this.panel2);
            this.pBack.Controls.Add(this.panel1);
            this.pBack.Location = new System.Drawing.Point(318, 12);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(357, 342);
            this.pBack.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(235, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 232);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(91, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 94);
            this.panel4.TabIndex = 1;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(32, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(93, 107);
            this.panel5.TabIndex = 1;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(204, 189);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 118);
            this.panel6.TabIndex = 1;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(15, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 61);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(32, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 137);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 361);
            this.Controls.Add(this.pBack);
            this.Controls.Add(this.lboxColor);
            this.Controls.Add(this.btnColorDelete);
            this.Controls.Add(this.btnColorSave);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).EndInit();
            this.pBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbarAlpha;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Button btnColorSave;
        private System.Windows.Forms.Button btnColorDelete;
        private System.Windows.Forms.ListBox lboxColor;
        private System.Windows.Forms.Label lblColorinfo;
        private System.Windows.Forms.Panel pBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ColorDialog cDialogColor;
    }
}

