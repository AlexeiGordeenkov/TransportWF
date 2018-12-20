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
            this.SuspendLayout();
            // 
            // addTramButton
            // 
            this.addTramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTramButton.Image = global::TransportWF.Properties.Resources.TramIcon;
            this.addTramButton.Location = new System.Drawing.Point(423, 61);
            this.addTramButton.Name = "addTramButton";
            this.addTramButton.Size = new System.Drawing.Size(210, 167);
            this.addTramButton.TabIndex = 1;
            this.addTramButton.Text = "Трамвай";
            this.addTramButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addTramButton.UseVisualStyleBackColor = true;
            this.addTramButton.Click += new System.EventHandler(this.AddTramButton_Click);
            // 
            // addTroleyBusButton
            // 
            this.addTroleyBusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTroleyBusButton.Image = global::TransportWF.Properties.Resources.TroleyBus;
            this.addTroleyBusButton.Location = new System.Drawing.Point(72, 61);
            this.addTroleyBusButton.Name = "addTroleyBusButton";
            this.addTroleyBusButton.Size = new System.Drawing.Size(199, 167);
            this.addTroleyBusButton.TabIndex = 0;
            this.addTroleyBusButton.Text = "Троллейбус";
            this.addTroleyBusButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addTroleyBusButton.UseVisualStyleBackColor = true;
            this.addTroleyBusButton.Click += new System.EventHandler(this.AddTroleyBusButton_Click);
            // 
            // GoBackToSetUpVehicleViewButton
            // 
            this.GoBackToSetUpVehicleViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackToSetUpVehicleViewButton.Location = new System.Drawing.Point(423, 278);
            this.GoBackToSetUpVehicleViewButton.Name = "GoBackToSetUpVehicleViewButton";
            this.GoBackToSetUpVehicleViewButton.Size = new System.Drawing.Size(210, 77);
            this.GoBackToSetUpVehicleViewButton.TabIndex = 2;
            this.GoBackToSetUpVehicleViewButton.Text = "Назад";
            this.GoBackToSetUpVehicleViewButton.UseVisualStyleBackColor = true;
            this.GoBackToSetUpVehicleViewButton.Click += new System.EventHandler(this.GoBackToSetUpVehicleViewButton_Click);
            // 
            // AddElectricVehicleTypeSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 403);
            this.Controls.Add(this.GoBackToSetUpVehicleViewButton);
            this.Controls.Add(this.addTramButton);
            this.Controls.Add(this.addTroleyBusButton);
            this.Name = "AddElectricVehicleTypeSelectionView";
            this.Text = "AddElectricVehicleTypeSelectionView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTroleyBusButton;
        private System.Windows.Forms.Button addTramButton;
        private System.Windows.Forms.Button GoBackToSetUpVehicleViewButton;
    }
}