namespace TransportWF.Resources
{
    partial class AddElectricVehicleTypeSelectionView
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
            this.addTramButton = new System.Windows.Forms.Button();
            this.addTroleyBusButton = new System.Windows.Forms.Button();
            this.GoBackToSetUpVehicleViewButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTramButton
            // 
            this.addTramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addTramButton.Image = global::TransportWF.Properties.Resources.TramIcon;
            this.addTramButton.Location = new System.Drawing.Point(465, 126);
            this.addTramButton.Name = "addTramButton";
            this.addTramButton.Size = new System.Drawing.Size(186, 132);
            this.addTramButton.TabIndex = 1;
            this.addTramButton.Text = "Трамвай";
            this.addTramButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addTramButton.UseVisualStyleBackColor = true;
            this.addTramButton.Click += new System.EventHandler(this.AddTramButton_Click);
            // 
            // addTroleyBusButton
            // 
            this.addTroleyBusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addTroleyBusButton.Image = global::TransportWF.Properties.Resources.TroleyBus;
            this.addTroleyBusButton.Location = new System.Drawing.Point(140, 126);
            this.addTroleyBusButton.Name = "addTroleyBusButton";
            this.addTroleyBusButton.Size = new System.Drawing.Size(186, 132);
            this.addTroleyBusButton.TabIndex = 0;
            this.addTroleyBusButton.Text = "Троллейбус";
            this.addTroleyBusButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addTroleyBusButton.UseVisualStyleBackColor = true;
            this.addTroleyBusButton.Click += new System.EventHandler(this.AddTroleyBusButton_Click);
            // 
            // GoBackToSetUpVehicleViewButton
            // 
            this.GoBackToSetUpVehicleViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GoBackToSetUpVehicleViewButton.Location = new System.Drawing.Point(654, 385);
            this.GoBackToSetUpVehicleViewButton.MaximumSize = new System.Drawing.Size(134, 53);
            this.GoBackToSetUpVehicleViewButton.MinimumSize = new System.Drawing.Size(134, 53);
            this.GoBackToSetUpVehicleViewButton.Name = "GoBackToSetUpVehicleViewButton";
            this.GoBackToSetUpVehicleViewButton.Size = new System.Drawing.Size(134, 53);
            this.GoBackToSetUpVehicleViewButton.TabIndex = 2;
            this.GoBackToSetUpVehicleViewButton.Text = "Назад";
            this.GoBackToSetUpVehicleViewButton.UseVisualStyleBackColor = true;
            this.GoBackToSetUpVehicleViewButton.Click += new System.EventHandler(this.GoBackToSetUpVehicleViewButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.Control;
            this.HomeButton.Image = global::TransportWF.Properties.Resources.home;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(45, 41);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // AddElectricVehicleTypeSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.GoBackToSetUpVehicleViewButton);
            this.Controls.Add(this.addTramButton);
            this.Controls.Add(this.addTroleyBusButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AddElectricVehicleTypeSelectionView";
            this.Text = "Добавить электрическое ТС";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTroleyBusButton;
        private System.Windows.Forms.Button addTramButton;
        private System.Windows.Forms.Button GoBackToSetUpVehicleViewButton;
        private System.Windows.Forms.Button HomeButton;
    }
}