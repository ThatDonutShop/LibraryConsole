namespace Library.WinForm
{
    partial class DisplayForm
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
            Title = new Label();
            DisplayItemsListBox = new ListBox();
            MemberSelectionComboBox = new ComboBox();
            BorrowingsDisplayButton = new Button();
            DisplayEveryItemButton = new Button();
            ClearListBoxButton = new Button();
            label1 = new Label();
            ContentsTitleTextBox = new TextBox();
            ContentsTypeComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LibraryContentsComboBox = new ComboBox();
            RemoveContentButton = new Button();
            AddContentsButton = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(12, 7);
            Title.Name = "Title";
            Title.Size = new Size(151, 54);
            Title.TabIndex = 0;
            Title.Text = "Display";
            // 
            // DisplayItemsListBox
            // 
            DisplayItemsListBox.FormattingEnabled = true;
            DisplayItemsListBox.ItemHeight = 15;
            DisplayItemsListBox.Location = new Point(12, 78);
            DisplayItemsListBox.Name = "DisplayItemsListBox";
            DisplayItemsListBox.Size = new Size(453, 214);
            DisplayItemsListBox.TabIndex = 1;
            // 
            // MemberSelectionComboBox
            // 
            MemberSelectionComboBox.FormattingEnabled = true;
            MemberSelectionComboBox.Location = new Point(12, 299);
            MemberSelectionComboBox.Name = "MemberSelectionComboBox";
            MemberSelectionComboBox.Size = new Size(121, 23);
            MemberSelectionComboBox.TabIndex = 2;
            // 
            // BorrowingsDisplayButton
            // 
            BorrowingsDisplayButton.Location = new Point(139, 299);
            BorrowingsDisplayButton.Name = "BorrowingsDisplayButton";
            BorrowingsDisplayButton.Size = new Size(75, 23);
            BorrowingsDisplayButton.TabIndex = 3;
            BorrowingsDisplayButton.Text = "Display";
            BorrowingsDisplayButton.UseVisualStyleBackColor = true;
            // 
            // DisplayEveryItemButton
            // 
            DisplayEveryItemButton.Location = new Point(309, 299);
            DisplayEveryItemButton.Name = "DisplayEveryItemButton";
            DisplayEveryItemButton.Size = new Size(75, 23);
            DisplayEveryItemButton.TabIndex = 4;
            DisplayEveryItemButton.Text = "Display All";
            DisplayEveryItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearListBoxButton
            // 
            ClearListBoxButton.Location = new Point(390, 298);
            ClearListBoxButton.Name = "ClearListBoxButton";
            ClearListBoxButton.Size = new Size(75, 23);
            ClearListBoxButton.TabIndex = 5;
            ClearListBoxButton.Text = "Clear";
            ClearListBoxButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 347);
            label1.Name = "label1";
            label1.Size = new Size(399, 54);
            label1.TabIndex = 6;
            label1.Text = "Add Library Contents";
            // 
            // ContentsTitleTextBox
            // 
            ContentsTitleTextBox.Location = new Point(114, 404);
            ContentsTitleTextBox.Name = "ContentsTitleTextBox";
            ContentsTitleTextBox.Size = new Size(184, 23);
            ContentsTitleTextBox.TabIndex = 7;
            // 
            // ContentsTypeComboBox
            // 
            ContentsTypeComboBox.FormattingEnabled = true;
            ContentsTypeComboBox.Location = new Point(114, 433);
            ContentsTypeComboBox.Name = "ContentsTypeComboBox";
            ContentsTypeComboBox.Size = new Size(184, 23);
            ContentsTypeComboBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 407);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 9;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 436);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 10;
            label3.Text = "Content Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 459);
            label4.Name = "label4";
            label4.Size = new Size(466, 54);
            label4.TabIndex = 11;
            label4.Text = "Remove Library Contents";
            // 
            // LibraryContentsComboBox
            // 
            LibraryContentsComboBox.FormattingEnabled = true;
            LibraryContentsComboBox.Location = new Point(12, 516);
            LibraryContentsComboBox.Name = "LibraryContentsComboBox";
            LibraryContentsComboBox.Size = new Size(286, 23);
            LibraryContentsComboBox.TabIndex = 12;
            // 
            // RemoveContentButton
            // 
            RemoveContentButton.Location = new Point(321, 515);
            RemoveContentButton.Name = "RemoveContentButton";
            RemoveContentButton.Size = new Size(75, 23);
            RemoveContentButton.TabIndex = 13;
            RemoveContentButton.Text = "Remove";
            RemoveContentButton.UseVisualStyleBackColor = true;
            // 
            // AddContentsButton
            // 
            AddContentsButton.Location = new Point(321, 433);
            AddContentsButton.Name = "AddContentsButton";
            AddContentsButton.Size = new Size(75, 23);
            AddContentsButton.TabIndex = 14;
            AddContentsButton.Text = "Add";
            AddContentsButton.UseVisualStyleBackColor = true;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 573);
            Controls.Add(AddContentsButton);
            Controls.Add(RemoveContentButton);
            Controls.Add(LibraryContentsComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ContentsTypeComboBox);
            Controls.Add(ContentsTitleTextBox);
            Controls.Add(label1);
            Controls.Add(ClearListBoxButton);
            Controls.Add(DisplayEveryItemButton);
            Controls.Add(BorrowingsDisplayButton);
            Controls.Add(MemberSelectionComboBox);
            Controls.Add(DisplayItemsListBox);
            Controls.Add(Title);
            Name = "DisplayForm";
            Text = "DisplayItems";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private ListBox DisplayItemsListBox;
        private ComboBox MemberSelectionComboBox;
        private Button BorrowingsDisplayButton;
        private Button DisplayEveryItemButton;
        private Button ClearListBoxButton;
        private Label label1;
        private TextBox ContentsTitleTextBox;
        private ComboBox ContentsTypeComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox LibraryContentsComboBox;
        private Button RemoveContentButton;
        private Button AddContentsButton;
    }
}