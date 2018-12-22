namespace TransportWF
{
    partial class AddMuscleVehicleTypeSelectionView
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
            this.GoBackToSetUpVehicleViewButton = new System.Windows.Forms.Button();
            this.HourseWagonSelectedButton = new System.Windows.Forms.Button();
            this.AddScooterVehicleButton = new System.Windows.Forms.Button();
            this.AddBicycleVehicleButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoBackToSetUpVehicleViewButton
            // 
            this.GoBackToSetUpVehicleViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GoBackToSetUpVehicleViewButton.Location = new System.Drawing.Point(654, 385);
            this.GoBackToSetUpVehicleViewButton.Name = "GoBackToSetUpVehicleViewButton";
            this.GoBackToSetUpVehicleViewButton.Size = new System.Drawing.Size(134, 53);
            this.GoBackToSetUpVehicleViewButton.TabIndex = 2;
            this.GoBackToSetUpVehicleViewButton.Text = "Назад";
            this.GoBackToSetUpVehicleViewButton.UseVisualStyleBackColor = true;
            this.GoBackToSetUpVehicleViewButton.Click += new System.EventHandler(this.GoBackToSetUpVehicleViewButton_Click);
            // 
            // HourseWagonSelectedButton
            // 
            this.HourseWagonSelectedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HourseWagonSelectedButton.Image = global::TransportWF.Properties.Resources.HourseWagon1;
            this.HourseWagonSelectedButton.Location = new System.Drawing.Point(552, 137);
            this.HourseWagonSelectedButton.Name = "HourseWagonSelectedButton";
            this.HourseWagonSelectedButton.Size = new System.Drawing.Size(186, 132);
            this.HourseWagonSelectedButton.TabIndex = 3;
            this.HourseWagonSelectedButton.Text = "Гужевая повозка";
            this.HourseWagonSelectedButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HourseWagonSelectedButton.UseVisualStyleBackColor = true;
            this.HourseWagonSelectedButton.Click += new System.EventHandler(this.HourseWagonSelectedButton_Click);
            // 
            // AddScooterVehicleButton
            // 
            this.AddScooterVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddScooterVehicleButton.Image = global::TransportWF.Properties.Resources.Scooter;
            this.AddScooterVehicleButton.Location = new System.Drawing.Point(300, 137);
            this.AddScooterVehicleButton.Name = "AddScooterVehicleButton";
            this.AddScooterVehicleButton.Size = new System.Drawing.Size(186, 132);
            this.AddScooterVehicleButton.TabIndex = 1;
            this.AddScooterVehicleButton.Text = "Самокат";
            this.AddScooterVehicleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddScooterVehicleButton.UseVisualStyleBackColor = true;
            this.AddScooterVehicleButton.Click += new System.EventHandler(this.AddScooterVehicleButton_Click);
            // 
            // AddBicycleVehicleButton
            // 
            this.AddBicycleVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBicycleVehicleButton.Image = global::TransportWF.Properties.Resources.Bicycle;
            this.AddBicycleVehicleButton.Location = new System.Drawing.Point(44, 137);
            this.AddBicycleVehicleButton.Name = "AddBicycleVehicleButton";
            this.AddBicycleVehicleButton.Size = new System.Drawing.Size(186, 132);
            this.AddBicycleVehicleButton.TabIndex = 0;
            this.AddBicycleVehicleButton.Text = "Велосипед";
            this.AddBicycleVehicleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBicycleVehicleButton.UseVisualStyleBackColor = true;
            this.AddBicycleVehicleButton.Click += new System.EventHandler(this.AddBicycleVehicleButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.Control;
            this.HomeButton.Image = global::TransportWF.Properties.Resources.home;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(45, 41);
            this.HomeButton.TabIndex = 6;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // AddMuscleVehicleTypeSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.HourseWagonSelectedButton);
            this.Controls.Add(this.GoBackToSetUpVehicleViewButton);
            this.Controls.Add(this.AddScooterVehicleButton);
            this.Controls.Add(this.AddBicycleVehicleButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AddMuscleVehicleTypeSelectionView";
            this.Text = "AddMuscleVehicleTypeSelectionView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBicycleVehicleButton;
        private System.Windows.Forms.Button AddScooterVehicleButton;
        private System.Windows.Forms.Button GoBackToSetUpVehicleViewButton;
        private System.Windows.Forms.Button HourseWagonSelectedButton;
        private System.Windows.Forms.Button HomeButton;
    }
}