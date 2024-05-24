namespace Library.WinForm
{
    partial class BorrowForm
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
            borrowGroupBox = new GroupBox();
            borrowBtn = new Button();
            borrowComboBox = new ComboBox();
            returnGroupBox = new GroupBox();
            returnButton = new Button();
            comboBox2 = new ComboBox();
            renewGroupBox = new GroupBox();
            renewButton = new Button();
            renewComboBox = new ComboBox();
            goToDisplayFormButton = new Button();
            borrowGroupBox.SuspendLayout();
            returnGroupBox.SuspendLayout();
            renewGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // borrowGroupBox
            // 
            borrowGroupBox.Controls.Add(borrowBtn);
            borrowGroupBox.Controls.Add(borrowComboBox);
            borrowGroupBox.Location = new Point(21, 26);
            borrowGroupBox.Name = "borrowGroupBox";
            borrowGroupBox.Size = new Size(350, 90);
            borrowGroupBox.TabIndex = 0;
            borrowGroupBox.TabStop = false;
            borrowGroupBox.Text = "Borrow an item";
            borrowGroupBox.Enter += borrowGroupBox_Enter;
            // 
            // borrowBtn
            // 
            borrowBtn.Location = new Point(6, 51);
            borrowBtn.Name = "borrowBtn";
            borrowBtn.Size = new Size(221, 23);
            borrowBtn.TabIndex = 1;
            borrowBtn.Text = "Borrow item";
            borrowBtn.UseVisualStyleBackColor = true;
            // 
            // borrowComboBox
            // 
            borrowComboBox.FormattingEnabled = true;
            borrowComboBox.Location = new Point(6, 22);
            borrowComboBox.Name = "borrowComboBox";
            borrowComboBox.Size = new Size(221, 23);
            borrowComboBox.TabIndex = 0;
            // 
            // returnGroupBox
            // 
            returnGroupBox.Controls.Add(returnButton);
            returnGroupBox.Controls.Add(comboBox2);
            returnGroupBox.Location = new Point(21, 148);
            returnGroupBox.Name = "returnGroupBox";
            returnGroupBox.Size = new Size(350, 90);
            returnGroupBox.TabIndex = 1;
            returnGroupBox.TabStop = false;
            returnGroupBox.Text = "Return an item";
            // 
            // returnButton
            // 
            returnButton.Location = new Point(6, 51);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(221, 23);
            returnButton.TabIndex = 2;
            returnButton.Text = "Return item";
            returnButton.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 23);
            comboBox2.TabIndex = 2;
            // 
            // renewGroupBox
            // 
            renewGroupBox.Controls.Add(renewButton);
            renewGroupBox.Controls.Add(renewComboBox);
            renewGroupBox.Location = new Point(21, 268);
            renewGroupBox.Name = "renewGroupBox";
            renewGroupBox.Size = new Size(350, 90);
            renewGroupBox.TabIndex = 2;
            renewGroupBox.TabStop = false;
            renewGroupBox.Text = "Renew an item";
            // 
            // renewButton
            // 
            renewButton.Location = new Point(6, 51);
            renewButton.Name = "renewButton";
            renewButton.Size = new Size(221, 23);
            renewButton.TabIndex = 3;
            renewButton.Text = "Renew item";
            renewButton.UseVisualStyleBackColor = true;
            // 
            // renewComboBox
            // 
            renewComboBox.FormattingEnabled = true;
            renewComboBox.Location = new Point(6, 22);
            renewComboBox.Name = "renewComboBox";
            renewComboBox.Size = new Size(221, 23);
            renewComboBox.TabIndex = 3;
            // 
            // goToDisplayFormButton
            // 
            goToDisplayFormButton.Location = new Point(21, 387);
            goToDisplayFormButton.Name = "goToDisplayFormButton";
            goToDisplayFormButton.Size = new Size(350, 23);
            goToDisplayFormButton.TabIndex = 3;
            goToDisplayFormButton.Text = "<<< Display content";
            goToDisplayFormButton.UseVisualStyleBackColor = true;
            // 
            // BorrowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 450);
            Controls.Add(goToDisplayFormButton);
            Controls.Add(renewGroupBox);
            Controls.Add(returnGroupBox);
            Controls.Add(borrowGroupBox);
            Name = "BorrowForm";
            Text = "Borrow, Renew, Return";
            borrowGroupBox.ResumeLayout(false);
            returnGroupBox.ResumeLayout(false);
            renewGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox borrowGroupBox;
        private Label label1;
        private Button borrowBtn;
        private ComboBox borrowComboBox;
        private GroupBox returnGroupBox;
        private Button returnButton;
        private ComboBox comboBox2;
        private GroupBox renewGroupBox;
        private Button renewButton;
        private ComboBox renewComboBox;
        private Button goToDisplayFormButton;
    }
}