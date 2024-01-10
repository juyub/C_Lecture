namespace DelegatePizzaOrder_24
{
    partial class frmPizza
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
            this.lboxMake = new System.Windows.Forms.ListBox();
            this.bntClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxMake
            // 
            this.lboxMake.FormattingEnabled = true;
            this.lboxMake.ItemHeight = 18;
            this.lboxMake.Location = new System.Drawing.Point(12, 12);
            this.lboxMake.Name = "lboxMake";
            this.lboxMake.Size = new System.Drawing.Size(461, 238);
            this.lboxMake.TabIndex = 0;
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(377, 267);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(96, 39);
            this.bntClose.TabIndex = 1;
            this.bntClose.Text = "창 닫기";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 319);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.lboxMake);
            this.Name = "frmPizza";
            this.Text = "frmPizza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxMake;
        private System.Windows.Forms.Button bntClose;
    }
}