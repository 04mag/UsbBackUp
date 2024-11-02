using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsbBackUp.Helpers;

namespace UsbBackUp
{
    public partial class BackUpForm : Form
    {
        private string? _selectedFolderPath;
        private string? _selectedDestinationPath;

        public BackUpForm()
        {
            InitializeComponent();

            //Indlæs tidligere valgte stier fra app.config
            _selectedFolderPath = AppConfigHelper.GetSetting("PrevSelectedFolder");
            _selectedDestinationPath = AppConfigHelper.GetSetting("PrevSelectedDestination");
            if (!string.IsNullOrEmpty(_selectedFolderPath))
            {
                selectFolderTextBox.Text = _selectedFolderPath;
            }
            if (!string.IsNullOrEmpty(_selectedDestinationPath))
            {
                selectDestinationTextBox.Text = _selectedDestinationPath;
            }

            //Sætter textboxes til readonly
            selectFolderTextBox.ReadOnly = true;
            selectDestinationTextBox.ReadOnly = true;

            //Opsætning af button click events
            selectFolderButton.Click += SelectFolderButton_Click;
            selectDestinationButton.Click += SelectDestinationButton_Click;
            backupButton.Click += BackupButton_Click;
        }

        private void BackupButton_Click(object? sender, EventArgs e)
        {

            //Tjekker om der er valgt en mappe og en destinationsmappe
            if (string.IsNullOrEmpty(_selectedFolderPath) || string.IsNullOrEmpty(_selectedDestinationPath))
            {
                MessageBox.Show("Please select a folder and a destination folder");
                return;
            }

            //Tjekker om valgte mappe og destinationsmappe eksisterer
            if (!Directory.Exists(_selectedFolderPath) || !Directory.Exists(_selectedDestinationPath))
            {
                MessageBox.Show("Folder or destination folder does not exist");
                return;
            }

            MakeBackup(_selectedFolderPath, _selectedDestinationPath, "");

        }

        private void SelectFolderButton_Click(object? sender, EventArgs e)
        {
            //Åbner dialog til at vælge mappe til backup og gemmer valgte sti i app.config, textbox og variabel
            if (selectFolderDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedFolderPath = selectFolderDialog.SelectedPath;
                selectFolderTextBox.Text = _selectedFolderPath;

                AppConfigHelper.SetSetting("PrevSelectedFolder", _selectedFolderPath);
            }
        }

        private void SelectDestinationButton_Click(object? sender, EventArgs e)
        {
            //Åbner dialog til at vælge destinations mappe til backup og gemmer valgte sti i app.config, textbox og variabel
            if (selectDestinationDialog.ShowDialog() == DialogResult.OK)
            {
                _selectedDestinationPath = selectDestinationDialog.SelectedPath;
                selectDestinationTextBox.Text = _selectedDestinationPath;

                AppConfigHelper.SetSetting("PrevSelectedDestination", _selectedDestinationPath);
            }
        }

        private string[] MakeBackup(string sourcePath, string destinationPath, string prevSerial)
        {
            //Finder stien til Backup.bat filen som er gemt i projektet
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string BackUpCMDPath = projectDirectory + @"\Backup.bat";

            //Opretter ProcessStartInfo objekt med argumenter
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = BackUpCMDPath,
                Arguments = sourcePath + " " + destinationPath + "" + prevSerial,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = false
            };

            //Starter processen
            Process process = Process.Start(psi);

            //Venter på at processen er færdig
            process.WaitForExit();


            //Tjekker om processen er kørt uden fejl
            if (process.ExitCode != 0)
            {
                MessageBox.Show("Ukendt fejl ved kopiering. Prøv igen!");
            }
            //Tjekker om processen rammer fejl for at bruge drev med samme serie nummer som sidst
            if (process.ExitCode == 1)
            {
                MessageBox.Show("Du kan ikke oprette en backup på samme drev som sidst!");
            }

            //Læser resultat fra output og fjerner \n fra enden af output
            string output = process.StandardOutput.ReadToEnd().Trim('\n');

            //Splitter resultat på \n
            string[] resultat = output.Split('\n');

            //Fjerne \r fra resultat
            for (int i = 0; i < resultat.Length; i++)
            {
                resultat[i] = resultat[i].Trim('\r');
            }

            //Returnerer resultat
            return resultat;
        }
    }
}
