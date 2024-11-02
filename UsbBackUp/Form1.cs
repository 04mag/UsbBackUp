namespace UsbBackUp
{
    public partial class Form1 : Form
    {
        private string _selectedFolderPath;
        private string _selectedDestinationPath;

        public Form1()
        {
            InitializeComponent();

            _selectedFolderPath = string.Empty;
            _selectedDestinationPath = string.Empty;

            selectFolderButton.Click += SelectFolderButton_Click;
            selectFolderTextBox.ReadOnly = true;

            selectDestinationButton.Click += SelectDestinationButton_Click;
            selectDestinationTextBox.ReadOnly = true;
        }
        private void SelectFolderButton_Click(object? sender, EventArgs e)
        {
            if (selectFolderDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedFolderPath = selectFolderDialog.SelectedPath;
                selectFolderTextBox.Text = _selectedFolderPath;
            }
        }

        private void SelectDestinationButton_Click(object? sender, EventArgs e)
        {
            if (selectDestinationDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedDestinationPath = selectDestinationDialog.SelectedPath;
                selectDestinationTextBox.Text = _selectedDestinationPath;
            }
        }

    }
}
