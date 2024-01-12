namespace UserControl_29
{
    partial class UCinfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNo = new System.Windows.Forms.Label();
            this.pboxFace = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnIdle = new System.Windows.Forms.Button();
            this.btnCatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(12, 10);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(16, 18);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "1";
            // 
            // pboxFace
            // 
            this.pboxFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxFace.Location = new System.Drawing.Point(58, 10);
            this.pboxFace.Name = "pboxFace";
            this.pboxFace.Size = new System.Drawing.Size(109, 103);
            this.pboxFace.TabIndex = 1;
            this.pboxFace.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "금액";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(109, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 18);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "아무개";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(109, 145);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(55, 18);
            this.lblGold.TabIndex = 5;
            this.lblGold.Text = "2천만원";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(13, 177);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(65, 23);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "수배";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnIdle
            // 
            this.btnIdle.Location = new System.Drawing.Point(84, 177);
            this.btnIdle.Name = "btnIdle";
            this.btnIdle.Size = new System.Drawing.Size(65, 23);
            this.btnIdle.TabIndex = 7;
            this.btnIdle.Text = "정지";
            this.btnIdle.UseVisualStyleBackColor = true;
            this.btnIdle.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCatch
            // 
            this.btnCatch.Location = new System.Drawing.Point(155, 177);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(65, 23);
            this.btnCatch.TabIndex = 8;
            this.btnCatch.Text = "잡힘";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.btn_Click);
            // 
            // UCinfo
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCatch);
            this.Controls.Add(this.btnIdle);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxFace);
            this.Controls.Add(this.lblNo);
            this.Name = "UCinfo";
            this.Size = new System.Drawing.Size(230, 210);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.PictureBox pboxFace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnIdle;
        private System.Windows.Forms.Button btnCatch;
    }
}
