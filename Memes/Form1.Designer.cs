namespace Memes
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.renameTextBox = new System.Windows.Forms.TextBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.directoriesListBox = new System.Windows.Forms.ListBox();
            this.removeQuickButton = new System.Windows.Forms.Button();
            this.addQuickButton = new System.Windows.Forms.Button();
            this.addDirectoryButton = new System.Windows.Forms.Button();
            this.removeDirectoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quicksListBox = new System.Windows.Forms.ListBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.renameTextBox);
            this.groupBox1.Controls.Add(this.directoryLabel);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.filenameLabel);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.previousButton);
            this.groupBox1.Location = new System.Drawing.Point(259, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // renameTextBox
            // 
            this.renameTextBox.Location = new System.Drawing.Point(33, 204);
            this.renameTextBox.Name = "renameTextBox";
            this.renameTextBox.Size = new System.Drawing.Size(170, 20);
            this.renameTextBox.TabIndex = 6;
            this.renameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.renameTextBox.Visible = false;
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoEllipsis = true;
            this.directoryLabel.Location = new System.Drawing.Point(10, 15);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(221, 14);
            this.directoryLabel.TabIndex = 5;
            this.directoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(209, 106);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(22, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "→";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoEllipsis = true;
            this.filenameLabel.Location = new System.Drawing.Point(10, 206);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(221, 14);
            this.filenameLabel.TabIndex = 3;
            this.filenameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(5, 106);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(22, 23);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "←";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(417, 247);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(65, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseMnemonic = false;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(272, 247);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(65, 23);
            this.renameButton.TabIndex = 5;
            this.renameButton.Text = "Rename";
            this.renameButton.UseMnemonic = false;
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // directoriesListBox
            // 
            this.directoriesListBox.FormattingEnabled = true;
            this.directoriesListBox.Location = new System.Drawing.Point(12, 29);
            this.directoriesListBox.Name = "directoriesListBox";
            this.directoriesListBox.Size = new System.Drawing.Size(116, 212);
            this.directoriesListBox.TabIndex = 1;
            this.directoriesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.directoriesListBox_MouseDoubleClick);
            // 
            // removeQuickButton
            // 
            this.removeQuickButton.Location = new System.Drawing.Point(198, 247);
            this.removeQuickButton.Name = "removeQuickButton";
            this.removeQuickButton.Size = new System.Drawing.Size(55, 23);
            this.removeQuickButton.TabIndex = 12;
            this.removeQuickButton.Text = "Remove";
            this.removeQuickButton.UseVisualStyleBackColor = true;
            this.removeQuickButton.Click += new System.EventHandler(this.removeQuickButton_Click);
            // 
            // addQuickButton
            // 
            this.addQuickButton.Location = new System.Drawing.Point(137, 247);
            this.addQuickButton.Name = "addQuickButton";
            this.addQuickButton.Size = new System.Drawing.Size(55, 23);
            this.addQuickButton.TabIndex = 13;
            this.addQuickButton.Text = "Add...";
            this.addQuickButton.UseVisualStyleBackColor = true;
            this.addQuickButton.Click += new System.EventHandler(this.addQuickButton_Click);
            // 
            // addDirectoryButton
            // 
            this.addDirectoryButton.Location = new System.Drawing.Point(12, 247);
            this.addDirectoryButton.Name = "addDirectoryButton";
            this.addDirectoryButton.Size = new System.Drawing.Size(55, 23);
            this.addDirectoryButton.TabIndex = 15;
            this.addDirectoryButton.Text = "Add...";
            this.addDirectoryButton.UseVisualStyleBackColor = true;
            this.addDirectoryButton.Click += new System.EventHandler(this.addDirectoryButton_Click);
            // 
            // removeDirectoryButton
            // 
            this.removeDirectoryButton.Location = new System.Drawing.Point(73, 247);
            this.removeDirectoryButton.Name = "removeDirectoryButton";
            this.removeDirectoryButton.Size = new System.Drawing.Size(55, 23);
            this.removeDirectoryButton.TabIndex = 16;
            this.removeDirectoryButton.Text = "Remove";
            this.removeDirectoryButton.UseVisualStyleBackColor = true;
            this.removeDirectoryButton.Click += new System.EventHandler(this.removeDirectoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Directories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quick Move Locations";
            // 
            // quicksListBox
            // 
            this.quicksListBox.FormattingEnabled = true;
            this.quicksListBox.Location = new System.Drawing.Point(137, 29);
            this.quicksListBox.Name = "quicksListBox";
            this.quicksListBox.Size = new System.Drawing.Size(116, 212);
            this.quicksListBox.TabIndex = 19;
            this.quicksListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.quicksListBox_MouseDoubleClick);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(346, 247);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(65, 23);
            this.moveButton.TabIndex = 7;
            this.moveButton.Text = "Move...";
            this.moveButton.UseMnemonic = false;
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(417, 247);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(65, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseMnemonic = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 282);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.quicksListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeDirectoryButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.addDirectoryButton);
            this.Controls.Add(this.addQuickButton);
            this.Controls.Add(this.removeQuickButton);
            this.Controls.Add(this.directoriesListBox);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Memes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.ListBox directoriesListBox;
        private System.Windows.Forms.Button removeQuickButton;
        private System.Windows.Forms.Button addQuickButton;
        private System.Windows.Forms.Button addDirectoryButton;
        private System.Windows.Forms.Button removeDirectoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox quicksListBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.TextBox renameTextBox;
        private System.Windows.Forms.Button cancelButton;
    }
}

