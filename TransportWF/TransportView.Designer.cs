namespace TransportWF
{
    partial class TransportView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetUpSimulationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetUpSimulationButton
            // 
            this.SetUpSimulationButton.Location = new System.Drawing.Point(587, 51);
            this.SetUpSimulationButton.Name = "SetUpSimulationButton";
            this.SetUpSimulationButton.Size = new System.Drawing.Size(124, 74);
            this.SetUpSimulationButton.TabIndex = 0;
            this.SetUpSimulationButton.Text = "Настройка симуляции";
            this.SetUpSimulationButton.UseVisualStyleBackColor = true;
            this.SetUpSimulationButton.Click += new System.EventHandler(this.SetUpSimulationButton_Click);
            // 
            // TransportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetUpSimulationButton);
            this.Name = "TransportView";
            this.Text = "Transport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetUpSimulationButton;
    }
}

