namespace DelegatePizzaOrder_24
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cboxTopping1 = new System.Windows.Forms.CheckBox();
            this.cboxTopping2 = new System.Windows.Forms.CheckBox();
            this.cboxTopping3 = new System.Windows.Forms.CheckBox();
            this.rdoDow1 = new System.Windows.Forms.RadioButton();
            this.rdoDow2 = new System.Windows.Forms.RadioButton();
            this.rdoEdge1 = new System.Windows.Forms.RadioButton();
            this.rdoEdge2 = new System.Windows.Forms.RadioButton();
            this.numEa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxOrder = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDow1);
            this.groupBox1.Controls.Add(this.rdoDow2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도우";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoEdge1);
            this.groupBox2.Controls.Add(this.rdoEdge2);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "엣지";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboxTopping1);
            this.groupBox3.Controls.Add(this.numEa);
            this.groupBox3.Controls.Add(this.cboxTopping2);
            this.groupBox3.Controls.Add(this.cboxTopping3);
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 127);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "토핑";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(438, 253);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // cboxTopping1
            // 
            this.cboxTopping1.AutoSize = true;
            this.cboxTopping1.Location = new System.Drawing.Point(16, 25);
            this.cboxTopping1.Name = "cboxTopping1";
            this.cboxTopping1.Size = new System.Drawing.Size(152, 22);
            this.cboxTopping1.TabIndex = 3;
            this.cboxTopping1.Text = "소세지 (1ea 500원)";
            this.cboxTopping1.UseVisualStyleBackColor = true;
            // 
            // cboxTopping2
            // 
            this.cboxTopping2.AutoSize = true;
            this.cboxTopping2.Location = new System.Drawing.Point(16, 53);
            this.cboxTopping2.Name = "cboxTopping2";
            this.cboxTopping2.Size = new System.Drawing.Size(139, 22);
            this.cboxTopping2.TabIndex = 4;
            this.cboxTopping2.Text = "감자 (1ea 200원)";
            this.cboxTopping2.UseVisualStyleBackColor = true;
            // 
            // cboxTopping3
            // 
            this.cboxTopping3.AutoSize = true;
            this.cboxTopping3.Location = new System.Drawing.Point(16, 81);
            this.cboxTopping3.Name = "cboxTopping3";
            this.cboxTopping3.Size = new System.Drawing.Size(139, 22);
            this.cboxTopping3.TabIndex = 5;
            this.cboxTopping3.Text = "치즈 (1ea 300원)";
            this.cboxTopping3.UseVisualStyleBackColor = true;
            // 
            // rdoDow1
            // 
            this.rdoDow1.AutoSize = true;
            this.rdoDow1.Location = new System.Drawing.Point(6, 25);
            this.rdoDow1.Name = "rdoDow1";
            this.rdoDow1.Size = new System.Drawing.Size(151, 22);
            this.rdoDow1.TabIndex = 6;
            this.rdoDow1.TabStop = true;
            this.rdoDow1.Text = "오리지널 (10000원)";
            this.rdoDow1.UseVisualStyleBackColor = true;
            // 
            // rdoDow2
            // 
            this.rdoDow2.AutoSize = true;
            this.rdoDow2.Location = new System.Drawing.Point(181, 25);
            this.rdoDow2.Name = "rdoDow2";
            this.rdoDow2.Size = new System.Drawing.Size(112, 22);
            this.rdoDow2.TabIndex = 7;
            this.rdoDow2.TabStop = true;
            this.rdoDow2.Text = "씬 (11000원)";
            this.rdoDow2.UseVisualStyleBackColor = true;
            // 
            // rdoEdge1
            // 
            this.rdoEdge1.AutoSize = true;
            this.rdoEdge1.Location = new System.Drawing.Point(6, 25);
            this.rdoEdge1.Name = "rdoEdge1";
            this.rdoEdge1.Size = new System.Drawing.Size(143, 22);
            this.rdoEdge1.TabIndex = 8;
            this.rdoEdge1.TabStop = true;
            this.rdoEdge1.Text = "리치골드 (1000원)";
            this.rdoEdge1.UseVisualStyleBackColor = true;
            // 
            // rdoEdge2
            // 
            this.rdoEdge2.AutoSize = true;
            this.rdoEdge2.Location = new System.Drawing.Point(180, 25);
            this.rdoEdge2.Name = "rdoEdge2";
            this.rdoEdge2.Size = new System.Drawing.Size(169, 22);
            this.rdoEdge2.TabIndex = 9;
            this.rdoEdge2.TabStop = true;
            this.rdoEdge2.Text = "치즈크러스터 (2000원)";
            this.rdoEdge2.UseVisualStyleBackColor = true;
            // 
            // numEa
            // 
            this.numEa.Location = new System.Drawing.Point(239, 77);
            this.numEa.Name = "numEa";
            this.numEa.Size = new System.Drawing.Size(63, 26);
            this.numEa.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "( EA )";
            // 
            // lboxOrder
            // 
            this.lboxOrder.FormattingEnabled = true;
            this.lboxOrder.ItemHeight = 18;
            this.lboxOrder.Location = new System.Drawing.Point(12, 295);
            this.lboxOrder.Name = "lboxOrder";
            this.lboxOrder.Size = new System.Drawing.Size(543, 238);
            this.lboxOrder.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 543);
            this.Controls.Add(this.lboxOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.CheckBox cboxTopping1;
        private System.Windows.Forms.CheckBox cboxTopping2;
        private System.Windows.Forms.CheckBox cboxTopping3;
        private System.Windows.Forms.RadioButton rdoDow1;
        private System.Windows.Forms.RadioButton rdoDow2;
        private System.Windows.Forms.RadioButton rdoEdge1;
        private System.Windows.Forms.RadioButton rdoEdge2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEa;
        private System.Windows.Forms.ListBox lboxOrder;
    }
}

