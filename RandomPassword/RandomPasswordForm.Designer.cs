namespace RandomPassword
{
    partial class RandomPasswordForm
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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PasswordLengthTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BigLetterCheckBox = new System.Windows.Forms.CheckBox();
            this.SmallLetterCheckBox = new System.Windows.Forms.CheckBox();
            this.NumberCheckBox = new System.Windows.Forms.CheckBox();
            this.SpecialCharacterCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(197, 38);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(95, 40);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // PasswordLengthTextBox
            // 
            this.PasswordLengthTextBox.Location = new System.Drawing.Point(184, 6);
            this.PasswordLengthTextBox.Name = "PasswordLengthTextBox";
            this.PasswordLengthTextBox.Size = new System.Drawing.Size(48, 20);
            this.PasswordLengthTextBox.TabIndex = 1;
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.AutoSize = true;
            this.PasswordLengthLabel.Location = new System.Drawing.Point(12, 9);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(166, 13);
            this.PasswordLengthLabel.TabIndex = 2;
            this.PasswordLengthLabel.Text = "Enter Password Length ( max 25 )";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(77, 84);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(215, 20);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 87);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(59, 13);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password :";
            // 
            // BigLetterCheckBox
            // 
            this.BigLetterCheckBox.AutoSize = true;
            this.BigLetterCheckBox.Location = new System.Drawing.Point(12, 38);
            this.BigLetterCheckBox.Name = "BigLetterCheckBox";
            this.BigLetterCheckBox.Size = new System.Drawing.Size(66, 17);
            this.BigLetterCheckBox.TabIndex = 12;
            this.BigLetterCheckBox.Text = "big letter";
            this.BigLetterCheckBox.UseVisualStyleBackColor = true;
            // 
            // SmallLetterCheckBox
            // 
            this.SmallLetterCheckBox.AutoSize = true;
            this.SmallLetterCheckBox.Location = new System.Drawing.Point(84, 38);
            this.SmallLetterCheckBox.Name = "SmallLetterCheckBox";
            this.SmallLetterCheckBox.Size = new System.Drawing.Size(75, 17);
            this.SmallLetterCheckBox.TabIndex = 13;
            this.SmallLetterCheckBox.Text = "small letter";
            this.SmallLetterCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumberCheckBox
            // 
            this.NumberCheckBox.AutoSize = true;
            this.NumberCheckBox.Location = new System.Drawing.Point(12, 61);
            this.NumberCheckBox.Name = "NumberCheckBox";
            this.NumberCheckBox.Size = new System.Drawing.Size(61, 17);
            this.NumberCheckBox.TabIndex = 15;
            this.NumberCheckBox.Text = "number";
            this.NumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCharacterCheckBox
            // 
            this.SpecialCharacterCheckBox.AutoSize = true;
            this.SpecialCharacterCheckBox.Location = new System.Drawing.Point(84, 61);
            this.SpecialCharacterCheckBox.Name = "SpecialCharacterCheckBox";
            this.SpecialCharacterCheckBox.Size = new System.Drawing.Size(107, 17);
            this.SpecialCharacterCheckBox.TabIndex = 16;
            this.SpecialCharacterCheckBox.Text = "special character";
            this.SpecialCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 111);
            this.Controls.Add(this.SpecialCharacterCheckBox);
            this.Controls.Add(this.NumberCheckBox);
            this.Controls.Add(this.SmallLetterCheckBox);
            this.Controls.Add(this.BigLetterCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLengthLabel);
            this.Controls.Add(this.PasswordLengthTextBox);
            this.Controls.Add(this.GenerateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RandomPasswordForm";
            this.Text = "RandomPasswordApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox PasswordLengthTextBox;
        private System.Windows.Forms.Label PasswordLengthLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox BigLetterCheckBox;
        private System.Windows.Forms.CheckBox SmallLetterCheckBox;
        private System.Windows.Forms.CheckBox NumberCheckBox;
        private System.Windows.Forms.CheckBox SpecialCharacterCheckBox;
    }
}

