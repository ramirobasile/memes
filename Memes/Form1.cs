using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memes
{
    public partial class Form1 : Form
    {
        string GetDirectoryName { get { return Path.GetDirectoryName(pictures[currentPicture]); } }
        string GetExtension { get { return Path.GetExtension(pictures[currentPicture]); } }
        string GetFileName { get { return Path.GetFileName(pictures[currentPicture]); } }
        string GetFileNameWithoutExtension { get { return Path.GetFileNameWithoutExtension(pictures[currentPicture]); } }
        string GetFullPath { get { return Path.GetFullPath(pictures[currentPicture]); } }

        List<string> directories = new List<string>();
        List<string> quicks = new List<string>();
        List<string> pictures = new List<string>();
        int currentPicture = 0;

        public Form1()
        {
            InitializeComponent();
            this.Focus();
            UpdatePreview();
        }

        void UpdateLists()
        {
            // Directories
            directoriesListBox.Items.Clear();
            foreach (string directory in directories)
                directoriesListBox.Items.Add(directory.Split(Path.DirectorySeparatorChar).Last());

            // Quicks
            quicksListBox.Items.Clear();
            foreach (string quick in quicks)
                quicksListBox.Items.Add(quick.Split('\\').Last());

            // Pictures
            pictures.Clear();
            foreach (string directory in directories)
                foreach (string filter in new string[] { "jpg", "jpeg", "png", "gif", "tiff", "bmp", "svg" })
                {
                    DirectoryInfo d = new DirectoryInfo(@"" + directory);
                    FileInfo[] Files = d.GetFiles("*." + filter);
                    foreach (FileInfo file in Files)
                        pictures.Add(file.FullName);
                }

                UpdatePreview();
        }

        void UpdatePreview()
        {
            this.Focus();
            if (pictures.Count() > 0)
            {
                pictureBox1.ImageLocation = GetFullPath;
                directoryLabel.Text = GetDirectoryName;
                filenameLabel.Text = GetFileName;
                renameButton.Enabled = true;
                moveButton.Enabled = true;
                deleteButton.Enabled = true;
                previousButton.Enabled = true;
                nextButton.Enabled = true;
            }
            else
            {
                pictureBox1.ImageLocation = "";
                directoryLabel.Text = "";
                filenameLabel.Text = "";
                renameButton.Enabled = false;
                moveButton.Enabled = false;
                deleteButton.Enabled = false;
                previousButton.Enabled = false;
                nextButton.Enabled = false;
            }
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Process.Start(@"" + GetFullPath);
        }

        // Add/Remove directories
        private void addDirectoryButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK && !directories.Contains(folderBrowserDialog1.SelectedPath))
            {
                directories.Add(folderBrowserDialog1.SelectedPath);
                UpdateLists();
            }
        }

        private void removeDirectoryButton_Click(object sender, EventArgs e)
        {
            if (directoriesListBox.SelectedIndex >= 0)
            {
                directories.RemoveAt(directoriesListBox.SelectedIndex);
                currentPicture = 0;
                UpdateLists();
            }
        }

        private void directoriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (quicksListBox.SelectedIndex >= 0)
                Process.Start(@"" + directories[directoriesListBox.SelectedIndex]);
        }
        
        // Add/Remove quicks
        private void addQuickButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK && !quicks.Contains(folderBrowserDialog1.SelectedPath))
            {
                quicks.Add(folderBrowserDialog1.SelectedPath);
                UpdateLists();
            }
        }

        private void removeQuickButton_Click(object sender, EventArgs e)
        {
            if (quicksListBox.SelectedIndex >= 0)
            {
                quicks.RemoveAt(quicksListBox.SelectedIndex);
                UpdateLists();
            }
        }
        
        // Prev/Next
        void Next()
        {
            if (pictures.Count() > 0 && currentPicture < pictures.Count() - 1)
            {
                currentPicture++;
                UpdatePreview();
            }
        }

        void Prev()
        {
            if (pictures.Count() > 0 && currentPicture > 0)
            {
                currentPicture--;
                UpdatePreview();
            }
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            Prev();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Next();
        }


        // Move
        void MoveFile()
        {
            if (pictures.Count() > 0 && folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Move(GetFullPath, folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + GetFileName);
                if (currentPicture > 0)
                    currentPicture--;
                UpdateLists();
            }
        }

        void QuickMoveFile()
        {
            if (quicksListBox.SelectedIndex >= 0)
            {
                File.Move(GetFullPath, quicks[quicksListBox.SelectedIndex] + Path.DirectorySeparatorChar + GetFileName);
                UpdateLists();
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            MoveFile();
        }

        private void quicksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            QuickMoveFile();
        }

        // Rename
        void Rename()
        {
            if (pictures.Count() > 0)
            {
                if (!renameTextBox.Visible)
                {
                    renameTextBox.Text = GetFileNameWithoutExtension;
                    renameTextBox.Visible = true;
                    renameTextBox.Focus();
                    cancelButton.Visible = true;
                    moveButton.Enabled = false;
                    deleteButton.Enabled = false;
                    removeDirectoryButton.Enabled = false;
                    removeQuickButton.Enabled = false;
                } else {
                    string renamed = GetDirectoryName + Path.DirectorySeparatorChar + renameTextBox.Text + GetExtension;
                    int count = 1;

                    while (File.Exists(renamed))
                    {
                        string tempFileName = string.Format("{0} ({1})", Path.GetFileNameWithoutExtension(renamed), count++);
                        renamed = Path.Combine(Path.GetDirectoryName(renamed), tempFileName + Path.GetExtension(renamed));
                    }

                    File.Move(GetFullPath, renamed);
                    if (currentPicture > 0)
                        currentPicture--;
                    UpdateLists();
                    renameTextBox.Visible = false;
                    cancelButton.Visible = false;
                    moveButton.Enabled = true;
                    deleteButton.Enabled = true;
                    removeDirectoryButton.Enabled = true;
                    removeQuickButton.Enabled = true;
                }
            }
        }

        void Cancel()
        {
            renameTextBox.Visible = false;
            cancelButton.Visible = false;
            moveButton.Enabled = true;
            deleteButton.Enabled = true;
            removeDirectoryButton.Enabled = true;
            removeQuickButton.Enabled = true;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            Rename();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        // Delete
        void Delete()
        {
            if (pictures.Count() > 0 && MessageBox.Show("Are you sure you want to permanently delete this file?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.Delete(@"" + GetFullPath);
                if (currentPicture > 0)
                    currentPicture--;
                UpdateLists();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        // Keys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right && !renameTextBox.Visible)
            {
                Next();
                return true;
            }
            if (keyData == Keys.Left && !renameTextBox.Visible)
            {
                Prev();
                return true;
            }
            if ((keyData == (Keys.Control | Keys.R) || keyData == Keys.F2) && !renameTextBox.Visible)
            {
                Rename();
                return true;
            }
            if (keyData == Keys.Enter && renameTextBox.Visible)
            {
                Rename();
                return true;
            }
            if (keyData == Keys.Escape && renameTextBox.Visible)
            {
                Cancel();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M) || keyData == (Keys.Control | Keys.X))
            {
                MoveFile();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D) || keyData == Keys.Delete)
            {
                Delete();
                return true;
            }
            if (keyData == Keys.F5)
            {
                UpdateLists();
                return true;
            }
            Keys[] nkeys = new Keys[] { Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            for (int i = 0; i < nkeys.Length; i++)
            {
                if (keyData == (Keys.Control | nkeys[i]))
                {
                    quicksListBox.SelectedIndex = i;
                    QuickMoveFile();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
