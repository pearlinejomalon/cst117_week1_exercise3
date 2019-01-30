namespace Exercise3
{
    partial class MainForm
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
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.fahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Location = new System.Drawing.Point(9, 125);
            this.celsiusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(97, 13);
            this.celsiusLabel.TabIndex = 2;
            this.celsiusLabel.Text = "Degrees in Celsius:";
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.AutoSize = true;
            this.fahrenheitLabel.Location = new System.Drawing.Point(10, 58);
            this.fahrenheitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(114, 13);
            this.fahrenheitLabel.TabIndex = 0;
            this.fahrenheitLabel.Text = "Degrees in Fahrenheit:";
            // 
            // fahrenheitTextBox
            // 
            this.fahrenheitTextBox.Location = new System.Drawing.Point(150, 56);
            this.fahrenheitTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fahrenheitTextBox.Name = "fahrenheitTextBox";
            this.fahrenheitTextBox.Size = new System.Drawing.Size(102, 20);
            this.fahrenheitTextBox.TabIndex = 1;
            this.fahrenheitTextBox.TextChanged += new System.EventHandler(this.fahrenheitTextBox_TextChanged);
          
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Location = new System.Drawing.Point(150, 123);
            this.celsiusTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(102, 20);
            this.celsiusTextBox.TabIndex = 3;
            this.celsiusTextBox.TextChanged += new System.EventHandler(this.celsiusTextBox_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(70, 175);
            this.convertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 27);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(220, 175);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 27);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 211);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.celsiusTextBox);
            this.Controls.Add(this.fahrenheitTextBox);
            this.Controls.Add(this.fahrenheitLabel);
            this.Controls.Add(this.celsiusLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Fahrenheit to Celsius Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label celsiusLabel;
        private System.Windows.Forms.Label fahrenheitLabel;
        private System.Windows.Forms.TextBox fahrenheitTextBox;
        private System.Windows.Forms.TextBox celsiusTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button closeButton;
    }
}

