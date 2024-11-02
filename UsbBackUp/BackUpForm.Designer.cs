namespace UsbBackUp
{
    partial class BackUpForm
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
            backupButton = new Button();
            selectDestinationLabel = new Label();
            selectDestinationTextBox = new TextBox();
            selectDestinationButton = new Button();
            selectFolderLabel = new Label();
            selectFolderTextBox = new TextBox();
            selectFolderButton = new Button();
            selectFolderDialog = new FolderBrowserDialog();
            selectDestinationDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // backupButton
            // 
            backupButton.Location = new Point(148, 152);
            backupButton.Name = "backupButton";
            backupButton.Size = new Size(116, 46);
            backupButton.TabIndex = 13;
            backupButton.Text = "Backup";
            backupButton.UseVisualStyleBackColor = true;
            // 
            // selectDestinationLabel
            // 
            selectDestinationLabel.AutoSize = true;
            selectDestinationLabel.Location = new Point(14, 81);
            selectDestinationLabel.Margin = new Padding(4, 0, 4, 4);
            selectDestinationLabel.Name = "selectDestinationLabel";
            selectDestinationLabel.Size = new Size(98, 15);
            selectDestinationLabel.TabIndex = 10;
            selectDestinationLabel.Text = "Vælg destination:";
            // 
            // selectDestinationTextBox
            // 
            selectDestinationTextBox.Location = new Point(14, 110);
            selectDestinationTextBox.Margin = new Padding(4, 4, 4, 10);
            selectDestinationTextBox.Name = "selectDestinationTextBox";
            selectDestinationTextBox.Size = new Size(345, 23);
            selectDestinationTextBox.TabIndex = 11;
            // 
            // selectDestinationButton
            // 
            selectDestinationButton.Location = new Point(367, 110);
            selectDestinationButton.Margin = new Padding(4, 4, 4, 10);
            selectDestinationButton.Name = "selectDestinationButton";
            selectDestinationButton.Size = new Size(28, 29);
            selectDestinationButton.TabIndex = 12;
            selectDestinationButton.Text = "...";
            selectDestinationButton.UseVisualStyleBackColor = true;
            // 
            // selectFolderLabel
            // 
            selectFolderLabel.AutoSize = true;
            selectFolderLabel.Location = new Point(14, 13);
            selectFolderLabel.Margin = new Padding(4, 0, 4, 4);
            selectFolderLabel.Name = "selectFolderLabel";
            selectFolderLabel.Size = new Size(76, 15);
            selectFolderLabel.TabIndex = 7;
            selectFolderLabel.Text = "Vælg mappe:";
            // 
            // selectFolderTextBox
            // 
            selectFolderTextBox.Location = new Point(14, 42);
            selectFolderTextBox.Margin = new Padding(4, 4, 4, 10);
            selectFolderTextBox.Name = "selectFolderTextBox";
            selectFolderTextBox.Size = new Size(345, 23);
            selectFolderTextBox.TabIndex = 8;
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(367, 42);
            selectFolderButton.Margin = new Padding(4, 4, 4, 10);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(28, 29);
            selectFolderButton.TabIndex = 9;
            selectFolderButton.Text = "...";
            selectFolderButton.UseVisualStyleBackColor = true;
            // 
            // BackUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 216);
            Controls.Add(backupButton);
            Controls.Add(selectDestinationLabel);
            Controls.Add(selectDestinationTextBox);
            Controls.Add(selectDestinationButton);
            Controls.Add(selectFolderLabel);
            Controls.Add(selectFolderTextBox);
            Controls.Add(selectFolderButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BackUpForm";
            Text = "USB Backup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backupButton;
        private Label selectDestinationLabel;
        private TextBox selectDestinationTextBox;
        private Button selectDestinationButton;
        private Label selectFolderLabel;
        private TextBox selectFolderTextBox;
        private Button selectFolderButton;
        private FolderBrowserDialog selectFolderDialog;
        private FolderBrowserDialog selectDestinationDialog;
    }
}