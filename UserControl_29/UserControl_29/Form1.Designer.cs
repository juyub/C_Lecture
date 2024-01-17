namespace UserControl_29
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
            this.pMain = new System.Windows.Forms.Panel();
            this.ucInfo2 = new UserControl_29.UCinfo();
            this.ucInfo3 = new UserControl_29.UCinfo();
            this.ucInfo1 = new UserControl_29.UCinfo();
            this.lboxList = new System.Windows.Forms.ListBox();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.Peru;
            this.pMain.Controls.Add(this.ucInfo2);
            this.pMain.Controls.Add(this.ucInfo3);
            this.pMain.Controls.Add(this.ucInfo1);
            this.pMain.Location = new System.Drawing.Point(12, 12);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(740, 222);
            this.pMain.TabIndex = 3;
            // 
            // ucInfo2
            // 
            this.ucInfo2.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucInfo2.Appearance.Options.UseBackColor = true;
            this.ucInfo2.Location = new System.Drawing.Point(255, 7);
            this.ucInfo2.Name = "ucInfo2";
            this.ucInfo2.Size = new System.Drawing.Size(231, 207);
            this.ucInfo2.TabIndex = 1;
            this.ucInfo2.UserFace = global::UserControl_29.Properties.Resources._12;
            this.ucInfo2.UserGold = "3천만원";
            this.ucInfo2.UserName = "임꺽정";
            this.ucInfo2.UserNo = "2";
            // 
            // ucInfo3
            // 
            this.ucInfo3.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucInfo3.Appearance.Options.UseBackColor = true;
            this.ucInfo3.Location = new System.Drawing.Point(501, 7);
            this.ucInfo3.Name = "ucInfo3";
            this.ucInfo3.Size = new System.Drawing.Size(229, 207);
            this.ucInfo3.TabIndex = 2;
            this.ucInfo3.UserFace = global::UserControl_29.Properties.Resources._13;
            this.ucInfo3.UserGold = "2천5백만원";
            this.ucInfo3.UserName = "아무개";
            this.ucInfo3.UserNo = "3";
            // 
            // ucInfo1
            // 
            this.ucInfo1.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucInfo1.Appearance.Options.UseBackColor = true;
            this.ucInfo1.Location = new System.Drawing.Point(7, 7);
            this.ucInfo1.Name = "ucInfo1";
            this.ucInfo1.Size = new System.Drawing.Size(231, 207);
            this.ucInfo1.TabIndex = 0;
            this.ucInfo1.UserFace = global::UserControl_29.Properties.Resources._11;
            this.ucInfo1.UserGold = "2천만원";
            this.ucInfo1.UserName = "홍길동";
            this.ucInfo1.UserNo = "1";
            // 
            // lboxList
            // 
            this.lboxList.FormattingEnabled = true;
            this.lboxList.ItemHeight = 18;
            this.lboxList.Location = new System.Drawing.Point(9, 240);
            this.lboxList.Name = "lboxList";
            this.lboxList.Size = new System.Drawing.Size(743, 184);
            this.lboxList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 441);
            this.Controls.Add(this.lboxList);
            this.Controls.Add(this.pMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCinfo ucInfo1;
        private UCinfo ucInfo2;
        private UCinfo ucInfo3;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ListBox lboxList;
    }
}