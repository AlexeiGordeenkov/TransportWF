namespace TransportWF
{
    partial class SetUpView
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
            this.SetUpVehiclesButton = new System.Windows.Forms.Button();
            this.SetUpRoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetUpVehiclesButton
            // 
            this.SetUpVehiclesButton.Location = new System.Drawing.Point(98, 114);
            this.SetUpVehiclesButton.Name = "SetUpVehiclesButton";
            this.SetUpVehiclesButton.Size = new System.Drawing.Size(203, 167);
            this.SetUpVehiclesButton.TabIndex = 0;
            this.SetUpVehiclesButton.Text = "Добавить транспортные средства";
            this.SetUpVehiclesButton.UseVisualStyleBackColor = true;
            this.SetUpVehiclesButton.Click += new System.EventHandler(this.SetUpVehiclesButton_Click);
            // 
            // SetUpRoadButton
            // 
            this.SetUpRoadButton.Location = new System.Drawing.Point(450, 114);
            this.SetUpRoadButton.Name = "SetUpRoadButton";
            this.SetUpRoadButton.Size = new System.Drawing.Size(203, 167);
            this.SetUpRoadButton.TabIndex = 1;
            this.SetUpRoadButton.Text = "Настройка дороги";
            this.SetUpRoadButton.UseVisualStyleBackColor = true;
            this.SetUpRoadButton.Click += new System.EventHandler(this.SetUpRoadButton_Click);
            // 
            // SetUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetUpRoadButton);
            this.Controls.Add(this.SetUpVehiclesButton);
            this.Name = "SetUpView";
            this.Text = "SetUpView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetUpVehiclesButton;
        private System.Windows.Forms.Button SetUpRoadButton;
    }
}