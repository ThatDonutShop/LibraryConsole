namespace Library.WinForm
{
    partial class RegisterForm
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
            RegisterTitleLabel = new Label();
            RegisterAlreadyHaveAccountButton = new Button();
            RegisterPasswordLabel = new Label();
            RegisterEmailAddressLabel = new Label();
            RegisterPasswordTextBox = new TextBox();
            RegisterEmailAddressTextBox = new TextBox();
            RegisterFirstNameLabel = new Label();
            RegisterFirstNameTextBox = new TextBox();
            RegisterLastNameLabel = new Label();
            RegisterLastNameTextBox = new TextBox();
            RegisterAccountTypeCombo = new ComboBox();
            RegisterAccountTypeLabel = new Label();
            RegisterAccountButton = new Button();
            SuspendLayout();
            // 
            // RegisterTitleLabel
            // 
            RegisterTitleLabel.AutoSize = true;
            RegisterTitleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterTitleLabel.Location = new Point(109, 43);
            RegisterTitleLabel.Name = "RegisterTitleLabel";
            RegisterTitleLabel.Size = new Size(125, 41);
            RegisterTitleLabel.TabIndex = 17;
            RegisterTitleLabel.Text = "Register";
            // 
            // RegisterAlreadyHaveAccountButton
            // 
            RegisterAlreadyHaveAccountButton.Location = new Point(69, 296);
            RegisterAlreadyHaveAccountButton.Name = "RegisterAlreadyHaveAccountButton";
            RegisterAlreadyHaveAccountButton.Size = new Size(209, 23);
            RegisterAlreadyHaveAccountButton.TabIndex = 16;
            RegisterAlreadyHaveAccountButton.Text = "Have an account? Click here to login";
            RegisterAlreadyHaveAccountButton.UseVisualStyleBackColor = true;
            // 
            // RegisterPasswordLabel
            // 
            RegisterPasswordLabel.AutoSize = true;
            RegisterPasswordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterPasswordLabel.Location = new Point(81, 203);
            RegisterPasswordLabel.Name = "RegisterPasswordLabel";
            RegisterPasswordLabel.Size = new Size(70, 19);
            RegisterPasswordLabel.TabIndex = 15;
            RegisterPasswordLabel.Text = "Password:";
            // 
            // RegisterEmailAddressLabel
            // 
            RegisterEmailAddressLabel.AutoSize = true;
            RegisterEmailAddressLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterEmailAddressLabel.Location = new Point(56, 173);
            RegisterEmailAddressLabel.Name = "RegisterEmailAddressLabel";
            RegisterEmailAddressLabel.Size = new Size(95, 19);
            RegisterEmailAddressLabel.TabIndex = 14;
            RegisterEmailAddressLabel.Text = "Email address:";
            // 
            // RegisterPasswordTextBox
            // 
            RegisterPasswordTextBox.Location = new Point(157, 202);
            RegisterPasswordTextBox.Name = "RegisterPasswordTextBox";
            RegisterPasswordTextBox.Size = new Size(121, 23);
            RegisterPasswordTextBox.TabIndex = 13;
            // 
            // RegisterEmailAddressTextBox
            // 
            RegisterEmailAddressTextBox.Location = new Point(157, 173);
            RegisterEmailAddressTextBox.Name = "RegisterEmailAddressTextBox";
            RegisterEmailAddressTextBox.Size = new Size(121, 23);
            RegisterEmailAddressTextBox.TabIndex = 12;
            // 
            // RegisterFirstNameLabel
            // 
            RegisterFirstNameLabel.AutoSize = true;
            RegisterFirstNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterFirstNameLabel.Location = new Point(75, 116);
            RegisterFirstNameLabel.Name = "RegisterFirstNameLabel";
            RegisterFirstNameLabel.Size = new Size(76, 19);
            RegisterFirstNameLabel.TabIndex = 19;
            RegisterFirstNameLabel.Text = "First name:";
            // 
            // RegisterFirstNameTextBox
            // 
            RegisterFirstNameTextBox.Location = new Point(157, 115);
            RegisterFirstNameTextBox.Name = "RegisterFirstNameTextBox";
            RegisterFirstNameTextBox.Size = new Size(121, 23);
            RegisterFirstNameTextBox.TabIndex = 18;
            RegisterFirstNameTextBox.TextChanged += textBox3_TextChanged;
            // 
            // RegisterLastNameLabel
            // 
            RegisterLastNameLabel.AutoSize = true;
            RegisterLastNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterLastNameLabel.Location = new Point(76, 145);
            RegisterLastNameLabel.Name = "RegisterLastNameLabel";
            RegisterLastNameLabel.Size = new Size(75, 19);
            RegisterLastNameLabel.TabIndex = 21;
            RegisterLastNameLabel.Text = "Last name:";
            // 
            // RegisterLastNameTextBox
            // 
            RegisterLastNameTextBox.Location = new Point(157, 144);
            RegisterLastNameTextBox.Name = "RegisterLastNameTextBox";
            RegisterLastNameTextBox.Size = new Size(121, 23);
            RegisterLastNameTextBox.TabIndex = 22;
            // 
            // RegisterAccountTypeCombo
            // 
            RegisterAccountTypeCombo.FormattingEnabled = true;
            RegisterAccountTypeCombo.Location = new Point(157, 231);
            RegisterAccountTypeCombo.Name = "RegisterAccountTypeCombo";
            RegisterAccountTypeCombo.Size = new Size(121, 23);
            RegisterAccountTypeCombo.TabIndex = 23;
            // 
            // RegisterAccountTypeLabel
            // 
            RegisterAccountTypeLabel.AutoSize = true;
            RegisterAccountTypeLabel.Location = new Point(69, 234);
            RegisterAccountTypeLabel.Name = "RegisterAccountTypeLabel";
            RegisterAccountTypeLabel.Size = new Size(82, 15);
            RegisterAccountTypeLabel.TabIndex = 24;
            RegisterAccountTypeLabel.Text = "Account Type:";
            // 
            // RegisterAccountButton
            // 
            RegisterAccountButton.Location = new Point(69, 267);
            RegisterAccountButton.Name = "RegisterAccountButton";
            RegisterAccountButton.Size = new Size(209, 23);
            RegisterAccountButton.TabIndex = 25;
            RegisterAccountButton.Text = "Register";
            RegisterAccountButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 361);
            Controls.Add(RegisterAccountButton);
            Controls.Add(RegisterAccountTypeLabel);
            Controls.Add(RegisterAccountTypeCombo);
            Controls.Add(RegisterLastNameTextBox);
            Controls.Add(RegisterLastNameLabel);
            Controls.Add(RegisterFirstNameLabel);
            Controls.Add(RegisterFirstNameTextBox);
            Controls.Add(RegisterTitleLabel);
            Controls.Add(RegisterAlreadyHaveAccountButton);
            Controls.Add(RegisterPasswordLabel);
            Controls.Add(RegisterEmailAddressLabel);
            Controls.Add(RegisterPasswordTextBox);
            Controls.Add(RegisterEmailAddressTextBox);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegisterTitleLabel;
        private Button RegisterAlreadyHaveAccountButton;
        private Label RegisterPasswordLabel;
        private Label RegisterEmailAddressLabel;
        private TextBox RegisterPasswordTextBox;
        private TextBox RegisterEmailAddressTextBox;
        private Label RegisterFirstNameLabel;
        private TextBox RegisterFirstNameTextBox;
        private Label RegisterLastNameLabel;
        private TextBox RegisterLastNameTextBox;
        private ComboBox RegisterAccountTypeCombo;
        private Label RegisterAccountTypeLabel;
        private Button RegisterAccountButton;
    }
}