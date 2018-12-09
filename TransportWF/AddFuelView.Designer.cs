namespace TransportWF
{
    partial class AddFuelView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddFuelButton = new System.Windows.Forms.Button();
            this.ListFuelTextBox = new System.Windows.Forms.TextBox();
            this.NewFuelTextBox = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ErrorLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddFuelButton);
            this.panel1.Controls.Add(this.ListFuelTextBox);
            this.panel1.Controls.Add(this.NewFuelTextBox);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 378);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "имеющееся в списке топливо";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите топливо которое хотите добавить";
            // 
            // AddFuelButton
            // 
            this.AddFuelButton.Location = new System.Drawing.Point(61, 325);
            this.AddFuelButton.Name = "AddFuelButton";
            this.AddFuelButton.Size = new System.Drawing.Size(178, 23);
            this.AddFuelButton.TabIndex = 2;
            this.AddFuelButton.Text = "Добавить";
            this.AddFuelButton.UseVisualStyleBackColor = true;
            this.AddFuelButton.Click += new System.EventHandler(this.AddFuelButton_Click);
            // 
            // ListFuelTextBox
            // 
            this.ListFuelTextBox.Location = new System.Drawing.Point(44, 124);
            this.ListFuelTextBox.Multiline = true;
            this.ListFuelTextBox.Name = "ListFuelTextBox";
            this.ListFuelTextBox.Size = new System.Drawing.Size(216, 173);
            this.ListFuelTextBox.TabIndex = 1;
            // 
            // NewFuelTextBox
            // 
            this.NewFuelTextBox.Location = new System.Drawing.Point(44, 47);
            this.NewFuelTextBox.Name = "NewFuelTextBox";
            this.NewFuelTextBox.Size = new System.Drawing.Size(216, 20);
            this.NewFuelTextBox.TabIndex = 0;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(71, 74);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 5;
            // 
            // AddFuelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 373);
            this.Controls.Add(this.panel1);
            this.Name = "AddFuelView";
            this.Text = "AddFuelView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddFuelButton;
        private System.Windows.Forms.TextBox ListFuelTextBox;
        private System.Windows.Forms.TextBox NewFuelTextBox;
        private System.Windows.Forms.Label ErrorLabel;
    }
}