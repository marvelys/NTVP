namespace View
{
    partial class FormFind
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCertificate = new System.Windows.Forms.CheckBox();
            this.checkBoxPercent = new System.Windows.Forms.CheckBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 244);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Скидка";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Сумма скидки";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Конечная стоимость";
            this.Column3.Name = "Column3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCertificate);
            this.groupBox1.Controls.Add(this.checkBoxPercent);
            this.groupBox1.Location = new System.Drawing.Point(362, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Скидка";
            // 
            // checkBoxCertificate
            // 
            this.checkBoxCertificate.AutoSize = true;
            this.checkBoxCertificate.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCertificate.Name = "checkBoxCertificate";
            this.checkBoxCertificate.Size = new System.Drawing.Size(105, 17);
            this.checkBoxCertificate.TabIndex = 3;
            this.checkBoxCertificate.Text = "Сертификатная";
            this.checkBoxCertificate.UseVisualStyleBackColor = true;
            // 
            // checkBoxPercent
            // 
            this.checkBoxPercent.AutoSize = true;
            this.checkBoxPercent.Location = new System.Drawing.Point(6, 42);
            this.checkBoxPercent.Name = "checkBoxPercent";
            this.checkBoxPercent.Size = new System.Drawing.Size(87, 17);
            this.checkBoxPercent.TabIndex = 0;
            this.checkBoxPercent.Text = "Процентная";
            this.checkBoxPercent.UseVisualStyleBackColor = true;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(368, 158);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(109, 23);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Конечная стоимость";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(368, 112);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(109, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // FormFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrice);
            this.Name = "FormFind";
            this.Text = "FormFind";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxCertificate;
        private System.Windows.Forms.CheckBox checkBoxPercent;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}