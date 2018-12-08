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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ShowLogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetUpSimulationButton
            // 
            this.SetUpSimulationButton.Location = new System.Drawing.Point(396, 22);
            this.SetUpSimulationButton.Name = "SetUpSimulationButton";
            this.SetUpSimulationButton.Size = new System.Drawing.Size(124, 74);
            this.SetUpSimulationButton.TabIndex = 0;
            this.SetUpSimulationButton.Text = "Настройка симуляции";
            this.SetUpSimulationButton.UseVisualStyleBackColor = true;
            this.SetUpSimulationButton.Click += new System.EventHandler(this.SetUpSimulationButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(536, 22);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(124, 74);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Старт/Продолжить движение";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(666, 22);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(124, 74);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // ShowLogButton
            // 
            this.ShowLogButton.Location = new System.Drawing.Point(12, 22);
            this.ShowLogButton.Name = "ShowLogButton";
            this.ShowLogButton.Size = new System.Drawing.Size(124, 74);
            this.ShowLogButton.TabIndex = 3;
            this.ShowLogButton.Text = "Журнал";
            this.ShowLogButton.UseVisualStyleBackColor = true;
            // 
            // TransportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowLogButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SetUpSimulationButton);
            this.Name = "TransportView";
            this.Text = "Transport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetUpSimulationButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ShowLogButton;
    }
}

