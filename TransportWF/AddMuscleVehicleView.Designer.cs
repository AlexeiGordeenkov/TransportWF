namespace TransportWF
{
    partial class AddMuscleVehicleView
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
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StartingSpeedTextBox = new System.Windows.Forms.TextBox();
            this.MaxSpeedTextBox = new System.Windows.Forms.TextBox();
            this.MaxRangeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Location = new System.Drawing.Point(69, 249);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(280, 38);
            this.AddVehicleButton.TabIndex = 0;
            this.AddVehicleButton.Text = "Добавить";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Максимальная растояние км.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Начальная скорость км/ч";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Максимальная скорость км/ч";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(209, 49);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(180, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // StartingSpeedTextBox
            // 
            this.StartingSpeedTextBox.Location = new System.Drawing.Point(209, 92);
            this.StartingSpeedTextBox.Name = "StartingSpeedTextBox";
            this.StartingSpeedTextBox.Size = new System.Drawing.Size(180, 20);
            this.StartingSpeedTextBox.TabIndex = 6;
            // 
            // MaxSpeedTextBox
            // 
            this.MaxSpeedTextBox.Location = new System.Drawing.Point(209, 140);
            this.MaxSpeedTextBox.Name = "MaxSpeedTextBox";
            this.MaxSpeedTextBox.Size = new System.Drawing.Size(180, 20);
            this.MaxSpeedTextBox.TabIndex = 7;
            // 
            // MaxRangeTextBox
            // 
            this.MaxRangeTextBox.Location = new System.Drawing.Point(209, 191);
            this.MaxRangeTextBox.Name = "MaxRangeTextBox";
            this.MaxRangeTextBox.Size = new System.Drawing.Size(180, 20);
            this.MaxRangeTextBox.TabIndex = 8;
            // 
            // AddMuscleVehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 327);
            this.Controls.Add(this.MaxRangeTextBox);
            this.Controls.Add(this.MaxSpeedTextBox);
            this.Controls.Add(this.StartingSpeedTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddVehicleButton);
            this.Name = "AddMuscleVehicleView";
            this.Text = "AddMuscleVehicleView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox StartingSpeedTextBox;
        private System.Windows.Forms.TextBox MaxSpeedTextBox;
        private System.Windows.Forms.TextBox MaxRangeTextBox;
    }
}