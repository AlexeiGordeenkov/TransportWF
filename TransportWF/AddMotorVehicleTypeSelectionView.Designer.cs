namespace TransportWF
{
    partial class AddMotorVehicleTypeSelectionView
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
            this.PanzerTypeButton = new System.Windows.Forms.Button();
            this.TrukTypeButton = new System.Windows.Forms.Button();
            this.CarTypeButton = new System.Windows.Forms.Button();
            this.GooBackSetUpVihiclesViewButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanzerTypeButton
            // 
            this.PanzerTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.PanzerTypeButton.Image = global::TransportWF.Properties.Resources.Panzer;
            this.PanzerTypeButton.Location = new System.Drawing.Point(552, 137);
            this.PanzerTypeButton.Name = "PanzerTypeButton";
            this.PanzerTypeButton.Size = new System.Drawing.Size(186, 132);
            this.PanzerTypeButton.TabIndex = 2;
            this.PanzerTypeButton.Text = "Танк";
            this.PanzerTypeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PanzerTypeButton.UseVisualStyleBackColor = true;
            this.PanzerTypeButton.Click += new System.EventHandler(this.PanzerTypeButton_Click);
            // 
            // TrukTypeButton
            // 
            this.TrukTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TrukTypeButton.Image = global::TransportWF.Properties.Resources.TruckIcon;
            this.TrukTypeButton.Location = new System.Drawing.Point(300, 137);
            this.TrukTypeButton.Name = "TrukTypeButton";
            this.TrukTypeButton.Size = new System.Drawing.Size(186, 132);
            this.TrukTypeButton.TabIndex = 1;
            this.TrukTypeButton.Text = "Грузовой автомобиль";
            this.TrukTypeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TrukTypeButton.UseVisualStyleBackColor = true;
            this.TrukTypeButton.Click += new System.EventHandler(this.TrukTypeButton_Click);
            // 
            // CarTypeButton
            // 
            this.CarTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CarTypeButton.Image = global::TransportWF.Properties.Resources.CarIcon;
            this.CarTypeButton.Location = new System.Drawing.Point(44, 137);
            this.CarTypeButton.Name = "CarTypeButton";
            this.CarTypeButton.Size = new System.Drawing.Size(186, 132);
            this.CarTypeButton.TabIndex = 0;
            this.CarTypeButton.Text = "Легковой автомобиль";
            this.CarTypeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CarTypeButton.UseVisualStyleBackColor = true;
            this.CarTypeButton.Click += new System.EventHandler(this.CarTypeButton_Click);
            // 
            // GooBackSetUpVihiclesViewButton
            // 
            this.GooBackSetUpVihiclesViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GooBackSetUpVihiclesViewButton.Location = new System.Drawing.Point(654, 385);
            this.GooBackSetUpVihiclesViewButton.Name = "GooBackSetUpVihiclesViewButton";
            this.GooBackSetUpVihiclesViewButton.Size = new System.Drawing.Size(134, 53);
            this.GooBackSetUpVihiclesViewButton.TabIndex = 3;
            this.GooBackSetUpVihiclesViewButton.Text = "Назад";
            this.GooBackSetUpVihiclesViewButton.UseVisualStyleBackColor = true;
            this.GooBackSetUpVihiclesViewButton.Click += new System.EventHandler(this.GoBackToSetUpVihiclesViewButton_Click);
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
            // AddMotorVehicleTypeSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.GooBackSetUpVihiclesViewButton);
            this.Controls.Add(this.PanzerTypeButton);
            this.Controls.Add(this.TrukTypeButton);
            this.Controls.Add(this.CarTypeButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AddMotorVehicleTypeSelectionView";
            this.Text = "Добавить механическое ТС";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CarTypeButton;
        private System.Windows.Forms.Button TrukTypeButton;
        private System.Windows.Forms.Button PanzerTypeButton;
        private System.Windows.Forms.Button GooBackSetUpVihiclesViewButton;
        private System.Windows.Forms.Button HomeButton;
    }
}