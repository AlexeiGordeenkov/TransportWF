namespace TransportWF
{
    partial class AddElectricVehicleView
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StartingSpeedLabel = new System.Windows.Forms.Label();
            this.StartingSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(46, 67);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(213, 60);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(187, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // StartingSpeedLabel
            // 
            this.StartingSpeedLabel.AutoSize = true;
            this.StartingSpeedLabel.Location = new System.Drawing.Point(46, 120);
            this.StartingSpeedLabel.Name = "StartingSpeedLabel";
            this.StartingSpeedLabel.Size = new System.Drawing.Size(139, 13);
            this.StartingSpeedLabel.TabIndex = 2;
            this.StartingSpeedLabel.Text = "Начальная скорость км/ч";
            // 
            // StartingSpeedTextBox
            // 
            this.StartingSpeedTextBox.Location = new System.Drawing.Point(213, 113);
            this.StartingSpeedTextBox.Name = "StartingSpeedTextBox";
            this.StartingSpeedTextBox.Size = new System.Drawing.Size(187, 20);
            this.StartingSpeedTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Максимальная скорость км/ч";
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(213, 163);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(187, 20);
            this.MaxSpeedTextBox.TabIndex = 5;
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Location = new System.Drawing.Point(83, 231);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(297, 23);
            this.AddVehicleButton.TabIndex = 6;
            this.AddVehicleButton.Text = "Добавить ";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // AddElectricVehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 305);
            this.Controls.Add(this.AddVehicleButton);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartingSpeedTextBox);
            this.Controls.Add(this.StartingSpeedLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddElectricVehicleView";
            this.Text = "AddElectricVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label StartingSpeedLabel;
        private System.Windows.Forms.TextBox StartingSpeedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.Button AddVehicleButton;
    }
}