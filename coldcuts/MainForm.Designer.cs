﻿namespace ColdCutsNS
{
    partial class MainForm
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
        protected void InitializeComponent(){
      this.sourceBrowseButton = new System.Windows.Forms.Button();
      this.sourceFilePathTextBox = new System.Windows.Forms.TextBox();
      this.sourceLabel = new System.Windows.Forms.Label();
      this.destinationBrowseButton = new System.Windows.Forms.Button();
      this.destinationLabel = new System.Windows.Forms.Label();
      this.destinationFilePathTextBox = new System.Windows.Forms.TextBox();
      this.inputFileGroupbox = new System.Windows.Forms.GroupBox();
      this.lengthInputLabel = new System.Windows.Forms.Label();
      this.lengthLabel = new System.Windows.Forms.Label();
      this.feedBackLabel2 = new System.Windows.Forms.Label();
      this.feedBackLabel = new System.Windows.Forms.Label();
      this.artistInputLabel = new System.Windows.Forms.Label();
      this.titleInputLabel = new System.Windows.Forms.Label();
      this.titleLabel = new System.Windows.Forms.Label();
      this.artistLabel = new System.Windows.Forms.Label();
      this.encodeButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.endSecTextBox = new System.Windows.Forms.TextBox();
      this.endMinTextBox = new System.Windows.Forms.TextBox();
      this.startSecTextBox = new System.Windows.Forms.TextBox();
      this.startMinTextBox = new System.Windows.Forms.TextBox();
      this.endLabel = new System.Windows.Forms.Label();
      this.startLabel = new System.Windows.Forms.Label();
      this.deleteButton = new System.Windows.Forms.Button();
      this.fileNameOutputBox = new System.Windows.Forms.TextBox();
      this.fileNameLabel = new System.Windows.Forms.Label();
      this.fileLeftButton = new System.Windows.Forms.Button();
      this.fileRightButton = new System.Windows.Forms.Button();
      this.addFileButton = new System.Windows.Forms.Button();
      this.editPositionLabel = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.gridtracknumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gridtrackname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gridstarttime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gridendtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.btnAutoSplit = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.commentOutputTextBox = new System.Windows.Forms.TextBox();
      this.commentOutputLabel = new System.Windows.Forms.Label();
      this.albumOutputTextBox = new System.Windows.Forms.TextBox();
      this.titleOutputTextBox = new System.Windows.Forms.TextBox();
      this.artistOutputTextBox = new System.Windows.Forms.TextBox();
      this.artistOutputLabel = new System.Windows.Forms.Label();
      this.titleOutputLabel = new System.Windows.Forms.Label();
      this.albumOutputLabel = new System.Windows.Forms.Label();
      this.menu = new System.Windows.Forms.MenuStrip();
      this.ToolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemSilence = new System.Windows.Forms.ToolStripMenuItem();
      this.silenceMenuItem = new System.Windows.Forms.ToolStripTextBox();
      this.toolStripMenuItemMinGap = new System.Windows.Forms.ToolStripMenuItem();
      this.minGapMenuItem = new System.Windows.Forms.ToolStripTextBox();
      this.btnSpliByStep = new System.Windows.Forms.Button();
      this.splitStepTextBox = new System.Windows.Forms.TextBox();
      this.inputFileGroupbox.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // sourceBrowseButton
      // 
      this.sourceBrowseButton.Location = new System.Drawing.Point(19, 66);
      this.sourceBrowseButton.Margin = new System.Windows.Forms.Padding(4);
      this.sourceBrowseButton.Name = "sourceBrowseButton";
      this.sourceBrowseButton.Size = new System.Drawing.Size(89, 34);
      this.sourceBrowseButton.TabIndex = 0;
      this.sourceBrowseButton.Text = "Browse...";
      this.sourceBrowseButton.UseVisualStyleBackColor = true;
      this.sourceBrowseButton.Click += new System.EventHandler(this.browseButton_Click);
      // 
      // sourceFilePathTextBox
      // 
      this.sourceFilePathTextBox.Location = new System.Drawing.Point(19, 39);
      this.sourceFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.sourceFilePathTextBox.Name = "sourceFilePathTextBox";
      this.sourceFilePathTextBox.Size = new System.Drawing.Size(412, 22);
      this.sourceFilePathTextBox.TabIndex = 2;
      this.sourceFilePathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sourceFilePathTextBox_KeyPress);
      // 
      // sourceLabel
      // 
      this.sourceLabel.AutoSize = true;
      this.sourceLabel.Location = new System.Drawing.Point(16, 18);
      this.sourceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.sourceLabel.Name = "sourceLabel";
      this.sourceLabel.Size = new System.Drawing.Size(93, 17);
      this.sourceLabel.TabIndex = 3;
      this.sourceLabel.Text = "Source path: ";
      // 
      // destinationBrowseButton
      // 
      this.destinationBrowseButton.Enabled = false;
      this.destinationBrowseButton.Location = new System.Drawing.Point(17, 167);
      this.destinationBrowseButton.Margin = new System.Windows.Forms.Padding(4);
      this.destinationBrowseButton.Name = "destinationBrowseButton";
      this.destinationBrowseButton.Size = new System.Drawing.Size(89, 34);
      this.destinationBrowseButton.TabIndex = 4;
      this.destinationBrowseButton.Text = "Browse...";
      this.destinationBrowseButton.UseVisualStyleBackColor = true;
      this.destinationBrowseButton.Click += new System.EventHandler(this.destinationBrowseButton_Click);
      // 
      // destinationLabel
      // 
      this.destinationLabel.AutoSize = true;
      this.destinationLabel.Location = new System.Drawing.Point(15, 121);
      this.destinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.destinationLabel.Name = "destinationLabel";
      this.destinationLabel.Size = new System.Drawing.Size(119, 17);
      this.destinationLabel.TabIndex = 5;
      this.destinationLabel.Text = "Destination path: ";
      // 
      // destinationFilePathTextBox
      // 
      this.destinationFilePathTextBox.Enabled = false;
      this.destinationFilePathTextBox.Location = new System.Drawing.Point(17, 140);
      this.destinationFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.destinationFilePathTextBox.Name = "destinationFilePathTextBox";
      this.destinationFilePathTextBox.Size = new System.Drawing.Size(412, 22);
      this.destinationFilePathTextBox.TabIndex = 6;
      // 
      // inputFileGroupbox
      // 
      this.inputFileGroupbox.Controls.Add(this.lengthInputLabel);
      this.inputFileGroupbox.Controls.Add(this.lengthLabel);
      this.inputFileGroupbox.Controls.Add(this.feedBackLabel2);
      this.inputFileGroupbox.Controls.Add(this.feedBackLabel);
      this.inputFileGroupbox.Controls.Add(this.artistInputLabel);
      this.inputFileGroupbox.Controls.Add(this.titleInputLabel);
      this.inputFileGroupbox.Controls.Add(this.titleLabel);
      this.inputFileGroupbox.Controls.Add(this.artistLabel);
      this.inputFileGroupbox.Location = new System.Drawing.Point(19, 231);
      this.inputFileGroupbox.Margin = new System.Windows.Forms.Padding(4);
      this.inputFileGroupbox.Name = "inputFileGroupbox";
      this.inputFileGroupbox.Padding = new System.Windows.Forms.Padding(4);
      this.inputFileGroupbox.Size = new System.Drawing.Size(412, 166);
      this.inputFileGroupbox.TabIndex = 9;
      this.inputFileGroupbox.TabStop = false;
      this.inputFileGroupbox.Text = "Source File Information: ";
      // 
      // lengthInputLabel
      // 
      this.lengthInputLabel.AutoSize = true;
      this.lengthInputLabel.Location = new System.Drawing.Point(84, 97);
      this.lengthInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lengthInputLabel.Name = "lengthInputLabel";
      this.lengthInputLabel.Size = new System.Drawing.Size(38, 17);
      this.lengthInputLabel.TabIndex = 11;
      this.lengthInputLabel.Text = "xxxxx";
      // 
      // lengthLabel
      // 
      this.lengthLabel.AutoSize = true;
      this.lengthLabel.Location = new System.Drawing.Point(8, 97);
      this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lengthLabel.Name = "lengthLabel";
      this.lengthLabel.Size = new System.Drawing.Size(82, 17);
      this.lengthLabel.TabIndex = 11;
      this.lengthLabel.Text = "File Length:";
      // 
      // feedBackLabel2
      // 
      this.feedBackLabel2.AutoSize = true;
      this.feedBackLabel2.Location = new System.Drawing.Point(8, 140);
      this.feedBackLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.feedBackLabel2.Name = "feedBackLabel2";
      this.feedBackLabel2.Size = new System.Drawing.Size(81, 17);
      this.feedBackLabel2.TabIndex = 12;
      this.feedBackLabel2.Text = "Percentage";
      this.feedBackLabel2.Visible = false;
      // 
      // feedBackLabel
      // 
      this.feedBackLabel.AutoSize = true;
      this.feedBackLabel.Location = new System.Drawing.Point(8, 124);
      this.feedBackLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.feedBackLabel.Name = "feedBackLabel";
      this.feedBackLabel.Size = new System.Drawing.Size(79, 17);
      this.feedBackLabel.TabIndex = 11;
      this.feedBackLabel.Text = "Encoding...";
      this.feedBackLabel.Visible = false;
      // 
      // artistInputLabel
      // 
      this.artistInputLabel.Location = new System.Drawing.Point(48, 20);
      this.artistInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.artistInputLabel.Name = "artistInputLabel";
      this.artistInputLabel.Size = new System.Drawing.Size(356, 32);
      this.artistInputLabel.TabIndex = 3;
      this.artistInputLabel.Text = "xxxxx";
      // 
      // titleInputLabel
      // 
      this.titleInputLabel.Location = new System.Drawing.Point(48, 57);
      this.titleInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.titleInputLabel.Name = "titleInputLabel";
      this.titleInputLabel.Size = new System.Drawing.Size(356, 33);
      this.titleInputLabel.TabIndex = 2;
      this.titleInputLabel.Text = "xxxxx";
      // 
      // titleLabel
      // 
      this.titleLabel.AutoSize = true;
      this.titleLabel.Location = new System.Drawing.Point(8, 57);
      this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(39, 17);
      this.titleLabel.TabIndex = 1;
      this.titleLabel.Text = "Title:";
      // 
      // artistLabel
      // 
      this.artistLabel.AutoSize = true;
      this.artistLabel.Location = new System.Drawing.Point(8, 20);
      this.artistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.artistLabel.Name = "artistLabel";
      this.artistLabel.Size = new System.Drawing.Size(44, 17);
      this.artistLabel.TabIndex = 0;
      this.artistLabel.Text = "Artist:";
      // 
      // encodeButton
      // 
      this.encodeButton.Enabled = false;
      this.encodeButton.Location = new System.Drawing.Point(265, 425);
      this.encodeButton.Margin = new System.Windows.Forms.Padding(4);
      this.encodeButton.Name = "encodeButton";
      this.encodeButton.Size = new System.Drawing.Size(107, 32);
      this.encodeButton.TabIndex = 10;
      this.encodeButton.Text = "Split MP3 File";
      this.encodeButton.UseVisualStyleBackColor = true;
      this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.endSecTextBox);
      this.groupBox1.Controls.Add(this.endMinTextBox);
      this.groupBox1.Controls.Add(this.startSecTextBox);
      this.groupBox1.Controls.Add(this.startMinTextBox);
      this.groupBox1.Controls.Add(this.endLabel);
      this.groupBox1.Controls.Add(this.startLabel);
      this.groupBox1.Controls.Add(this.deleteButton);
      this.groupBox1.Controls.Add(this.fileNameOutputBox);
      this.groupBox1.Controls.Add(this.fileNameLabel);
      this.groupBox1.Location = new System.Drawing.Point(457, 64);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(333, 165);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Output File: ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(67, 25);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 17);
      this.label1.TabIndex = 32;
      this.label1.Text = "Min : Sec";
      // 
      // endSecTextBox
      // 
      this.endSecTextBox.Enabled = false;
      this.endSecTextBox.Location = new System.Drawing.Point(104, 73);
      this.endSecTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.endSecTextBox.Name = "endSecTextBox";
      this.endSecTextBox.Size = new System.Drawing.Size(40, 22);
      this.endSecTextBox.TabIndex = 31;
      this.endSecTextBox.Leave += new System.EventHandler(this.Leave);
      // 
      // endMinTextBox
      // 
      this.endMinTextBox.Enabled = false;
      this.endMinTextBox.Location = new System.Drawing.Point(55, 73);
      this.endMinTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.endMinTextBox.Name = "endMinTextBox";
      this.endMinTextBox.Size = new System.Drawing.Size(40, 22);
      this.endMinTextBox.TabIndex = 30;
      this.endMinTextBox.Leave += new System.EventHandler(this.Leave);
      // 
      // startSecTextBox
      // 
      this.startSecTextBox.Enabled = false;
      this.startSecTextBox.Location = new System.Drawing.Point(104, 43);
      this.startSecTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.startSecTextBox.Name = "startSecTextBox";
      this.startSecTextBox.Size = new System.Drawing.Size(40, 22);
      this.startSecTextBox.TabIndex = 29;
      this.startSecTextBox.Leave += new System.EventHandler(this.Leave);
      // 
      // startMinTextBox
      // 
      this.startMinTextBox.Enabled = false;
      this.startMinTextBox.Location = new System.Drawing.Point(55, 43);
      this.startMinTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.startMinTextBox.Name = "startMinTextBox";
      this.startMinTextBox.Size = new System.Drawing.Size(40, 22);
      this.startMinTextBox.TabIndex = 28;
      this.startMinTextBox.Leave += new System.EventHandler(this.Leave);
      // 
      // endLabel
      // 
      this.endLabel.AutoSize = true;
      this.endLabel.Location = new System.Drawing.Point(19, 76);
      this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.endLabel.Name = "endLabel";
      this.endLabel.Size = new System.Drawing.Size(33, 17);
      this.endLabel.TabIndex = 27;
      this.endLabel.Text = "End";
      // 
      // startLabel
      // 
      this.startLabel.AutoSize = true;
      this.startLabel.Location = new System.Drawing.Point(15, 47);
      this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.startLabel.Name = "startLabel";
      this.startLabel.Size = new System.Drawing.Size(38, 17);
      this.startLabel.TabIndex = 26;
      this.startLabel.Text = "Start";
      // 
      // deleteButton
      // 
      this.deleteButton.Enabled = false;
      this.deleteButton.Location = new System.Drawing.Point(187, 43);
      this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(95, 30);
      this.deleteButton.TabIndex = 25;
      this.deleteButton.Text = "Delete";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // fileNameOutputBox
      // 
      this.fileNameOutputBox.Enabled = false;
      this.fileNameOutputBox.Location = new System.Drawing.Point(13, 127);
      this.fileNameOutputBox.Margin = new System.Windows.Forms.Padding(4);
      this.fileNameOutputBox.Name = "fileNameOutputBox";
      this.fileNameOutputBox.Size = new System.Drawing.Size(304, 22);
      this.fileNameOutputBox.TabIndex = 16;
      this.fileNameOutputBox.Leave += new System.EventHandler(this.Leave);
      // 
      // fileNameLabel
      // 
      this.fileNameLabel.AutoSize = true;
      this.fileNameLabel.Location = new System.Drawing.Point(13, 107);
      this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.fileNameLabel.Name = "fileNameLabel";
      this.fileNameLabel.Size = new System.Drawing.Size(75, 17);
      this.fileNameLabel.TabIndex = 15;
      this.fileNameLabel.Text = "File Name:";
      // 
      // fileLeftButton
      // 
      this.fileLeftButton.Enabled = false;
      this.fileLeftButton.Location = new System.Drawing.Point(487, 18);
      this.fileLeftButton.Margin = new System.Windows.Forms.Padding(4);
      this.fileLeftButton.Name = "fileLeftButton";
      this.fileLeftButton.Size = new System.Drawing.Size(37, 32);
      this.fileLeftButton.TabIndex = 12;
      this.fileLeftButton.Text = "<<";
      this.fileLeftButton.Click += new System.EventHandler(this.fileLeftButton_Click);
      // 
      // fileRightButton
      // 
      this.fileRightButton.Enabled = false;
      this.fileRightButton.Location = new System.Drawing.Point(532, 18);
      this.fileRightButton.Margin = new System.Windows.Forms.Padding(4);
      this.fileRightButton.Name = "fileRightButton";
      this.fileRightButton.Size = new System.Drawing.Size(37, 32);
      this.fileRightButton.TabIndex = 13;
      this.fileRightButton.Text = ">>";
      this.fileRightButton.Click += new System.EventHandler(this.fileRightButton_Click);
      // 
      // addFileButton
      // 
      this.addFileButton.Enabled = false;
      this.addFileButton.Location = new System.Drawing.Point(577, 18);
      this.addFileButton.Margin = new System.Windows.Forms.Padding(4);
      this.addFileButton.Name = "addFileButton";
      this.addFileButton.Size = new System.Drawing.Size(37, 32);
      this.addFileButton.TabIndex = 14;
      this.addFileButton.Text = "+";
      this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
      // 
      // editPositionLabel
      // 
      this.editPositionLabel.AutoSize = true;
      this.editPositionLabel.Location = new System.Drawing.Point(627, 30);
      this.editPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.editPositionLabel.Name = "editPositionLabel";
      this.editPositionLabel.Size = new System.Drawing.Size(132, 17);
      this.editPositionLabel.TabIndex = 15;
      this.editPositionLabel.Text = "Editing Output File: ";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridtracknumber,
            this.gridtrackname,
            this.gridstarttime,
            this.gridendtime});
      this.dataGridView1.Location = new System.Drawing.Point(811, 18);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(420, 462);
      this.dataGridView1.TabIndex = 16;
      this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
      this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLeave);
      // 
      // gridtracknumber
      // 
      this.gridtracknumber.HeaderText = "#";
      this.gridtracknumber.Name = "gridtracknumber";
      this.gridtracknumber.ReadOnly = true;
      this.gridtracknumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.gridtracknumber.Width = 20;
      // 
      // gridtrackname
      // 
      this.gridtrackname.HeaderText = "File Name";
      this.gridtrackname.Name = "gridtrackname";
      this.gridtrackname.ReadOnly = true;
      this.gridtrackname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.gridtrackname.Width = 150;
      // 
      // gridstarttime
      // 
      this.gridstarttime.HeaderText = "Start Time";
      this.gridstarttime.Name = "gridstarttime";
      this.gridstarttime.ReadOnly = true;
      this.gridstarttime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.gridstarttime.Width = 50;
      // 
      // gridendtime
      // 
      this.gridendtime.HeaderText = "End Time";
      this.gridendtime.Name = "gridendtime";
      this.gridendtime.ReadOnly = true;
      this.gridendtime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.gridendtime.Width = 50;
      // 
      // backgroundWorker
      // 
      this.backgroundWorker.WorkerReportsProgress = true;
      this.backgroundWorker.WorkerSupportsCancellation = true;
      this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
      this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
      this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
      // 
      // btnAutoSplit
      // 
      this.btnAutoSplit.Enabled = false;
      this.btnAutoSplit.Location = new System.Drawing.Point(60, 425);
      this.btnAutoSplit.Margin = new System.Windows.Forms.Padding(4);
      this.btnAutoSplit.Name = "btnAutoSplit";
      this.btnAutoSplit.Size = new System.Drawing.Size(100, 32);
      this.btnAutoSplit.TabIndex = 17;
      this.btnAutoSplit.Text = "Auto Split";
      this.btnAutoSplit.UseVisualStyleBackColor = true;
      this.btnAutoSplit.Click += new System.EventHandler(this.btnAutoSplit_Click);
      this.btnAutoSplit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAutoSplit_MouseUp);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.commentOutputTextBox);
      this.groupBox2.Controls.Add(this.commentOutputLabel);
      this.groupBox2.Controls.Add(this.albumOutputTextBox);
      this.groupBox2.Controls.Add(this.titleOutputTextBox);
      this.groupBox2.Controls.Add(this.artistOutputTextBox);
      this.groupBox2.Controls.Add(this.artistOutputLabel);
      this.groupBox2.Controls.Add(this.titleOutputLabel);
      this.groupBox2.Controls.Add(this.albumOutputLabel);
      this.groupBox2.Location = new System.Drawing.Point(457, 210);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox2.Size = new System.Drawing.Size(333, 249);
      this.groupBox2.TabIndex = 33;
      this.groupBox2.TabStop = false;
      // 
      // commentOutputTextBox
      // 
      this.commentOutputTextBox.Enabled = false;
      this.commentOutputTextBox.Location = new System.Drawing.Point(13, 182);
      this.commentOutputTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.commentOutputTextBox.Multiline = true;
      this.commentOutputTextBox.Name = "commentOutputTextBox";
      this.commentOutputTextBox.Size = new System.Drawing.Size(304, 52);
      this.commentOutputTextBox.TabIndex = 40;
      this.commentOutputTextBox.Leave += new System.EventHandler(this.Leave);
      // 
      // commentOutputLabel
      // 
      this.commentOutputLabel.AutoSize = true;
      this.commentOutputLabel.Location = new System.Drawing.Point(13, 165);
      this.commentOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.commentOutputLabel.Name = "commentOutputLabel";
      this.commentOutputLabel.Size = new System.Drawing.Size(75, 17);
      this.commentOutputLabel.TabIndex = 36;
      this.commentOutputLabel.Text = "Comment: ";
      // 
      // albumOutputTextBox
      // 
      this.albumOutputTextBox.Enabled = false;
      this.albumOutputTextBox.Location = new System.Drawing.Point(13, 138);
      this.albumOutputTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.albumOutputTextBox.Name = "albumOutputTextBox";
      this.albumOutputTextBox.Size = new System.Drawing.Size(304, 22);
      this.albumOutputTextBox.TabIndex = 39;
      this.albumOutputTextBox.Leave += new System.EventHandler(this.Leave);
      // 
      // titleOutputTextBox
      // 
      this.titleOutputTextBox.Enabled = false;
      this.titleOutputTextBox.Location = new System.Drawing.Point(13, 89);
      this.titleOutputTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.titleOutputTextBox.Name = "titleOutputTextBox";
      this.titleOutputTextBox.Size = new System.Drawing.Size(304, 22);
      this.titleOutputTextBox.TabIndex = 38;
      this.titleOutputTextBox.Leave += new System.EventHandler(this.Leave);
      // 
      // artistOutputTextBox
      // 
      this.artistOutputTextBox.Enabled = false;
      this.artistOutputTextBox.Location = new System.Drawing.Point(13, 42);
      this.artistOutputTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.artistOutputTextBox.Name = "artistOutputTextBox";
      this.artistOutputTextBox.Size = new System.Drawing.Size(304, 22);
      this.artistOutputTextBox.TabIndex = 37;
      this.artistOutputTextBox.Leave += new System.EventHandler(this.Leave);
      // 
      // artistOutputLabel
      // 
      this.artistOutputLabel.AutoSize = true;
      this.artistOutputLabel.Location = new System.Drawing.Point(13, 22);
      this.artistOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.artistOutputLabel.Name = "artistOutputLabel";
      this.artistOutputLabel.Size = new System.Drawing.Size(48, 17);
      this.artistOutputLabel.TabIndex = 33;
      this.artistOutputLabel.Text = "Artist: ";
      // 
      // titleOutputLabel
      // 
      this.titleOutputLabel.AutoSize = true;
      this.titleOutputLabel.Location = new System.Drawing.Point(13, 69);
      this.titleOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.titleOutputLabel.Name = "titleOutputLabel";
      this.titleOutputLabel.Size = new System.Drawing.Size(43, 17);
      this.titleOutputLabel.TabIndex = 34;
      this.titleOutputLabel.Text = "Title: ";
      // 
      // albumOutputLabel
      // 
      this.albumOutputLabel.AutoSize = true;
      this.albumOutputLabel.Location = new System.Drawing.Point(12, 118);
      this.albumOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.albumOutputLabel.Name = "albumOutputLabel";
      this.albumOutputLabel.Size = new System.Drawing.Size(55, 17);
      this.albumOutputLabel.TabIndex = 35;
      this.albumOutputLabel.Text = "Album: ";
      // 
      // menu
      // 
      this.menu.Dock = System.Windows.Forms.DockStyle.None;
      this.menu.GripMargin = new System.Windows.Forms.Padding(0);
      this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOptions});
      this.menu.Location = new System.Drawing.Point(71, 448);
      this.menu.Name = "menu";
      this.menu.Padding = new System.Windows.Forms.Padding(0);
      this.menu.Size = new System.Drawing.Size(145, 24);
      this.menu.TabIndex = 34;
      this.menu.Text = "menuStrip1";
      this.menu.Visible = false;
      // 
      // ToolStripMenuItemOptions
      // 
      this.ToolStripMenuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSilence,
            this.toolStripMenuItemMinGap});
      this.ToolStripMenuItemOptions.Name = "ToolStripMenuItemOptions";
      this.ToolStripMenuItemOptions.Size = new System.Drawing.Size(143, 24);
      this.ToolStripMenuItemOptions.Text = "Auto Split Options";
      // 
      // toolStripMenuItemSilence
      // 
      this.toolStripMenuItemSilence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silenceMenuItem});
      this.toolStripMenuItemSilence.Name = "toolStripMenuItemSilence";
      this.toolStripMenuItemSilence.Size = new System.Drawing.Size(178, 26);
      this.toolStripMenuItemSilence.Text = "Silence";
      // 
      // silenceMenuItem
      // 
      this.silenceMenuItem.Name = "silenceMenuItem";
      this.silenceMenuItem.Size = new System.Drawing.Size(60, 27);
      this.silenceMenuItem.Text = "2000";
      this.silenceMenuItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.objectIntOnly_KeyPress);
      this.silenceMenuItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.silenceMenuItem_KeyUp);
      // 
      // toolStripMenuItemMinGap
      // 
      this.toolStripMenuItemMinGap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minGapMenuItem});
      this.toolStripMenuItemMinGap.Name = "toolStripMenuItemMinGap";
      this.toolStripMenuItemMinGap.Size = new System.Drawing.Size(178, 26);
      this.toolStripMenuItemMinGap.Text = "Minimum Gap";
      // 
      // minGapMenuItem
      // 
      this.minGapMenuItem.Name = "minGapMenuItem";
      this.minGapMenuItem.Size = new System.Drawing.Size(60, 27);
      this.minGapMenuItem.Text = "480000";
      this.minGapMenuItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.objectIntOnly_KeyPress);
      this.minGapMenuItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.minGapMenuItem_KeyUp);
      // 
      // btnSpliByStep
      // 
      this.btnSpliByStep.Location = new System.Drawing.Point(60, 464);
      this.btnSpliByStep.Name = "btnSpliByStep";
      this.btnSpliByStep.Size = new System.Drawing.Size(100, 35);
      this.btnSpliByStep.TabIndex = 35;
      this.btnSpliByStep.Text = "Split by step";
      this.btnSpliByStep.UseVisualStyleBackColor = true;
      this.btnSpliByStep.Click += new System.EventHandler(this.btnSpliByStep_Click);
      // 
      // splitStepTextBox
      // 
      this.splitStepTextBox.Location = new System.Drawing.Point(265, 464);
      this.splitStepTextBox.Name = "splitStepTextBox";
      this.splitStepTextBox.Size = new System.Drawing.Size(107, 22);
      this.splitStepTextBox.TabIndex = 36;
      this.splitStepTextBox.Text = "300";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1240, 578);
      this.Controls.Add(this.splitStepTextBox);
      this.Controls.Add(this.btnSpliByStep);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.editPositionLabel);
      this.Controls.Add(this.addFileButton);
      this.Controls.Add(this.fileRightButton);
      this.Controls.Add(this.fileLeftButton);
      this.Controls.Add(this.inputFileGroupbox);
      this.Controls.Add(this.destinationFilePathTextBox);
      this.Controls.Add(this.destinationLabel);
      this.Controls.Add(this.destinationBrowseButton);
      this.Controls.Add(this.sourceLabel);
      this.Controls.Add(this.sourceFilePathTextBox);
      this.Controls.Add(this.sourceBrowseButton);
      this.Controls.Add(this.menu);
      this.Controls.Add(this.btnAutoSplit);
      this.Controls.Add(this.encodeButton);
      this.MainMenuStrip = this.menu;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(1258, 625);
      this.MinimumSize = new System.Drawing.Size(1258, 625);
      this.Name = "MainForm";
      this.Text = "Cold Cuts";
      this.Shown += new System.EventHandler(this.MainForm_Shown);
      this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
      this.Click += new System.EventHandler(this.MainForm_Click);
      this.inputFileGroupbox.ResumeLayout(false);
      this.inputFileGroupbox.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.menu.ResumeLayout(false);
      this.menu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }


        #endregion

        public System.Windows.Forms.Button sourceBrowseButton;
        public System.Windows.Forms.TextBox sourceFilePathTextBox;
        public System.Windows.Forms.Label sourceLabel;
        public System.Windows.Forms.Button destinationBrowseButton;
        public System.Windows.Forms.Label destinationLabel;
        public  System.Windows.Forms.TextBox destinationFilePathTextBox;
        public System.Windows.Forms.GroupBox inputFileGroupbox;
        public System.Windows.Forms.Label artistLabel;
        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label titleInputLabel;
        public System.Windows.Forms.Label artistInputLabel;
        public System.Windows.Forms.Button encodeButton;
        public System.Windows.Forms.Label feedBackLabel;
        public System.Windows.Forms.Label feedBackLabel2;
        public System.Windows.Forms.Label lengthLabel;
        public System.Windows.Forms.Label lengthInputLabel;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button fileLeftButton;
        public System.Windows.Forms.Button fileRightButton;
        public System.Windows.Forms.Button addFileButton;
        public System.Windows.Forms.Label fileNameLabel;
        public System.Windows.Forms.TextBox fileNameOutputBox;
        public System.Windows.Forms.Label editPositionLabel;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.Label startLabel;
        public System.Windows.Forms.Label endLabel;
        public System.Windows.Forms.TextBox startMinTextBox;
        public System.Windows.Forms.TextBox startSecTextBox;
        public System.Windows.Forms.TextBox endMinTextBox;
        public System.Windows.Forms.TextBox endSecTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn gridtracknumber;
        public System.Windows.Forms.DataGridViewTextBoxColumn gridtrackname;
        public System.Windows.Forms.DataGridViewTextBoxColumn gridstarttime;
        public System.Windows.Forms.DataGridViewTextBoxColumn gridendtime;
        public System.ComponentModel.BackgroundWorker backgroundWorker;
        public System.Windows.Forms.Button btnAutoSplit;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox commentOutputTextBox;
        public System.Windows.Forms.Label commentOutputLabel;
        public System.Windows.Forms.TextBox albumOutputTextBox;
        public System.Windows.Forms.TextBox titleOutputTextBox;
        public System.Windows.Forms.TextBox artistOutputTextBox;
        public System.Windows.Forms.Label artistOutputLabel;
        public System.Windows.Forms.Label titleOutputLabel;
        public System.Windows.Forms.Label albumOutputLabel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSilence;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMinGap;
        private System.Windows.Forms.ToolStripTextBox silenceMenuItem;
        private System.Windows.Forms.ToolStripTextBox minGapMenuItem;
        private System.Windows.Forms.Button btnSpliByStep;
        private System.Windows.Forms.TextBox splitStepTextBox;
    }
}

