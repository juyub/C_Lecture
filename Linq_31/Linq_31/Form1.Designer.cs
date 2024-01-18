namespace Linq_31
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
            this.dgEnemyTable = new System.Windows.Forms.DataGridView();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnAttribute = new System.Windows.Forms.Button();
            this.cboxAttribute = new System.Windows.Forms.ComboBox();
            this.nLevelMin = new System.Windows.Forms.NumericUpDown();
            this.nLevelMax = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnemyTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevelMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevelMax)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEnemyTable
            // 
            this.dgEnemyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnemyTable.Location = new System.Drawing.Point(12, 12);
            this.dgEnemyTable.Name = "dgEnemyTable";
            this.dgEnemyTable.RowHeadersWidth = 51;
            this.dgEnemyTable.RowTemplate.Height = 27;
            this.dgEnemyTable.Size = new System.Drawing.Size(391, 450);
            this.dgEnemyTable.TabIndex = 0;
            // 
            // btnLevel
            // 
            this.btnLevel.Location = new System.Drawing.Point(422, 12);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(165, 33);
            this.btnLevel.TabIndex = 1;
            this.btnLevel.Text = "Level 순으로";
            this.btnLevel.UseVisualStyleBackColor = true;
            this.btnLevel.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(422, 51);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(165, 33);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Name 순으로";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAttribute
            // 
            this.btnAttribute.Location = new System.Drawing.Point(422, 90);
            this.btnAttribute.Name = "btnAttribute";
            this.btnAttribute.Size = new System.Drawing.Size(165, 33);
            this.btnAttribute.TabIndex = 3;
            this.btnAttribute.Text = "속성 순으로";
            this.btnAttribute.UseVisualStyleBackColor = true;
            this.btnAttribute.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cboxAttribute
            // 
            this.cboxAttribute.FormattingEnabled = true;
            this.cboxAttribute.Location = new System.Drawing.Point(422, 173);
            this.cboxAttribute.Name = "cboxAttribute";
            this.cboxAttribute.Size = new System.Drawing.Size(165, 26);
            this.cboxAttribute.TabIndex = 4;
            // 
            // nLevelMin
            // 
            this.nLevelMin.Location = new System.Drawing.Point(422, 226);
            this.nLevelMin.Name = "nLevelMin";
            this.nLevelMin.Size = new System.Drawing.Size(62, 26);
            this.nLevelMin.TabIndex = 5;
            this.nLevelMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nLevelMax
            // 
            this.nLevelMax.Location = new System.Drawing.Point(527, 226);
            this.nLevelMax.Name = "nLevelMax";
            this.nLevelMax.Size = new System.Drawing.Size(60, 26);
            this.nLevelMax.TabIndex = 6;
            this.nLevelMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(422, 286);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(165, 33);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(422, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.nLevelMax);
            this.Controls.Add(this.nLevelMin);
            this.Controls.Add(this.cboxAttribute);
            this.Controls.Add(this.btnAttribute);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnLevel);
            this.Controls.Add(this.dgEnemyTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEnemyTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevelMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLevelMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEnemyTable;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnAttribute;
        private System.Windows.Forms.ComboBox cboxAttribute;
        private System.Windows.Forms.NumericUpDown nLevelMin;
        private System.Windows.Forms.NumericUpDown nLevelMax;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}

