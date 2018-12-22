namespace TransportWF
{
    partial class AddMotorVehicleView
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
            this.FuelComboBox = new System.Windows.Forms.ComboBox();
            this.FuelConsumptionTextBox = new System.Windows.Forms.TextBox();
            this.CapacityTextBox = new System.Windows.Forms.TextBox();
            this.StartingSpeedTextBox = new System.Windows.Forms.TextBox();
            this.MaxSpeddTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TankCapacityLabel = new System.Windows.Forms.Label();
            this.StartingSpeeLabel = new System.Windows.Forms.Label();
            this.MaxSpeedLabel = new System.Windows.Forms.Label();
            this.FuelLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddFuelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.FuelComboBox);
            this.panel1.Controls.Add(this.FuelConsumptionTextBox);
            this.panel1.Controls.Add(this.CapacityTextBox);
            this.panel1.Controls.Add(this.StartingSpeedTextBox);
            this.panel1.Controls.Add(this.MaxSpeddTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TankCapacityLabel);
            this.panel1.Controls.Add(this.StartingSpeeLabel);
            this.panel1.Controls.Add(this.MaxSpeedLabel);
            this.panel1.Controls.Add(this.FuelLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.AddFuelButton);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 371);
            this.panel1.TabIndex = 0;
            // 
            // FuelComboBox
            // 
            this.FuelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuelComboBox.FormattingEnabled = true;
            this.FuelComboBox.Location = new System.Drawing.Point(267, 84);
            this.FuelComboBox.Name = "FuelComboBox";
            this.FuelComboBox.Size = new System.Drawing.Size(136, 21);
            this.FuelComboBox.TabIndex = 15;
            // 
            // FuelConsumptionTextBox
            // 
            this.FuelConsumptionTextBox.Location = new System.Drawing.Point(267, 241);
            this.FuelConsumptionTextBox.Name = "FuelConsumptionTextBox";
            this.FuelConsumptionTextBox.Size = new System.Drawing.Size(136, 20);
            this.FuelConsumptionTextBox.TabIndex = 14;
            this.FuelConsumptionTextBox.TextChanged += new System.EventHandler(this.FuelConsumptionTextBox_TextChanged);
            // 
            // CapacityTextBox
            // 
            this.CapacityTextBox.Location = new System.Drawing.Point(267, 198);
            this.CapacityTextBox.Name = "CapacityTextBox";
            this.CapacityTextBox.Size = new System.Drawing.Size(136, 20);
            this.CapacityTextBox.TabIndex = 13;
            // 
            // StartingSpeedTextBox
            // 
            this.StartingSpeedTextBox.Location = new System.Drawing.Point(267, 160);
            this.StartingSpeedTextBox.Name = "StartingSpeedTextBox";
            this.StartingSpeedTextBox.Size = new System.Drawing.Size(136, 20);
            this.StartingSpeedTextBox.TabIndex = 12;
            // 
            // MaxSpeddTextBox
            // 
            this.MaxSpeddTextBox.Location = new System.Drawing.Point(267, 122);
            this.MaxSpeddTextBox.Name = "MaxSpeddTextBox";
            this.MaxSpeddTextBox.Size = new System.Drawing.Size(136, 20);
            this.MaxSpeddTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Расход топлиа на (л/100км)";
            // 
            // TankCapacityLabel
            // 
            this.TankCapacityLabel.AutoSize = true;
            this.TankCapacityLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TankCapacityLabel.Location = new System.Drawing.Point(69, 198);
            this.TankCapacityLabel.Name = "TankCapacityLabel";
            this.TankCapacityLabel.Size = new System.Drawing.Size(109, 13);
            this.TankCapacityLabel.TabIndex = 7;
            this.TankCapacityLabel.Text = "Ёмксть бака(литры)";
            // 
            // StartingSpeeLabel
            // 
            this.StartingSpeeLabel.AutoSize = true;
            this.StartingSpeeLabel.Location = new System.Drawing.Point(66, 160);
            this.StartingSpeeLabel.Name = "StartingSpeeLabel";
            this.StartingSpeeLabel.Size = new System.Drawing.Size(142, 13);
            this.StartingSpeeLabel.TabIndex = 6;
            this.StartingSpeeLabel.Text = "Начальная скорость(км/ч)";
            // 
            // MaxSpeedLabel
            // 
            this.MaxSpeedLabel.AutoSize = true;
            this.MaxSpeedLabel.Location = new System.Drawing.Point(66, 122);
            this.MaxSpeedLabel.Name = "MaxSpeedLabel";
            this.MaxSpeedLabel.Size = new System.Drawing.Size(158, 13);
            this.MaxSpeedLabel.TabIndex = 5;
            this.MaxSpeedLabel.Text = "Максимальная скоость(км/ч)";
            // 
            // FuelLabel
            // 
            this.FuelLabel.AutoSize = true;
            this.FuelLabel.Location = new System.Drawing.Point(66, 84);
            this.FuelLabel.Name = "FuelLabel";
            this.FuelLabel.Size = new System.Drawing.Size(50, 13);
            this.FuelLabel.TabIndex = 4;
            this.FuelLabel.Text = "Топливо";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(66, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Имя";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(267, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(136, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // AddFuelButton
            // 
            this.AddFuelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFuelButton.Location = new System.Drawing.Point(100, 303);
            this.AddFuelButton.Name = "AddFuelButton";
            this.AddFuelButton.Size = new System.Drawing.Size(224, 39);
            this.AddFuelButton.TabIndex = 0;
            this.AddFuelButton.Text = "Добавить";
            this.AddFuelButton.UseVisualStyleBackColor = true;
            this.AddFuelButton.Click += new System.EventHandler(this.AddFuelButton_Click);
            // 
            // AddMotorVehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 369);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(464, 408);
            this.MinimumSize = new System.Drawing.Size(464, 408);
            this.Name = "AddMotorVehicleView";
            this.Text = "Добавить механическое ТС";
            this.Load += new System.EventHandler(this.AddMotorVehicleView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FuelConsumptionTextBox;
        private System.Windows.Forms.TextBox CapacityTextBox;
        private System.Windows.Forms.TextBox StartingSpeedTextBox;
        private System.Windows.Forms.TextBox MaxSpeddTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TankCapacityLabel;
        private System.Windows.Forms.Label StartingSpeeLabel;
        private System.Windows.Forms.Label MaxSpeedLabel;
        private System.Windows.Forms.Label FuelLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddFuelButton;
        private System.Windows.Forms.ComboBox FuelComboBox;
    }
}