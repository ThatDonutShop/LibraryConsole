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
            components = new System.ComponentModel.Container();
            LoginTitleLabel = new Label();
            registerAccountButton = new Button();
            LoginPasswordLabel = new Label();
            LoginEmailAddressLabel = new Label();
            passwordTextBox = new TextBox();
            emailAddressTextBox = new TextBox();
            loginButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            // registerAccountButton
            // 
            registerAccountButton.Location = new Point(65, 239);
            registerAccountButton.Name = "registerAccountButton";
            registerAccountButton.Size = new Size(209, 23);
            registerAccountButton.TabIndex = 10;
            registerAccountButton.Text = "Don't have an account?";
            registerAccountButton.UseVisualStyleBackColor = true;
            registerAccountButton.Click += registerAccountButton_Click;
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
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(153, 159);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(121, 23);
            passwordTextBox.TabIndex = 7;
            // 
            // emailAddressTextBox
            // 
            emailAddressTextBox.Location = new Point(153, 130);
            emailAddressTextBox.Name = "emailAddressTextBox";
            emailAddressTextBox.Size = new Size(121, 23);
            emailAddressTextBox.TabIndex = 6;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(65, 210);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(209, 23);
            loginButton.TabIndex = 12;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 361);
            Controls.Add(loginButton);
            Controls.Add(LoginTitleLabel);
            Controls.Add(registerAccountButton);
            Controls.Add(LoginPasswordLabel);
            Controls.Add(LoginEmailAddressLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(emailAddressTextBox);
            Name = "LoginForm";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginTitleLabel;
        private Button registerAccountButton;
        private Label LoginPasswordLabel;
        private Label LoginEmailAddressLabel;
        private TextBox passwordTextBox;
        private TextBox emailAddressTextBox;
        private Button loginButton;
        private ErrorProvider errorProvider1;
    }
}
