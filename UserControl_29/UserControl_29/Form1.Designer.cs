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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lboxList = new System.Windows.Forms.ListBox();
            this.uCinfo2 = new UserControl_29.UCinfo();
            this.uCinfo3 = new UserControl_29.UCinfo();
            this.uCinfo1 = new UserControl_29.UCinfo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.uCinfo2);
            this.panel1.Controls.Add(this.uCinfo3);
            this.panel1.Controls.Add(this.uCinfo1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 222);
            this.panel1.TabIndex = 3;
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
            // uCinfo2
            // 
            this.uCinfo2.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uCinfo2.Appearance.Options.UseBackColor = true;
            this.uCinfo2.Location = new System.Drawing.Point(255, 7);
            this.uCinfo2.Name = "uCinfo2";
            this.uCinfo2.Size = new System.Drawing.Size(231, 207);
            this.uCinfo2.TabIndex = 1;
            this.uCinfo2.UserFace = global::UserControl_29.Properties.Resources._12;
            this.uCinfo2.UserGold = "3천만원";
            this.uCinfo2.UserName = "임꺽정";
            this.uCinfo2.UserNo = "1";
            // 
            // uCinfo3
            // 
            this.uCinfo3.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uCinfo3.Appearance.Options.UseBackColor = true;
            this.uCinfo3.Location = new System.Drawing.Point(501, 7);
            this.uCinfo3.Name = "uCinfo3";
            this.uCinfo3.Size = new System.Drawing.Size(229, 207);
            this.uCinfo3.TabIndex = 2;
            this.uCinfo3.UserFace = global::UserControl_29.Properties.Resources._13;
            this.uCinfo3.UserGold = "2천5백만원";
            this.uCinfo3.UserName = "아무개";
            this.uCinfo3.UserNo = "1";
            // 
            // uCinfo1
            // 
            this.uCinfo1.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uCinfo1.Appearance.Options.UseBackColor = true;
            this.uCinfo1.Location = new System.Drawing.Point(7, 7);
            this.uCinfo1.Name = "uCinfo1";
            this.uCinfo1.Size = new System.Drawing.Size(231, 207);
            this.uCinfo1.TabIndex = 0;
            this.uCinfo1.UserFace = global::UserControl_29.Properties.Resources._11;
            this.uCinfo1.UserGold = "2천만원";
            this.uCinfo1.UserName = "홍길동";
            this.uCinfo1.UserNo = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 441);
            this.Controls.Add(this.lboxList);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UCinfo uCinfo1;
        private UCinfo uCinfo2;
        private UCinfo uCinfo3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lboxList;
    }
}