namespace AdventureGame
{
    partial class Form1
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
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.redButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Location = new System.Drawing.Point(12, 373);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(234, 65);
            this.redButton.TabIndex = 0;
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.blueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Location = new System.Drawing.Point(284, 373);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(234, 65);
            this.blueButton.TabIndex = 1;
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(554, 373);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(234, 65);
            this.nextButton.TabIndex = 2;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outputLabel.Location = new System.Drawing.Point(13, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(274, 357);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "label1";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.imageLabel.Location = new System.Drawing.Point(294, 13);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(35, 13);
            this.imageLabel.TabIndex = 4;
            this.imageLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label imageLabel;
    }
}

