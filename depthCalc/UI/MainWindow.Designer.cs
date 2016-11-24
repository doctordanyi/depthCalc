﻿namespace DepthCalc.UI
{
    partial class MainWindow
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
            displayBuffer.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.dataImage = new System.Windows.Forms.PictureBox();
            this.openDataImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.group_matchResult_SQDIFF = new System.Windows.Forms.GroupBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preprocessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scalePreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale2PreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale4PreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale8PreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale16PreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale32PreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussPreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultGaussPreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dogPreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultDoGPreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customDoGPreprocMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizePreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearPreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQDIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normedSQDIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCORRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normedCCORRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCOEFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normedCCOEFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawReferenceViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preprocessedReferenceViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawDataViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preprocessedDataViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preprocRunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispRunStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postprocRunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_matchResult_NormedSQDIFF = new System.Windows.Forms.GroupBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.group_selectedRegion = new System.Windows.Forms.GroupBox();
            this.picture_selectedRegion = new System.Windows.Forms.PictureBox();
            this.saveResultImage = new System.Windows.Forms.SaveFileDialog();
            this.openReferenceImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.preprocListView = new System.Windows.Forms.ListView();
            this.step = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.browseDataButton = new System.Windows.Forms.Button();
            this.browseReferenceButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.procProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.procStepStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataImage)).BeginInit();
            this.group_matchResult_SQDIFF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.group_matchResult_NormedSQDIFF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            this.group_selectedRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_selectedRegion)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataImage
            // 
            this.dataImage.Enabled = false;
            this.dataImage.Location = new System.Drawing.Point(12, 29);
            this.dataImage.Name = "dataImage";
            this.dataImage.Size = new System.Drawing.Size(640, 512);
            this.dataImage.TabIndex = 0;
            this.dataImage.TabStop = false;
            this.dataImage.Click += new System.EventHandler(this.handle_dataImage_Click);
            // 
            // openDataImageDialog
            // 
            this.openDataImageDialog.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.png";
            this.openDataImageDialog.InitialDirectory = "D:\\onlab_kinect\\images";
            this.openDataImageDialog.Title = "Open Data Image";
            this.openDataImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.handle_openDataImage_FileOk);
            // 
            // group_matchResult_SQDIFF
            // 
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox60);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox59);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox58);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox57);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox56);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox11);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox10);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox9);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox8);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox7);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox6);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox5);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox4);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox3);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox2);
            this.group_matchResult_SQDIFF.Controls.Add(this.pictureBox1);
            this.group_matchResult_SQDIFF.Location = new System.Drawing.Point(6, 6);
            this.group_matchResult_SQDIFF.Name = "group_matchResult_SQDIFF";
            this.group_matchResult_SQDIFF.Size = new System.Drawing.Size(212, 760);
            this.group_matchResult_SQDIFF.TabIndex = 3;
            this.group_matchResult_SQDIFF.TabStop = false;
            this.group_matchResult_SQDIFF.Text = "SQDIFF";
            // 
            // pictureBox60
            // 
            this.pictureBox60.Location = new System.Drawing.Point(6, 709);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(200, 40);
            this.pictureBox60.TabIndex = 15;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.Location = new System.Drawing.Point(6, 387);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(200, 40);
            this.pictureBox59.TabIndex = 14;
            this.pictureBox59.TabStop = false;
            // 
            // pictureBox58
            // 
            this.pictureBox58.Location = new System.Drawing.Point(6, 617);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(200, 40);
            this.pictureBox58.TabIndex = 13;
            this.pictureBox58.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.Location = new System.Drawing.Point(6, 571);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(200, 40);
            this.pictureBox57.TabIndex = 12;
            this.pictureBox57.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.Location = new System.Drawing.Point(6, 525);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(200, 40);
            this.pictureBox56.TabIndex = 11;
            this.pictureBox56.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(6, 479);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(200, 40);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(6, 433);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(200, 40);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(6, 663);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(200, 40);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(6, 341);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(200, 40);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(6, 295);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(200, 40);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(6, 249);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 40);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(6, 203);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 40);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(6, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 40);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(6, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 40);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 40);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preprocessingToolStripMenuItem,
            this.matchMethodToolStripMenuItem,
            this.viewMenuItem,
            this.runMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1149, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openReferenceToolStripMenuItem,
            this.openDataToolStripMenuItem,
            this.saveFileMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openReferenceToolStripMenuItem
            // 
            this.openReferenceToolStripMenuItem.Name = "openReferenceToolStripMenuItem";
            this.openReferenceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openReferenceToolStripMenuItem.Text = "Open Reference";
            this.openReferenceToolStripMenuItem.Click += new System.EventHandler(this.openReferenceToolStripMenuItem_Click);
            // 
            // openDataToolStripMenuItem
            // 
            this.openDataToolStripMenuItem.Name = "openDataToolStripMenuItem";
            this.openDataToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openDataToolStripMenuItem.Text = "Open Data";
            this.openDataToolStripMenuItem.Click += new System.EventHandler(this.openDataToolStripMenuItem_Click);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(158, 22);
            this.saveFileMenuItem.Text = "Save Output";
            this.saveFileMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // preprocessingToolStripMenuItem
            // 
            this.preprocessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scalePreprocMenuItem,
            this.gaussPreprocMenuItem,
            this.dogPreprocMenuItem,
            this.normalizePreprocMenuItem,
            this.toolStripSeparator1,
            this.clearPreprocMenuItem});
            this.preprocessingToolStripMenuItem.Name = "preprocessingToolStripMenuItem";
            this.preprocessingToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.preprocessingToolStripMenuItem.Text = "Preprocessing";
            // 
            // scalePreprocMenuItem
            // 
            this.scalePreprocMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scale2PreprocMenuItem,
            this.scale4PreprocMenuItem,
            this.scale8PreprocMenuItem,
            this.scale16PreprocMenuItem,
            this.scale32PreprocMenuItem,
            this.otherToolStripMenuItem});
            this.scalePreprocMenuItem.Name = "scalePreprocMenuItem";
            this.scalePreprocMenuItem.Size = new System.Drawing.Size(145, 22);
            this.scalePreprocMenuItem.Text = "Scale";
            // 
            // scale2PreprocMenuItem
            // 
            this.scale2PreprocMenuItem.Name = "scale2PreprocMenuItem";
            this.scale2PreprocMenuItem.Size = new System.Drawing.Size(104, 22);
            this.scale2PreprocMenuItem.Text = "1/2";
            this.scale2PreprocMenuItem.Click += new System.EventHandler(this.scale2PreprocMenuItem_Click);
            // 
            // scale4PreprocMenuItem
            // 
            this.scale4PreprocMenuItem.Name = "scale4PreprocMenuItem";
            this.scale4PreprocMenuItem.Size = new System.Drawing.Size(104, 22);
            this.scale4PreprocMenuItem.Text = "1/4";
            this.scale4PreprocMenuItem.Click += new System.EventHandler(this.scale4PreprocMenuItem_Click);
            // 
            // scale8PreprocMenuItem
            // 
            this.scale8PreprocMenuItem.Name = "scale8PreprocMenuItem";
            this.scale8PreprocMenuItem.Size = new System.Drawing.Size(104, 22);
            this.scale8PreprocMenuItem.Text = "1/8";
            this.scale8PreprocMenuItem.Click += new System.EventHandler(this.scale8PreprocMenuItem_Click);
            // 
            // scale16PreprocMenuItem
            // 
            this.scale16PreprocMenuItem.Name = "scale16PreprocMenuItem";
            this.scale16PreprocMenuItem.Size = new System.Drawing.Size(104, 22);
            this.scale16PreprocMenuItem.Text = "1/16";
            this.scale16PreprocMenuItem.Click += new System.EventHandler(this.scale16PreprocMenuItem_Click);
            // 
            // scale32PreprocMenuItem
            // 
            this.scale32PreprocMenuItem.Name = "scale32PreprocMenuItem";
            this.scale32PreprocMenuItem.Size = new System.Drawing.Size(104, 22);
            this.scale32PreprocMenuItem.Text = "1/32";
            this.scale32PreprocMenuItem.Click += new System.EventHandler(this.scale32PreprocMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // gaussPreprocMenuItem
            // 
            this.gaussPreprocMenuItem.CheckOnClick = true;
            this.gaussPreprocMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultGaussPreprocMenuItem,
            this.customToolStripMenuItem});
            this.gaussPreprocMenuItem.Name = "gaussPreprocMenuItem";
            this.gaussPreprocMenuItem.Size = new System.Drawing.Size(145, 22);
            this.gaussPreprocMenuItem.Text = "Gaussian Blur";
            // 
            // defaultGaussPreprocMenuItem
            // 
            this.defaultGaussPreprocMenuItem.Name = "defaultGaussPreprocMenuItem";
            this.defaultGaussPreprocMenuItem.Size = new System.Drawing.Size(116, 22);
            this.defaultGaussPreprocMenuItem.Text = "Default";
            this.defaultGaussPreprocMenuItem.Click += new System.EventHandler(this.defaultGaussPreprocMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.customToolStripMenuItem.Text = "Custom";
            // 
            // dogPreprocMenuItem
            // 
            this.dogPreprocMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultDoGPreprocMenuItem,
            this.customDoGPreprocMenuItem1});
            this.dogPreprocMenuItem.Name = "dogPreprocMenuItem";
            this.dogPreprocMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dogPreprocMenuItem.Text = "DoG";
            // 
            // defaultDoGPreprocMenuItem
            // 
            this.defaultDoGPreprocMenuItem.Name = "defaultDoGPreprocMenuItem";
            this.defaultDoGPreprocMenuItem.Size = new System.Drawing.Size(116, 22);
            this.defaultDoGPreprocMenuItem.Text = "Default";
            this.defaultDoGPreprocMenuItem.Click += new System.EventHandler(this.defaultDoGPreprocMenuItem_Click);
            // 
            // customDoGPreprocMenuItem1
            // 
            this.customDoGPreprocMenuItem1.Name = "customDoGPreprocMenuItem1";
            this.customDoGPreprocMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.customDoGPreprocMenuItem1.Text = "Custom";
            // 
            // normalizePreprocMenuItem
            // 
            this.normalizePreprocMenuItem.Name = "normalizePreprocMenuItem";
            this.normalizePreprocMenuItem.Size = new System.Drawing.Size(145, 22);
            this.normalizePreprocMenuItem.Text = "Normalize";
            this.normalizePreprocMenuItem.Click += new System.EventHandler(this.normalizePreprocMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // clearPreprocMenuItem
            // 
            this.clearPreprocMenuItem.Name = "clearPreprocMenuItem";
            this.clearPreprocMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clearPreprocMenuItem.Text = "Clear";
            this.clearPreprocMenuItem.Click += new System.EventHandler(this.clearPreprocMenuItem_Click);
            // 
            // matchMethodToolStripMenuItem
            // 
            this.matchMethodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQDIFFToolStripMenuItem,
            this.normedSQDIFFToolStripMenuItem,
            this.cCORRToolStripMenuItem,
            this.normedCCORRToolStripMenuItem,
            this.cCOEFFToolStripMenuItem,
            this.normedCCOEFFToolStripMenuItem});
            this.matchMethodToolStripMenuItem.Name = "matchMethodToolStripMenuItem";
            this.matchMethodToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.matchMethodToolStripMenuItem.Text = "Match Method";
            // 
            // sQDIFFToolStripMenuItem
            // 
            this.sQDIFFToolStripMenuItem.CheckOnClick = true;
            this.sQDIFFToolStripMenuItem.Name = "sQDIFFToolStripMenuItem";
            this.sQDIFFToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sQDIFFToolStripMenuItem.Text = "SQDIFF";
            this.sQDIFFToolStripMenuItem.Click += new System.EventHandler(this.handle_sQDIFFToolStripMenuItem_Click);
            // 
            // normedSQDIFFToolStripMenuItem
            // 
            this.normedSQDIFFToolStripMenuItem.CheckOnClick = true;
            this.normedSQDIFFToolStripMenuItem.Name = "normedSQDIFFToolStripMenuItem";
            this.normedSQDIFFToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.normedSQDIFFToolStripMenuItem.Text = "SQDIFF_NORMED";
            this.normedSQDIFFToolStripMenuItem.Click += new System.EventHandler(this.handle_normedSQDIFFToolStripMenuItem_Click);
            // 
            // cCORRToolStripMenuItem
            // 
            this.cCORRToolStripMenuItem.CheckOnClick = true;
            this.cCORRToolStripMenuItem.Name = "cCORRToolStripMenuItem";
            this.cCORRToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cCORRToolStripMenuItem.Text = "CCORR";
            this.cCORRToolStripMenuItem.Click += new System.EventHandler(this.handle_cCORRToolStripMenuItem_Click);
            // 
            // normedCCORRToolStripMenuItem
            // 
            this.normedCCORRToolStripMenuItem.CheckOnClick = true;
            this.normedCCORRToolStripMenuItem.Name = "normedCCORRToolStripMenuItem";
            this.normedCCORRToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.normedCCORRToolStripMenuItem.Text = "CCORR_NORMED";
            this.normedCCORRToolStripMenuItem.Click += new System.EventHandler(this.handle_normedCCORRToolStripMenuItem_Click);
            // 
            // cCOEFFToolStripMenuItem
            // 
            this.cCOEFFToolStripMenuItem.CheckOnClick = true;
            this.cCOEFFToolStripMenuItem.Name = "cCOEFFToolStripMenuItem";
            this.cCOEFFToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cCOEFFToolStripMenuItem.Text = "CCOEFF";
            this.cCOEFFToolStripMenuItem.Click += new System.EventHandler(this.handle_cCOEFFToolStripMenuItem_Click);
            // 
            // normedCCOEFFToolStripMenuItem
            // 
            this.normedCCOEFFToolStripMenuItem.Checked = true;
            this.normedCCOEFFToolStripMenuItem.CheckOnClick = true;
            this.normedCCOEFFToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normedCCOEFFToolStripMenuItem.Name = "normedCCOEFFToolStripMenuItem";
            this.normedCCOEFFToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.normedCCOEFFToolStripMenuItem.Text = "CCOEFF_NORMED";
            this.normedCCOEFFToolStripMenuItem.Click += new System.EventHandler(this.handle_normedCCOEFFToolStripMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenceViewMenuItem,
            this.dataViewMenuItem,
            this.resultViewMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "View";
            // 
            // referenceViewMenuItem
            // 
            this.referenceViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawReferenceViewMenuItem,
            this.preprocessedReferenceViewMenuItem});
            this.referenceViewMenuItem.Enabled = false;
            this.referenceViewMenuItem.Name = "referenceViewMenuItem";
            this.referenceViewMenuItem.Size = new System.Drawing.Size(126, 22);
            this.referenceViewMenuItem.Text = "Reference";
            // 
            // rawReferenceViewMenuItem
            // 
            this.rawReferenceViewMenuItem.Enabled = false;
            this.rawReferenceViewMenuItem.Name = "rawReferenceViewMenuItem";
            this.rawReferenceViewMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rawReferenceViewMenuItem.Text = "Raw";
            this.rawReferenceViewMenuItem.Click += new System.EventHandler(this.rawReferenceViewMenuItem_Click);
            // 
            // preprocessedReferenceViewMenuItem
            // 
            this.preprocessedReferenceViewMenuItem.Enabled = false;
            this.preprocessedReferenceViewMenuItem.Name = "preprocessedReferenceViewMenuItem";
            this.preprocessedReferenceViewMenuItem.Size = new System.Drawing.Size(144, 22);
            this.preprocessedReferenceViewMenuItem.Text = "Preprocessed";
            this.preprocessedReferenceViewMenuItem.Click += new System.EventHandler(this.preprocessedReferenceViewMenuItem_Click);
            // 
            // dataViewMenuItem
            // 
            this.dataViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawDataViewMenuItem,
            this.preprocessedDataViewMenuItem});
            this.dataViewMenuItem.Enabled = false;
            this.dataViewMenuItem.Name = "dataViewMenuItem";
            this.dataViewMenuItem.Size = new System.Drawing.Size(126, 22);
            this.dataViewMenuItem.Text = "Data";
            // 
            // rawDataViewMenuItem
            // 
            this.rawDataViewMenuItem.Enabled = false;
            this.rawDataViewMenuItem.Name = "rawDataViewMenuItem";
            this.rawDataViewMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rawDataViewMenuItem.Text = "Raw";
            this.rawDataViewMenuItem.Click += new System.EventHandler(this.rawDataViewMenuItem_Click);
            // 
            // preprocessedDataViewMenuItem
            // 
            this.preprocessedDataViewMenuItem.Enabled = false;
            this.preprocessedDataViewMenuItem.Name = "preprocessedDataViewMenuItem";
            this.preprocessedDataViewMenuItem.Size = new System.Drawing.Size(144, 22);
            this.preprocessedDataViewMenuItem.Text = "Preprocessed";
            this.preprocessedDataViewMenuItem.Click += new System.EventHandler(this.preprocessedDataViewMenuItem_Click);
            // 
            // resultViewMenuItem
            // 
            this.resultViewMenuItem.Enabled = false;
            this.resultViewMenuItem.Name = "resultViewMenuItem";
            this.resultViewMenuItem.Size = new System.Drawing.Size(126, 22);
            this.resultViewMenuItem.Text = "Result";
            // 
            // runMenuItem
            // 
            this.runMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preprocRunMenuItem,
            this.dispRunStripMenuItem,
            this.postprocRunMenuItem,
            this.allRunMenuItem});
            this.runMenuItem.Name = "runMenuItem";
            this.runMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runMenuItem.Text = "Run";
            // 
            // preprocRunMenuItem
            // 
            this.preprocRunMenuItem.Enabled = false;
            this.preprocRunMenuItem.Name = "preprocRunMenuItem";
            this.preprocRunMenuItem.Size = new System.Drawing.Size(175, 22);
            this.preprocRunMenuItem.Text = "Preprocessor";
            this.preprocRunMenuItem.Click += new System.EventHandler(this.preprocRunMenuItem_Click);
            // 
            // dispRunStripMenuItem
            // 
            this.dispRunStripMenuItem.Enabled = false;
            this.dispRunStripMenuItem.Name = "dispRunStripMenuItem";
            this.dispRunStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.dispRunStripMenuItem.Text = "Disparity calculator";
            this.dispRunStripMenuItem.Click += new System.EventHandler(this.dispRunStripMenuItem_Click);
            // 
            // postprocRunMenuItem
            // 
            this.postprocRunMenuItem.Enabled = false;
            this.postprocRunMenuItem.Name = "postprocRunMenuItem";
            this.postprocRunMenuItem.Size = new System.Drawing.Size(175, 22);
            this.postprocRunMenuItem.Text = "Postprocessor";
            this.postprocRunMenuItem.Click += new System.EventHandler(this.postprocRunMenuItem_Click);
            // 
            // allRunMenuItem
            // 
            this.allRunMenuItem.Enabled = false;
            this.allRunMenuItem.Name = "allRunMenuItem";
            this.allRunMenuItem.Size = new System.Drawing.Size(175, 22);
            this.allRunMenuItem.Text = "All";
            this.allRunMenuItem.Click += new System.EventHandler(this.allRunMenuItem_Click);
            // 
            // group_matchResult_NormedSQDIFF
            // 
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox65);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox64);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox63);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox62);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox61);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox12);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox13);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox14);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox15);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox16);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox17);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox18);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox19);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox20);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox21);
            this.group_matchResult_NormedSQDIFF.Controls.Add(this.pictureBox22);
            this.group_matchResult_NormedSQDIFF.Location = new System.Drawing.Point(224, 6);
            this.group_matchResult_NormedSQDIFF.Name = "group_matchResult_NormedSQDIFF";
            this.group_matchResult_NormedSQDIFF.Size = new System.Drawing.Size(212, 760);
            this.group_matchResult_NormedSQDIFF.TabIndex = 11;
            this.group_matchResult_NormedSQDIFF.TabStop = false;
            this.group_matchResult_NormedSQDIFF.Text = "Normed SQDIFF";
            // 
            // pictureBox65
            // 
            this.pictureBox65.Location = new System.Drawing.Point(6, 709);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(200, 40);
            this.pictureBox65.TabIndex = 15;
            this.pictureBox65.TabStop = false;
            // 
            // pictureBox64
            // 
            this.pictureBox64.Location = new System.Drawing.Point(6, 663);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(200, 40);
            this.pictureBox64.TabIndex = 14;
            this.pictureBox64.TabStop = false;
            // 
            // pictureBox63
            // 
            this.pictureBox63.Location = new System.Drawing.Point(6, 617);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(200, 40);
            this.pictureBox63.TabIndex = 13;
            this.pictureBox63.TabStop = false;
            // 
            // pictureBox62
            // 
            this.pictureBox62.Location = new System.Drawing.Point(6, 571);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(200, 40);
            this.pictureBox62.TabIndex = 12;
            this.pictureBox62.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.Location = new System.Drawing.Point(6, 525);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(200, 40);
            this.pictureBox61.TabIndex = 11;
            this.pictureBox61.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(6, 479);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(200, 40);
            this.pictureBox12.TabIndex = 10;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(6, 433);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(200, 40);
            this.pictureBox13.TabIndex = 9;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(6, 387);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(200, 40);
            this.pictureBox14.TabIndex = 8;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(6, 341);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(200, 40);
            this.pictureBox15.TabIndex = 7;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(6, 295);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(200, 40);
            this.pictureBox16.TabIndex = 6;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(6, 249);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(200, 40);
            this.pictureBox17.TabIndex = 5;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(6, 203);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(200, 40);
            this.pictureBox18.TabIndex = 4;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(6, 157);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(200, 40);
            this.pictureBox19.TabIndex = 3;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(6, 111);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(200, 40);
            this.pictureBox20.TabIndex = 2;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(6, 65);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(200, 40);
            this.pictureBox21.TabIndex = 1;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(6, 19);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(200, 40);
            this.pictureBox22.TabIndex = 0;
            this.pictureBox22.TabStop = false;
            // 
            // group_selectedRegion
            // 
            this.group_selectedRegion.Controls.Add(this.picture_selectedRegion);
            this.group_selectedRegion.Location = new System.Drawing.Point(8, 547);
            this.group_selectedRegion.Name = "group_selectedRegion";
            this.group_selectedRegion.Size = new System.Drawing.Size(652, 288);
            this.group_selectedRegion.TabIndex = 15;
            this.group_selectedRegion.TabStop = false;
            this.group_selectedRegion.Text = "Selected Region";
            // 
            // picture_selectedRegion
            // 
            this.picture_selectedRegion.Location = new System.Drawing.Point(4, 15);
            this.picture_selectedRegion.Name = "picture_selectedRegion";
            this.picture_selectedRegion.Size = new System.Drawing.Size(640, 269);
            this.picture_selectedRegion.TabIndex = 0;
            this.picture_selectedRegion.TabStop = false;
            // 
            // saveResultImage
            // 
            this.saveResultImage.InitialDirectory = "D:\\onlab_kinect\\images\\out";
            this.saveResultImage.FileOk += new System.ComponentModel.CancelEventHandler(this.saveResultImage_FileOk);
            // 
            // openReferenceImageDialog
            // 
            this.openReferenceImageDialog.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.png";
            this.openReferenceImageDialog.InitialDirectory = "D:\\onlab_kinect\\images";
            this.openReferenceImageDialog.Title = "Open Reference Image";
            this.openReferenceImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openReferenceImageDialog_FileOk);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(666, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 806);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 780);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 567);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 185);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Postprocessing";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.numericUpDown4);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disparity calculation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.preprocListView);
            this.groupBox2.Location = new System.Drawing.Point(6, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preprocessing";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preprocessing queue";
            // 
            // preprocListView
            // 
            this.preprocListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.step});
            this.preprocListView.FullRowSelect = true;
            this.preprocListView.GridLines = true;
            this.preprocListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.preprocListView.Location = new System.Drawing.Point(6, 119);
            this.preprocListView.Name = "preprocListView";
            this.preprocListView.Size = new System.Drawing.Size(424, 111);
            this.preprocListView.TabIndex = 0;
            this.preprocListView.TabStop = false;
            this.preprocListView.UseCompatibleStateImageBehavior = false;
            this.preprocListView.View = System.Windows.Forms.View.List;
            this.preprocListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // step
            // 
            this.step.Text = "step";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.browseDataButton);
            this.groupBox1.Controls.Add(this.browseReferenceButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reference";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data";
            // 
            // browseDataButton
            // 
            this.browseDataButton.Location = new System.Drawing.Point(370, 54);
            this.browseDataButton.Name = "browseDataButton";
            this.browseDataButton.Size = new System.Drawing.Size(60, 20);
            this.browseDataButton.TabIndex = 3;
            this.browseDataButton.Text = "Browse";
            this.browseDataButton.UseVisualStyleBackColor = true;
            this.browseDataButton.Click += new System.EventHandler(this.browseDataButton_Click);
            // 
            // browseReferenceButton
            // 
            this.browseReferenceButton.Location = new System.Drawing.Point(370, 28);
            this.browseReferenceButton.Name = "browseReferenceButton";
            this.browseReferenceButton.Size = new System.Drawing.Size(60, 20);
            this.browseReferenceButton.TabIndex = 2;
            this.browseReferenceButton.Text = "Browse";
            this.browseReferenceButton.UseVisualStyleBackColor = true;
            this.browseReferenceButton.Click += new System.EventHandler(this.browseReferenceButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(295, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(295, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.group_matchResult_SQDIFF);
            this.tabPage2.Controls.Add(this.group_matchResult_NormedSQDIFF);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 780);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Match visaulization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procProgressBar,
            this.procStepStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 837);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1149, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // procProgressBar
            // 
            this.procProgressBar.Name = "procProgressBar";
            this.procProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // procStepStatusLabel
            // 
            this.procStepStatusLabel.Name = "procStepStatusLabel";
            this.procStepStatusLabel.Size = new System.Drawing.Size(26, 17);
            this.procStepStatusLabel.Text = "Idle";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 51);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(185, 51);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(109, 77);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown3.TabIndex = 3;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(185, 79);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown4.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(250, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "default";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(250, 78);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(47, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "auto";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Match method:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sample size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Window size:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "W:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "H:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "H:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "W:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 859);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.group_selectedRegion);
            this.Controls.Add(this.dataImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Kinect Raw Data Processing";
            ((System.ComponentModel.ISupportInitialize)(this.dataImage)).EndInit();
            this.group_matchResult_SQDIFF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group_matchResult_NormedSQDIFF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            this.group_selectedRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_selectedRegion)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dataImage;
        private System.Windows.Forms.OpenFileDialog openDataImageDialog;
        private System.Windows.Forms.GroupBox group_matchResult_SQDIFF;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preprocessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scalePreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussPreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dogPreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQDIFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normedSQDIFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCORRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normedCCORRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCOEFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normedCCOEFFToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.GroupBox group_matchResult_NormedSQDIFF;
        private System.Windows.Forms.PictureBox pictureBox60;
        private System.Windows.Forms.PictureBox pictureBox59;
        private System.Windows.Forms.PictureBox pictureBox58;
        private System.Windows.Forms.PictureBox pictureBox57;
        private System.Windows.Forms.PictureBox pictureBox56;
        private System.Windows.Forms.PictureBox pictureBox65;
        private System.Windows.Forms.PictureBox pictureBox64;
        private System.Windows.Forms.PictureBox pictureBox63;
        private System.Windows.Forms.PictureBox pictureBox62;
        private System.Windows.Forms.PictureBox pictureBox61;
        private System.Windows.Forms.GroupBox group_selectedRegion;
        private System.Windows.Forms.PictureBox picture_selectedRegion;
        private System.Windows.Forms.SaveFileDialog saveResultImage;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawReferenceViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preprocessedReferenceViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawDataViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preprocessedDataViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultViewMenuItem;
        private System.Windows.Forms.OpenFileDialog openReferenceImageDialog;
        private System.Windows.Forms.ToolStripMenuItem scale2PreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale4PreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale8PreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale16PreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale32PreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clearPreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultGaussPreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultDoGPreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customDoGPreprocMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem normalizePreprocMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView preprocListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader step;
        private System.Windows.Forms.Button browseDataButton;
        private System.Windows.Forms.Button browseReferenceButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem runMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preprocRunMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispRunStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postprocRunMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRunMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar procProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel procStepStatusLabel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}