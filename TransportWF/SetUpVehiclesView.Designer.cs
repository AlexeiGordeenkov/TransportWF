namespace TransportWF
{
    partial class SetUpVehiclesView
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
            this.AddHorseDrawnVehicleButton = new System.Windows.Forms.Button();
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.AddMuscleVehicleButton = new System.Windows.Forms.Button();
            this.GoBackToSetUpViewButton = new System.Windows.Forms.Button();
            this.AddElectricVehicleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddHorseDrawnVehicleButton
            // 
            this.AddHorseDrawnVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AddHorseDrawnVehicleButton.Location = new System.Drawing.Point(28, 44);
            this.AddHorseDrawnVehicleButton.Name = "AddHorseDrawnVehicleButton";
            this.AddHorseDrawnVehicleButton.Size = new System.Drawing.Size(203, 167);
            this.AddHorseDrawnVehicleButton.TabIndex = 1;
            this.AddHorseDrawnVehicleButton.Text = "Добавить Гужевое ТС";
            this.AddHorseDrawnVehicleButton.UseVisualStyleBackColor = true;
            this.AddHorseDrawnVehicleButton.Click += new System.EventHandler(this.AddHorseDrawnVehicleButton_Click);
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AddVehicleButton.Location = new System.Drawing.Point(299, 44);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(203, 167);
            this.AddVehicleButton.TabIndex = 2;
            this.AddVehicleButton.Text = "Добавить Механическое ТС";
            this.AddVehicleButton.UseVisualStyleBackColor = true;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // AddMuscleVehicleButton
            // 
            this.AddMuscleVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AddMuscleVehicleButton.Location = new System.Drawing.Point(561, 44);
            this.AddMuscleVehicleButton.Name = "AddMuscleVehicleButton";
            this.AddMuscleVehicleButton.Size = new System.Drawing.Size(203, 167);
            this.AddMuscleVehicleButton.TabIndex = 3;
            this.AddMuscleVehicleButton.Text = "Добавить ТС приводимое в движение мышечной силой";
            this.AddMuscleVehicleButton.UseVisualStyleBackColor = true;
            this.AddMuscleVehicleButton.Click += new System.EventHandler(this.AddMuscleVehicleButton_Click);
            // 
            // GoBackToSetUpViewButton
            // 
            this.GoBackToSetUpViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GoBackToSetUpViewButton.Location = new System.Drawing.Point(654, 385);
            this.GoBackToSetUpViewButton.Name = "GoBackToSetUpViewButton";
            this.GoBackToSetUpViewButton.Size = new System.Drawing.Size(134, 53);
            this.GoBackToSetUpViewButton.TabIndex = 4;
            this.GoBackToSetUpViewButton.Text = "Назад";
            this.GoBackToSetUpViewButton.UseVisualStyleBackColor = true;
            this.GoBackToSetUpViewButton.Click += new System.EventHandler(this.GoBackToSetUpViewButton_Click);
            // 
            // AddElectricVehicleButton
            // 
            this.AddElectricVehicleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AddElectricVehicleButton.Location = new System.Drawing.Point(299, 240);
            this.AddElectricVehicleButton.Name = "AddElectricVehicleButton";
            this.AddElectricVehicleButton.Size = new System.Drawing.Size(203, 167);
            this.AddElectricVehicleButton.TabIndex = 5;
            this.AddElectricVehicleButton.Text = "Добавить Электрическое ТС";
            this.AddElectricVehicleButton.UseVisualStyleBackColor = true;
            this.AddElectricVehicleButton.Click += new System.EventHandler(this.AddElectricVehicleButton_Click);
            // 
            // SetUpVehiclesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddElectricVehicleButton);
            this.Controls.Add(this.GoBackToSetUpViewButton);
            this.Controls.Add(this.AddMuscleVehicleButton);
            this.Controls.Add(this.AddVehicleButton);
            this.Controls.Add(this.AddHorseDrawnVehicleButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SetUpVehiclesView";
            this.Text = "SetUpVehiclesView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddHorseDrawnVehicleButton;
        private System.Windows.Forms.Button AddVehicleButton;
        private System.Windows.Forms.Button AddMuscleVehicleButton;
        private System.Windows.Forms.Button GoBackToSetUpViewButton;
        private System.Windows.Forms.Button AddElectricVehicleButton;
    }
}