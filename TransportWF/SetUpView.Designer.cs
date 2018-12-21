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
            this.GoBackToTransportViewButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetUpVehiclesButton
            // 
            this.SetUpVehiclesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SetUpVehiclesButton.Location = new System.Drawing.Point(57, 114);
            this.SetUpVehiclesButton.Name = "SetUpVehiclesButton";
            this.SetUpVehiclesButton.Size = new System.Drawing.Size(203, 167);
            this.SetUpVehiclesButton.TabIndex = 0;
            this.SetUpVehiclesButton.Text = "Добавить транспортные средства";
            this.SetUpVehiclesButton.UseVisualStyleBackColor = true;
            this.SetUpVehiclesButton.Click += new System.EventHandler(this.SetUpVehiclesButton_Click);
            // 
            // SetUpRoadButton
            // 
            this.SetUpRoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SetUpRoadButton.Location = new System.Drawing.Point(301, 114);
            this.SetUpRoadButton.Name = "SetUpRoadButton";
            this.SetUpRoadButton.Size = new System.Drawing.Size(203, 167);
            this.SetUpRoadButton.TabIndex = 1;
            this.SetUpRoadButton.Text = "Настройка дороги";
            this.SetUpRoadButton.UseVisualStyleBackColor = true;
            this.SetUpRoadButton.Click += new System.EventHandler(this.SetUpRoadButton_Click);
            // 
            // GoBackToTransportViewButton
            // 
            this.GoBackToTransportViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GoBackToTransportViewButton.Location = new System.Drawing.Point(641, 385);
            this.GoBackToTransportViewButton.Name = "GoBackToTransportViewButton";
            this.GoBackToTransportViewButton.Size = new System.Drawing.Size(134, 53);
            this.GoBackToTransportViewButton.TabIndex = 2;
            this.GoBackToTransportViewButton.Text = "Назад";
            this.GoBackToTransportViewButton.UseVisualStyleBackColor = true;
            this.GoBackToTransportViewButton.Click += new System.EventHandler(this.GoBackToTransportViewButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(556, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 167);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить Топливо В Список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddFuelInList_Click);
            // 
            // SetUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GoBackToTransportViewButton);
            this.Controls.Add(this.SetUpRoadButton);
            this.Controls.Add(this.SetUpVehiclesButton);
            this.Name = "SetUpView";
            this.Text = "SetUpView";
            this.Load += new System.EventHandler(this.SetUpView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetUpVehiclesButton;
        private System.Windows.Forms.Button SetUpRoadButton;
        private System.Windows.Forms.Button GoBackToTransportViewButton;
        private System.Windows.Forms.Button button1;
    }
}