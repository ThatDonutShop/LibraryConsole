namespace Library.WinForm
{
    partial class LoginForm
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
            LoginTitleLabel = new Label();
            button1 = new Button();
            LoginPasswordLabel = new Label();
            LoginEmailAddressLabel = new Label();
            LoginPasswordTextBox = new TextBox();
            LoginEmailAddressTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // LoginTitleLabel
            // 
            LoginTitleLabel.AutoSize = true;
            LoginTitleLabel.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTitleLabel.Location = new Point(128, 68);
            LoginTitleLabel.Name = "LoginTitleLabel";
            LoginTitleLabel.Size = new Size(92, 41);
            LoginTitleLabel.TabIndex = 11;
            LoginTitleLabel.Text = "Login";
            // 
            // button1
            // 
            button1.Location = new Point(65, 239);
            button1.Name = "button1";
            button1.Size = new Size(209, 23);
            button1.TabIndex = 10;
            button1.Text = "Don't have an account? Click here to register";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LoginPasswordLabel.Location = new Point(77, 160);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(70, 19);
            LoginPasswordLabel.TabIndex = 9;
            LoginPasswordLabel.Text = "Password:";
            // 
            // LoginEmailAddressLabel
            // 
            LoginEmailAddressLabel.AutoSize = true;
            LoginEmailAddressLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LoginEmailAddressLabel.Location = new Point(52, 131);
            LoginEmailAddressLabel.Name = "LoginEmailAddressLabel";
            LoginEmailAddressLabel.Size = new Size(95, 19);
            LoginEmailAddressLabel.TabIndex = 8;
            LoginEmailAddressLabel.Text = "Email address:";
            // 
            // LoginPasswordTextBox
            // 
            LoginPasswordTextBox.Location = new Point(153, 159);
            LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            LoginPasswordTextBox.Size = new Size(121, 23);
            LoginPasswordTextBox.TabIndex = 7;
            // 
            // LoginEmailAddressTextBox
            // 
            LoginEmailAddressTextBox.Location = new Point(153, 130);
            LoginEmailAddressTextBox.Name = "LoginEmailAddressTextBox";
            LoginEmailAddressTextBox.Size = new Size(121, 23);
            LoginEmailAddressTextBox.TabIndex = 6;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(65, 210);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(209, 23);
            LoginButton.TabIndex = 12;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 361);
            Controls.Add(LoginButton);
            Controls.Add(LoginTitleLabel);
            Controls.Add(button1);
            Controls.Add(LoginPasswordLabel);
            Controls.Add(LoginEmailAddressLabel);
            Controls.Add(LoginPasswordTextBox);
            Controls.Add(LoginEmailAddressTextBox);
            Name = "LoginForm";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginTitleLabel;
        private Button button1;
        private Label LoginPasswordLabel;
        private Label LoginEmailAddressLabel;
        private TextBox LoginPasswordTextBox;
        private TextBox LoginEmailAddressTextBox;
        private Button LoginButton;
    }
}
