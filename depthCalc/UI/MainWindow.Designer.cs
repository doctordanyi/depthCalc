namespace depthCalc
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataImage = new System.Windows.Forms.PictureBox();
            this.openDataImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_runDepthprocessor = new System.Windows.Forms.Button();
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
            this.group_matchResult_NormedCCORR = new System.Windows.Forms.GroupBox();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.group_matchResult_CCOEFF = new System.Windows.Forms.GroupBox();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.pictureBox74 = new System.Windows.Forms.PictureBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.group_matchResult_NormedCCOEFF = new System.Windows.Forms.GroupBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.pictureBox79 = new System.Windows.Forms.PictureBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.pictureBox77 = new System.Windows.Forms.PictureBox();
            this.pictureBox76 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.group_selectedRegion = new System.Windows.Forms.GroupBox();
            this.picture_selectedRegion = new System.Windows.Forms.PictureBox();
            this.saveResultImage = new System.Windows.Forms.SaveFileDialog();
            this.openReferenceImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.group_Run = new System.Windows.Forms.GroupBox();
            this.button_runAll = new System.Windows.Forms.Button();
            this.button_runPostprocessor = new System.Windows.Forms.Button();
            this.button_runPreprocessor = new System.Windows.Forms.Button();
            this.normalizePreprocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.group_matchResult_NormedCCORR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            this.group_matchResult_CCOEFF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            this.group_matchResult_NormedCCOEFF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            this.group_selectedRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_selectedRegion)).BeginInit();
            this.group_Run.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataImage
            // 
            this.dataImage.Enabled = false;
            this.dataImage.Location = new System.Drawing.Point(20, 51);
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
            // button_runDepthprocessor
            // 
            this.button_runDepthprocessor.Enabled = false;
            this.button_runDepthprocessor.Location = new System.Drawing.Point(6, 53);
            this.button_runDepthprocessor.Name = "button_runDepthprocessor";
            this.button_runDepthprocessor.Size = new System.Drawing.Size(158, 25);
            this.button_runDepthprocessor.TabIndex = 2;
            this.button_runDepthprocessor.Text = "Disparity calculator";
            this.button_runDepthprocessor.UseVisualStyleBackColor = true;
            this.button_runDepthprocessor.Click += new System.EventHandler(this.button_runDepthprocessor_Click);
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
            this.group_matchResult_SQDIFF.Location = new System.Drawing.Point(668, 44);
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
            this.viewMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1764, 24);
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
            this.saveFileMenuItem.Enabled = false;
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
            this.scalePreprocMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.gaussPreprocMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.dogPreprocMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dogPreprocMenuItem.Text = "DoG";
            // 
            // defaultDoGPreprocMenuItem
            // 
            this.defaultDoGPreprocMenuItem.Name = "defaultDoGPreprocMenuItem";
            this.defaultDoGPreprocMenuItem.Size = new System.Drawing.Size(152, 22);
            this.defaultDoGPreprocMenuItem.Text = "Default";
            this.defaultDoGPreprocMenuItem.Click += new System.EventHandler(this.defaultDoGPreprocMenuItem_Click);
            // 
            // customDoGPreprocMenuItem1
            // 
            this.customDoGPreprocMenuItem1.Name = "customDoGPreprocMenuItem1";
            this.customDoGPreprocMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.customDoGPreprocMenuItem1.Text = "Custom";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // clearPreprocMenuItem
            // 
            this.clearPreprocMenuItem.Name = "clearPreprocMenuItem";
            this.clearPreprocMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.group_matchResult_NormedSQDIFF.Location = new System.Drawing.Point(886, 44);
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
            // group_matchResult_NormedCCORR
            // 
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox70);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox69);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox68);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox67);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox66);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox23);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox24);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox25);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox26);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox27);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox28);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox29);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox30);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox31);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox32);
            this.group_matchResult_NormedCCORR.Controls.Add(this.pictureBox33);
            this.group_matchResult_NormedCCORR.Location = new System.Drawing.Point(1104, 44);
            this.group_matchResult_NormedCCORR.Name = "group_matchResult_NormedCCORR";
            this.group_matchResult_NormedCCORR.Size = new System.Drawing.Size(212, 760);
            this.group_matchResult_NormedCCORR.TabIndex = 12;
            this.group_matchResult_NormedCCORR.TabStop = false;
            this.group_matchResult_NormedCCORR.Text = "Normed CCORR";
            // 
            // pictureBox70
            // 
            this.pictureBox70.Location = new System.Drawing.Point(6, 709);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(200, 40);
            this.pictureBox70.TabIndex = 20;
            this.pictureBox70.TabStop = false;
            // 
            // pictureBox69
            // 
            this.pictureBox69.Location = new System.Drawing.Point(6, 663);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(200, 40);
            this.pictureBox69.TabIndex = 19;
            this.pictureBox69.TabStop = false;
            // 
            // pictureBox68
            // 
            this.pictureBox68.Location = new System.Drawing.Point(6, 617);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(200, 40);
            this.pictureBox68.TabIndex = 18;
            this.pictureBox68.TabStop = false;
            // 
            // pictureBox67
            // 
            this.pictureBox67.Location = new System.Drawing.Point(6, 571);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(200, 40);
            this.pictureBox67.TabIndex = 17;
            this.pictureBox67.TabStop = false;
            // 
            // pictureBox66
            // 
            this.pictureBox66.Location = new System.Drawing.Point(6, 525);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(200, 40);
            this.pictureBox66.TabIndex = 16;
            this.pictureBox66.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(6, 479);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(200, 40);
            this.pictureBox23.TabIndex = 10;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(6, 433);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(200, 40);
            this.pictureBox24.TabIndex = 9;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(6, 387);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(200, 40);
            this.pictureBox25.TabIndex = 8;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Location = new System.Drawing.Point(6, 341);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(200, 40);
            this.pictureBox26.TabIndex = 7;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Location = new System.Drawing.Point(6, 295);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(200, 40);
            this.pictureBox27.TabIndex = 6;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Location = new System.Drawing.Point(6, 249);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(200, 40);
            this.pictureBox28.TabIndex = 5;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Location = new System.Drawing.Point(6, 203);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(200, 40);
            this.pictureBox29.TabIndex = 4;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Location = new System.Drawing.Point(6, 157);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(200, 40);
            this.pictureBox30.TabIndex = 3;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Location = new System.Drawing.Point(6, 111);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(200, 40);
            this.pictureBox31.TabIndex = 2;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Location = new System.Drawing.Point(6, 65);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(200, 40);
            this.pictureBox32.TabIndex = 1;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Location = new System.Drawing.Point(6, 19);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(200, 40);
            this.pictureBox33.TabIndex = 0;
            this.pictureBox33.TabStop = false;
            // 
            // group_matchResult_CCOEFF
            // 
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox75);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox74);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox73);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox72);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox71);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox34);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox35);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox36);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox37);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox38);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox39);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox40);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox41);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox42);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox43);
            this.group_matchResult_CCOEFF.Controls.Add(this.pictureBox44);
            this.group_matchResult_CCOEFF.Location = new System.Drawing.Point(1322, 44);
            this.group_matchResult_CCOEFF.Name = "group_matchResult_CCOEFF";
            this.group_matchResult_CCOEFF.Size = new System.Drawing.Size(212, 760);
            this.group_matchResult_CCOEFF.TabIndex = 11;
            this.group_matchResult_CCOEFF.TabStop = false;
            this.group_matchResult_CCOEFF.Text = "CCOEFF";
            // 
            // pictureBox75
            // 
            this.pictureBox75.Location = new System.Drawing.Point(6, 709);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(200, 40);
            this.pictureBox75.TabIndex = 25;
            this.pictureBox75.TabStop = false;
            // 
            // pictureBox74
            // 
            this.pictureBox74.Location = new System.Drawing.Point(6, 663);
            this.pictureBox74.Name = "pictureBox74";
            this.pictureBox74.Size = new System.Drawing.Size(200, 40);
            this.pictureBox74.TabIndex = 24;
            this.pictureBox74.TabStop = false;
            // 
            // pictureBox73
            // 
            this.pictureBox73.Location = new System.Drawing.Point(6, 617);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(200, 40);
            this.pictureBox73.TabIndex = 23;
            this.pictureBox73.TabStop = false;
            // 
            // pictureBox72
            // 
            this.pictureBox72.Location = new System.Drawing.Point(6, 571);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(200, 40);
            this.pictureBox72.TabIndex = 22;
            this.pictureBox72.TabStop = false;
            // 
            // pictureBox71
            // 
            this.pictureBox71.Location = new System.Drawing.Point(6, 525);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(200, 40);
            this.pictureBox71.TabIndex = 21;
            this.pictureBox71.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Location = new System.Drawing.Point(6, 479);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(200, 40);
            this.pictureBox34.TabIndex = 10;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Location = new System.Drawing.Point(6, 433);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(200, 40);
            this.pictureBox35.TabIndex = 9;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Location = new System.Drawing.Point(6, 387);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(200, 40);
            this.pictureBox36.TabIndex = 8;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Location = new System.Drawing.Point(6, 341);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(200, 40);
            this.pictureBox37.TabIndex = 7;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Location = new System.Drawing.Point(6, 295);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(200, 40);
            this.pictureBox38.TabIndex = 6;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Location = new System.Drawing.Point(6, 249);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(200, 40);
            this.pictureBox39.TabIndex = 5;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Location = new System.Drawing.Point(6, 203);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(200, 40);
            this.pictureBox40.TabIndex = 4;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Location = new System.Drawing.Point(6, 157);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(200, 40);
            this.pictureBox41.TabIndex = 3;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Location = new System.Drawing.Point(6, 111);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(200, 40);
            this.pictureBox42.TabIndex = 2;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Location = new System.Drawing.Point(6, 65);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(200, 40);
            this.pictureBox43.TabIndex = 1;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Location = new System.Drawing.Point(6, 19);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(200, 40);
            this.pictureBox44.TabIndex = 0;
            this.pictureBox44.TabStop = false;
            // 
            // group_matchResult_NormedCCOEFF
            // 
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox80);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox79);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox78);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox77);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox76);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox45);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox46);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox47);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox48);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox49);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox50);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox51);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox52);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox53);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox54);
            this.group_matchResult_NormedCCOEFF.Controls.Add(this.pictureBox55);
            this.group_matchResult_NormedCCOEFF.Location = new System.Drawing.Point(1540, 44);
            this.group_matchResult_NormedCCOEFF.Name = "group_matchResult_NormedCCOEFF";
            this.group_matchResult_NormedCCOEFF.Size = new System.Drawing.Size(212, 760);
            this.group_matchResult_NormedCCOEFF.TabIndex = 13;
            this.group_matchResult_NormedCCOEFF.TabStop = false;
            this.group_matchResult_NormedCCOEFF.Text = "Normed CCOEFF";
            // 
            // pictureBox80
            // 
            this.pictureBox80.Location = new System.Drawing.Point(6, 709);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(200, 40);
            this.pictureBox80.TabIndex = 30;
            this.pictureBox80.TabStop = false;
            // 
            // pictureBox79
            // 
            this.pictureBox79.Location = new System.Drawing.Point(6, 663);
            this.pictureBox79.Name = "pictureBox79";
            this.pictureBox79.Size = new System.Drawing.Size(200, 40);
            this.pictureBox79.TabIndex = 29;
            this.pictureBox79.TabStop = false;
            // 
            // pictureBox78
            // 
            this.pictureBox78.Location = new System.Drawing.Point(6, 617);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(200, 40);
            this.pictureBox78.TabIndex = 28;
            this.pictureBox78.TabStop = false;
            // 
            // pictureBox77
            // 
            this.pictureBox77.Location = new System.Drawing.Point(6, 571);
            this.pictureBox77.Name = "pictureBox77";
            this.pictureBox77.Size = new System.Drawing.Size(200, 40);
            this.pictureBox77.TabIndex = 27;
            this.pictureBox77.TabStop = false;
            // 
            // pictureBox76
            // 
            this.pictureBox76.Location = new System.Drawing.Point(6, 525);
            this.pictureBox76.Name = "pictureBox76";
            this.pictureBox76.Size = new System.Drawing.Size(200, 40);
            this.pictureBox76.TabIndex = 26;
            this.pictureBox76.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Location = new System.Drawing.Point(6, 479);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(200, 40);
            this.pictureBox45.TabIndex = 10;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.Location = new System.Drawing.Point(6, 433);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(200, 40);
            this.pictureBox46.TabIndex = 9;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox47
            // 
            this.pictureBox47.Location = new System.Drawing.Point(6, 387);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(200, 40);
            this.pictureBox47.TabIndex = 8;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox48
            // 
            this.pictureBox48.Location = new System.Drawing.Point(6, 341);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(200, 40);
            this.pictureBox48.TabIndex = 7;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.Location = new System.Drawing.Point(6, 295);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(200, 40);
            this.pictureBox49.TabIndex = 6;
            this.pictureBox49.TabStop = false;
            // 
            // pictureBox50
            // 
            this.pictureBox50.Location = new System.Drawing.Point(6, 249);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(200, 40);
            this.pictureBox50.TabIndex = 5;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.Location = new System.Drawing.Point(6, 203);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(200, 40);
            this.pictureBox51.TabIndex = 4;
            this.pictureBox51.TabStop = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.Location = new System.Drawing.Point(6, 157);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(200, 40);
            this.pictureBox52.TabIndex = 3;
            this.pictureBox52.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.Location = new System.Drawing.Point(6, 111);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(200, 40);
            this.pictureBox53.TabIndex = 2;
            this.pictureBox53.TabStop = false;
            // 
            // pictureBox54
            // 
            this.pictureBox54.Location = new System.Drawing.Point(6, 65);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(200, 40);
            this.pictureBox54.TabIndex = 1;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.Location = new System.Drawing.Point(6, 19);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(200, 40);
            this.pictureBox55.TabIndex = 0;
            this.pictureBox55.TabStop = false;
            // 
            // group_selectedRegion
            // 
            this.group_selectedRegion.Controls.Add(this.picture_selectedRegion);
            this.group_selectedRegion.Location = new System.Drawing.Point(208, 578);
            this.group_selectedRegion.Name = "group_selectedRegion";
            this.group_selectedRegion.Size = new System.Drawing.Size(452, 226);
            this.group_selectedRegion.TabIndex = 15;
            this.group_selectedRegion.TabStop = false;
            this.group_selectedRegion.Text = "Selected Region";
            // 
            // picture_selectedRegion
            // 
            this.picture_selectedRegion.Location = new System.Drawing.Point(6, 15);
            this.picture_selectedRegion.Name = "picture_selectedRegion";
            this.picture_selectedRegion.Size = new System.Drawing.Size(440, 200);
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
            // group_Run
            // 
            this.group_Run.Controls.Add(this.button_runAll);
            this.group_Run.Controls.Add(this.button_runPostprocessor);
            this.group_Run.Controls.Add(this.button_runPreprocessor);
            this.group_Run.Controls.Add(this.button_runDepthprocessor);
            this.group_Run.Location = new System.Drawing.Point(20, 578);
            this.group_Run.Name = "group_Run";
            this.group_Run.Size = new System.Drawing.Size(170, 154);
            this.group_Run.TabIndex = 16;
            this.group_Run.TabStop = false;
            this.group_Run.Text = "Run";
            // 
            // button_runAll
            // 
            this.button_runAll.Enabled = false;
            this.button_runAll.Location = new System.Drawing.Point(6, 115);
            this.button_runAll.Name = "button_runAll";
            this.button_runAll.Size = new System.Drawing.Size(158, 25);
            this.button_runAll.TabIndex = 5;
            this.button_runAll.Text = "All";
            this.button_runAll.UseVisualStyleBackColor = true;
            this.button_runAll.Click += new System.EventHandler(this.button_runAll_Click);
            // 
            // button_runPostprocessor
            // 
            this.button_runPostprocessor.Enabled = false;
            this.button_runPostprocessor.Location = new System.Drawing.Point(6, 84);
            this.button_runPostprocessor.Name = "button_runPostprocessor";
            this.button_runPostprocessor.Size = new System.Drawing.Size(158, 25);
            this.button_runPostprocessor.TabIndex = 4;
            this.button_runPostprocessor.Text = "Postprocessor";
            this.button_runPostprocessor.UseVisualStyleBackColor = true;
            this.button_runPostprocessor.Click += new System.EventHandler(this.button_runPostprocessor_Click);
            // 
            // button_runPreprocessor
            // 
            this.button_runPreprocessor.Enabled = false;
            this.button_runPreprocessor.Location = new System.Drawing.Point(6, 22);
            this.button_runPreprocessor.Name = "button_runPreprocessor";
            this.button_runPreprocessor.Size = new System.Drawing.Size(158, 25);
            this.button_runPreprocessor.TabIndex = 3;
            this.button_runPreprocessor.Text = "Preprocessor";
            this.button_runPreprocessor.UseVisualStyleBackColor = true;
            this.button_runPreprocessor.Click += new System.EventHandler(this.button_runPreprocessor_Click);
            // 
            // normalizePreprocMenuItem
            // 
            this.normalizePreprocMenuItem.Name = "normalizePreprocMenuItem";
            this.normalizePreprocMenuItem.Size = new System.Drawing.Size(152, 22);
            this.normalizePreprocMenuItem.Text = "Normalize";
            this.normalizePreprocMenuItem.Click += new System.EventHandler(this.normalizePreprocMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 811);
            this.Controls.Add(this.group_Run);
            this.Controls.Add(this.group_selectedRegion);
            this.Controls.Add(this.group_matchResult_NormedCCOEFF);
            this.Controls.Add(this.group_matchResult_CCOEFF);
            this.Controls.Add(this.group_matchResult_NormedCCORR);
            this.Controls.Add(this.group_matchResult_NormedSQDIFF);
            this.Controls.Add(this.group_matchResult_SQDIFF);
            this.Controls.Add(this.dataImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Kinect Raw Data Processing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.group_matchResult_NormedCCORR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            this.group_matchResult_CCOEFF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            this.group_matchResult_NormedCCOEFF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            this.group_selectedRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_selectedRegion)).EndInit();
            this.group_Run.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dataImage;
        private System.Windows.Forms.OpenFileDialog openDataImageDialog;
        private System.Windows.Forms.Button button_runDepthprocessor;
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
        private System.Windows.Forms.GroupBox group_matchResult_NormedCCORR;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox29;
        private System.Windows.Forms.PictureBox pictureBox30;
        private System.Windows.Forms.PictureBox pictureBox31;
        private System.Windows.Forms.PictureBox pictureBox32;
        private System.Windows.Forms.PictureBox pictureBox33;
        private System.Windows.Forms.GroupBox group_matchResult_CCOEFF;
        private System.Windows.Forms.PictureBox pictureBox34;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.PictureBox pictureBox38;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.PictureBox pictureBox40;
        private System.Windows.Forms.PictureBox pictureBox41;
        private System.Windows.Forms.PictureBox pictureBox42;
        private System.Windows.Forms.PictureBox pictureBox43;
        private System.Windows.Forms.PictureBox pictureBox44;
        private System.Windows.Forms.GroupBox group_matchResult_NormedCCOEFF;
        private System.Windows.Forms.PictureBox pictureBox45;
        private System.Windows.Forms.PictureBox pictureBox46;
        private System.Windows.Forms.PictureBox pictureBox47;
        private System.Windows.Forms.PictureBox pictureBox48;
        private System.Windows.Forms.PictureBox pictureBox49;
        private System.Windows.Forms.PictureBox pictureBox50;
        private System.Windows.Forms.PictureBox pictureBox51;
        private System.Windows.Forms.PictureBox pictureBox52;
        private System.Windows.Forms.PictureBox pictureBox53;
        private System.Windows.Forms.PictureBox pictureBox54;
        private System.Windows.Forms.PictureBox pictureBox55;
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
        private System.Windows.Forms.PictureBox pictureBox70;
        private System.Windows.Forms.PictureBox pictureBox69;
        private System.Windows.Forms.PictureBox pictureBox68;
        private System.Windows.Forms.PictureBox pictureBox67;
        private System.Windows.Forms.PictureBox pictureBox66;
        private System.Windows.Forms.PictureBox pictureBox75;
        private System.Windows.Forms.PictureBox pictureBox74;
        private System.Windows.Forms.PictureBox pictureBox73;
        private System.Windows.Forms.PictureBox pictureBox72;
        private System.Windows.Forms.PictureBox pictureBox71;
        private System.Windows.Forms.PictureBox pictureBox80;
        private System.Windows.Forms.PictureBox pictureBox79;
        private System.Windows.Forms.PictureBox pictureBox78;
        private System.Windows.Forms.PictureBox pictureBox77;
        private System.Windows.Forms.PictureBox pictureBox76;
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
        private System.Windows.Forms.GroupBox group_Run;
        private System.Windows.Forms.Button button_runPreprocessor;
        private System.Windows.Forms.Button button_runPostprocessor;
        private System.Windows.Forms.Button button_runAll;
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
    }
}