namespace FindANumber
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LifesInfoLabel = new System.Windows.Forms.Label();
            this.LifeNumberLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.FinddingLable = new System.Windows.Forms.Label();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.CheckedNumberTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.FinddingLable);
            this.panel1.Controls.Add(this.SummaryLabel);
            this.panel1.Controls.Add(this.CheckedNumberTextBox);
            this.panel1.Controls.Add(this.CheckButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 300);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LifesInfoLabel);
            this.panel2.Controls.Add(this.LifeNumberLabel);
            this.panel2.Location = new System.Drawing.Point(230, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 42);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // LifesInfoLabel
            // 
            this.LifesInfoLabel.AutoSize = true;
            this.LifesInfoLabel.Location = new System.Drawing.Point(3, 14);
            this.LifesInfoLabel.Name = "LifesInfoLabel";
            this.LifesInfoLabel.Size = new System.Drawing.Size(89, 15);
            this.LifesInfoLabel.TabIndex = 3;
            this.LifesInfoLabel.Text = "Pozostało prób:";
            // 
            // LifeNumberLabel
            // 
            this.LifeNumberLabel.AutoSize = true;
            this.LifeNumberLabel.Location = new System.Drawing.Point(98, 14);
            this.LifeNumberLabel.Name = "LifeNumberLabel";
            this.LifeNumberLabel.Size = new System.Drawing.Size(38, 15);
            this.LifeNumberLabel.TabIndex = 1;
            this.LifeNumberLabel.Text = "label3";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(65, 72);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(123, 51);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FinddingLable
            // 
            this.FinddingLable.AutoSize = true;
            this.FinddingLable.Location = new System.Drawing.Point(56, 156);
            this.FinddingLable.Name = "FinddingLable";
            this.FinddingLable.Size = new System.Drawing.Size(132, 15);
            this.FinddingLable.TabIndex = 1;
            this.FinddingLable.Text = "Wpisz liczbę od 1 do 20:";
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryLabel.Location = new System.Drawing.Point(101, 212);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(183, 32);
            this.SummaryLabel.TabIndex = 1;
            this.SummaryLabel.Text = "SummaryLabel";
            this.SummaryLabel.Visible = false;
            // 
            // CheckedNumberTextBox
            // 
            this.CheckedNumberTextBox.Location = new System.Drawing.Point(190, 153);
            this.CheckedNumberTextBox.Name = "CheckedNumberTextBox";
            this.CheckedNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.CheckedNumberTextBox.TabIndex = 0;
            // 
            // CheckButton
            // 
            this.CheckButton.Enabled = false;
            this.CheckButton.Location = new System.Drawing.Point(296, 153);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Sprawdź!";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 300);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(539, 339);
            this.MinimumSize = new System.Drawing.Size(539, 339);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label FinddingLable;
        private TextBox CheckedNumberTextBox;
        private Label SummaryLabel;
        private Button CheckButton;
        private Button StartButton;
        private Label LifeNumberLabel;
        private Label LifesInfoLabel;
        private Panel panel2;
    }
}