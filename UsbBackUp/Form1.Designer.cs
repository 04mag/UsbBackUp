namespace UsbBackUp
{
    partial class Form1
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
            selectFolderDialog = new FolderBrowserDialog();
            selectFolderButton = new Button();
            selectFolderTextBox = new TextBox();
            selectFolderLabel = new Label();
            selectDestinationLabel = new Label();
            selectDestinationTextBox = new TextBox();
            selectDestinationButton = new Button();
            selectDestinationDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // selectFolderButton
            // 
            selectFolderButton.Location = new Point(366, 43);
            selectFolderButton.Margin = new Padding(4, 4, 4, 10);
            selectFolderButton.Name = "selectFolderButton";
            selectFolderButton.Size = new Size(28, 29);
            selectFolderButton.TabIndex = 2;
            selectFolderButton.Text = "...";
            selectFolderButton.UseVisualStyleBackColor = true;
            // 
            // selectFolderTextBox
            // 
            selectFolderTextBox.Location = new Point(13, 43);
            selectFolderTextBox.Margin = new Padding(4, 4, 4, 10);
            selectFolderTextBox.Name = "selectFolderTextBox";
            selectFolderTextBox.Size = new Size(345, 29);
            selectFolderTextBox.TabIndex = 1;
            // 
            // selectFolderLabel
            // 
            selectFolderLabel.AutoSize = true;
            selectFolderLabel.Location = new Point(13, 14);
            selectFolderLabel.Margin = new Padding(4, 0, 4, 4);
            selectFolderLabel.Name = "selectFolderLabel";
            selectFolderLabel.Size = new Size(100, 21);
            selectFolderLabel.TabIndex = 0;
            selectFolderLabel.Text = "Vælg mappe:";
            // 
            // selectDestinationLabel
            // 
            selectDestinationLabel.AutoSize = true;
            selectDestinationLabel.Location = new Point(13, 82);
            selectDestinationLabel.Margin = new Padding(4, 0, 4, 4);
            selectDestinationLabel.Name = "selectDestinationLabel";
            selectDestinationLabel.Size = new Size(129, 21);
            selectDestinationLabel.TabIndex = 3;
            selectDestinationLabel.Text = "Vælg destination:";
            // 
            // selectDestinationTextBox
            // 
            selectDestinationTextBox.Location = new Point(13, 111);
            selectDestinationTextBox.Margin = new Padding(4, 4, 4, 10);
            selectDestinationTextBox.Name = "selectDestinationTextBox";
            selectDestinationTextBox.Size = new Size(345, 29);
            selectDestinationTextBox.TabIndex = 4;
            // 
            // selectDestinationButton
            // 
            selectDestinationButton.Location = new Point(366, 111);
            selectDestinationButton.Margin = new Padding(4, 4, 4, 10);
            selectDestinationButton.Name = "selectDestinationButton";
            selectDestinationButton.Size = new Size(28, 29);
            selectDestinationButton.TabIndex = 5;
            selectDestinationButton.Text = "...";
            selectDestinationButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 347);
            Controls.Add(selectDestinationLabel);
            Controls.Add(selectDestinationTextBox);
            Controls.Add(selectDestinationButton);
            Controls.Add(selectFolderLabel);
            Controls.Add(selectFolderTextBox);
            Controls.Add(selectFolderButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "USB Backup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog selectFolderDialog;
        private Button selectFolderButton;
        private TextBox selectFolderTextBox;
        private Label selectFolderLabel;
        private Label selectDestinationLabel;
        private TextBox selectDestinationTextBox;
        private Button selectDestinationButton;
        private FolderBrowserDialog selectDestinationDialog;
    }
}
