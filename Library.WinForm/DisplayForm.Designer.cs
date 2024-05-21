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
            searchByMemberIDButton = new Button();
            displayEveryItemButton = new Button();
            clearListBoxButton = new Button();
            label1 = new Label();
            contentsTitleTextBox = new TextBox();
            contentsTypeComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            removeContentButton = new Button();
            addContentsButton = new Button();
            libraryItemsDataGridView = new DataGridView();
            searchByMemberIDTextBox = new TextBox();
            label5 = new Label();
            libraryContentToRemoveDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)libraryItemsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryContentToRemoveDataGridView).BeginInit();
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
            // searchByMemberIDButton
            // 
            searchByMemberIDButton.Location = new Point(206, 299);
            searchByMemberIDButton.Name = "searchByMemberIDButton";
            searchByMemberIDButton.Size = new Size(51, 23);
            searchByMemberIDButton.TabIndex = 3;
            searchByMemberIDButton.Text = "Search";
            searchByMemberIDButton.UseVisualStyleBackColor = true;
            // 
            // displayEveryItemButton
            // 
            displayEveryItemButton.Location = new Point(309, 299);
            displayEveryItemButton.Name = "displayEveryItemButton";
            displayEveryItemButton.Size = new Size(75, 23);
            displayEveryItemButton.TabIndex = 4;
            displayEveryItemButton.Text = "Display All";
            displayEveryItemButton.UseVisualStyleBackColor = true;
            // 
            // clearListBoxButton
            // 
            clearListBoxButton.Location = new Point(390, 298);
            clearListBoxButton.Name = "clearListBoxButton";
            clearListBoxButton.Size = new Size(75, 23);
            clearListBoxButton.TabIndex = 5;
            clearListBoxButton.Text = "Clear";
            clearListBoxButton.UseVisualStyleBackColor = true;
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
            // contentsTitleTextBox
            // 
            contentsTitleTextBox.Location = new Point(114, 404);
            contentsTitleTextBox.Name = "contentsTitleTextBox";
            contentsTitleTextBox.Size = new Size(184, 23);
            contentsTitleTextBox.TabIndex = 7;
            // 
            // contentsTypeComboBox
            // 
            contentsTypeComboBox.FormattingEnabled = true;
            contentsTypeComboBox.Location = new Point(114, 433);
            contentsTypeComboBox.Name = "contentsTypeComboBox";
            contentsTypeComboBox.Size = new Size(184, 23);
            contentsTypeComboBox.TabIndex = 8;
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
            label4.Location = new Point(521, 9);
            label4.Name = "label4";
            label4.Size = new Size(466, 54);
            label4.TabIndex = 11;
            label4.Text = "Remove Library Contents";
            // 
            // removeContentButton
            // 
            removeContentButton.Location = new Point(912, 299);
            removeContentButton.Name = "removeContentButton";
            removeContentButton.Size = new Size(75, 23);
            removeContentButton.TabIndex = 13;
            removeContentButton.Text = "Remove";
            removeContentButton.UseVisualStyleBackColor = true;
            // 
            // addContentsButton
            // 
            addContentsButton.Location = new Point(321, 433);
            addContentsButton.Name = "addContentsButton";
            addContentsButton.Size = new Size(75, 23);
            addContentsButton.TabIndex = 14;
            addContentsButton.Text = "Add";
            addContentsButton.UseVisualStyleBackColor = true;
            // 
            // libraryItemsDataGridView
            // 
            libraryItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            libraryItemsDataGridView.Location = new Point(12, 64);
            libraryItemsDataGridView.Name = "libraryItemsDataGridView";
            libraryItemsDataGridView.RowTemplate.Height = 25;
            libraryItemsDataGridView.Size = new Size(453, 228);
            libraryItemsDataGridView.TabIndex = 15;
            // 
            // searchByMemberIDTextBox
            // 
            searchByMemberIDTextBox.Location = new Point(79, 299);
            searchByMemberIDTextBox.Name = "searchByMemberIDTextBox";
            searchByMemberIDTextBox.Size = new Size(121, 23);
            searchByMemberIDTextBox.TabIndex = 16;
            searchByMemberIDTextBox.TextChanged += searchByMemberIDTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 303);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 17;
            label5.Text = "ID Number";
            // 
            // libraryContentToRemoveDataGridView
            // 
            libraryContentToRemoveDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            libraryContentToRemoveDataGridView.Location = new Point(534, 64);
            libraryContentToRemoveDataGridView.Name = "libraryContentToRemoveDataGridView";
            libraryContentToRemoveDataGridView.RowTemplate.Height = 25;
            libraryContentToRemoveDataGridView.Size = new Size(453, 228);
            libraryContentToRemoveDataGridView.TabIndex = 18;
            // 
            // DisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 502);
            Controls.Add(libraryContentToRemoveDataGridView);
            Controls.Add(label5);
            Controls.Add(searchByMemberIDTextBox);
            Controls.Add(libraryItemsDataGridView);
            Controls.Add(addContentsButton);
            Controls.Add(removeContentButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(contentsTypeComboBox);
            Controls.Add(contentsTitleTextBox);
            Controls.Add(label1);
            Controls.Add(clearListBoxButton);
            Controls.Add(displayEveryItemButton);
            Controls.Add(searchByMemberIDButton);
            Controls.Add(Title);
            Name = "DisplayForm";
            Text = "DisplayItems";
            ((System.ComponentModel.ISupportInitialize)libraryItemsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)libraryContentToRemoveDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private ListBox displayItemsListBox;
        private Button searchByMemberIDButton;
        private Button displayEveryItemButton;
        private Button clearListBoxButton;
        private Label label1;
        private TextBox contentsTitleTextBox;
        private ComboBox contentsTypeComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button removeContentButton;
        private Button addContentsButton;
        private DataGridView libraryItemsDataGridView;
        private TextBox searchByMemberIDTextBox;
        private Label label5;
        private DataGridView libraryContentToRemoveDataGridView;
    }
}