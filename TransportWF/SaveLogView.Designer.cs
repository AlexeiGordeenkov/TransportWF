namespace TransportWF
{
    partial class SaveLogView
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SaveAssButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 86);
            this.comboBox1.MaximumSize = new System.Drawing.Size(243, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(243, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // SaveAssButton
            // 
            this.SaveAssButton.Location = new System.Drawing.Point(43, 238);
            this.SaveAssButton.Name = "SaveAssButton";
            this.SaveAssButton.Size = new System.Drawing.Size(243, 38);
            this.SaveAssButton.TabIndex = 1;
            this.SaveAssButton.Text = "Сохранить";
            this.SaveAssButton.UseVisualStyleBackColor = true;
            this.SaveAssButton.Click += new System.EventHandler(this.SaveAssButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Транспортное средство";
            // 
            // SaveLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveAssButton);
            this.Controls.Add(this.comboBox1);
            this.Name = "SaveLogView";
            this.Text = "Сохранить Журнал";
            this.Load += new System.EventHandler(this.SaveLogView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SaveAssButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}