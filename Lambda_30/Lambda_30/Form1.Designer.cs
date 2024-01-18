namespace Lambda_30
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
            this.btnColorChange_1 = new System.Windows.Forms.Button();
            this.btnColorChange_2 = new System.Windows.Forms.Button();
            this.btnColorChange_3 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblStepCheck = new System.Windows.Forms.Label();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnColorChange_1
            // 
            this.btnColorChange_1.Location = new System.Drawing.Point(12, 12);
            this.btnColorChange_1.Name = "btnColorChange_1";
            this.btnColorChange_1.Size = new System.Drawing.Size(175, 42);
            this.btnColorChange_1.TabIndex = 0;
            this.btnColorChange_1.Text = "Event 함수를 호출";
            this.btnColorChange_1.UseVisualStyleBackColor = true;
            // 
            // btnColorChange_2
            // 
            this.btnColorChange_2.Location = new System.Drawing.Point(12, 60);
            this.btnColorChange_2.Name = "btnColorChange_2";
            this.btnColorChange_2.Size = new System.Drawing.Size(175, 42);
            this.btnColorChange_2.TabIndex = 1;
            this.btnColorChange_2.Text = "무명 메서드 사용";
            this.btnColorChange_2.UseVisualStyleBackColor = true;
            // 
            // btnColorChange_3
            // 
            this.btnColorChange_3.Location = new System.Drawing.Point(12, 108);
            this.btnColorChange_3.Name = "btnColorChange_3";
            this.btnColorChange_3.Size = new System.Drawing.Size(175, 42);
            this.btnColorChange_3.TabIndex = 2;
            this.btnColorChange_3.Text = "람다식 사용";
            this.btnColorChange_3.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(305, 108);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 42);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblStepCheck
            // 
            this.lblStepCheck.AutoSize = true;
            this.lblStepCheck.Location = new System.Drawing.Point(13, 159);
            this.lblStepCheck.Name = "lblStepCheck";
            this.lblStepCheck.Size = new System.Drawing.Size(13, 18);
            this.lblStepCheck.TabIndex = 4;
            this.lblStepCheck.Text = "-";
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.ItemHeight = 18;
            this.lboxResult.Location = new System.Drawing.Point(16, 190);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(411, 166);
            this.lboxResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 372);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.lblStepCheck);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnColorChange_3);
            this.Controls.Add(this.btnColorChange_2);
            this.Controls.Add(this.btnColorChange_1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColorChange_1;
        private System.Windows.Forms.Button btnColorChange_2;
        private System.Windows.Forms.Button btnColorChange_3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblStepCheck;
        private System.Windows.Forms.ListBox lboxResult;
    }
}

