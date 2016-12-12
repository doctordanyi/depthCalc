namespace DepthCalc.UI
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.dataImage = new System.Windows.Forms.PictureBox();
            this.openDataImageDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.group_selectedRegion = new System.Windows.Forms.GroupBox();
            this.picture_selectedRegion = new System.Windows.Forms.PictureBox();
            this.saveResultImage = new System.Windows.Forms.SaveFileDialog();
            this.openReferenceImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.depthprocListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.addDepthprocStepButton = new System.Windows.Forms.Button();
            this.clearDepthprocQueueButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.windowHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.windowWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.sampleHeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.sampleWidthUpDown = new System.Windows.Forms.NumericUpDown();
            this.matchMethodSelector = new System.Windows.Forms.ComboBox();
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
            this.dataPathTextBox = new System.Windows.Forms.TextBox();
            this.referencePathTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.matchVisaulised0 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised1 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised2 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised3 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised4 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised5 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised6 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised7 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised8 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised9 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised10 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised11 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised12 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised13 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised14 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised15 = new System.Windows.Forms.PictureBox();
            this.matchVisualizationSelectorLeft = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.matchVisaulised16 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised17 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised18 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised19 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised20 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised21 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised22 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised23 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised24 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised25 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised26 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised27 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised28 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised29 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised30 = new System.Windows.Forms.PictureBox();
            this.matchVisaulised31 = new System.Windows.Forms.PictureBox();
            this.matchVisualizationSelectorRight = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.procProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.procStepStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.group_selectedRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_selectedRegion)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleHeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWidthUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised15)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised31)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preprocessingToolStripMenuItem,
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
            // depthprocListView
            // 
            this.depthprocListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depthprocListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.depthprocListView.FullRowSelect = true;
            this.depthprocListView.GridLines = true;
            this.depthprocListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.depthprocListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.depthprocListView.Location = new System.Drawing.Point(6, 128);
            this.depthprocListView.Name = "depthprocListView";
            this.depthprocListView.Size = new System.Drawing.Size(441, 59);
            this.depthprocListView.TabIndex = 3;
            this.depthprocListView.TabStop = false;
            this.depthprocListView.UseCompatibleStateImageBehavior = false;
            this.depthprocListView.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "step";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Location = new System.Drawing.Point(6, 513);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 175);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Postprocessing";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.depthprocListView);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.addDepthprocStepButton);
            this.groupBox3.Controls.Add(this.clearDepthprocQueueButton);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.windowHeightUpDown);
            this.groupBox3.Controls.Add(this.windowWidthUpDown);
            this.groupBox3.Controls.Add(this.sampleHeightUpDown);
            this.groupBox3.Controls.Add(this.sampleWidthUpDown);
            this.groupBox3.Controls.Add(this.matchMethodSelector);
            this.groupBox3.Location = new System.Drawing.Point(6, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 225);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disparity calculation";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(132, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 25);
            this.button4.TabIndex = 15;
            this.button4.Text = "Run";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addDepthprocStepButton
            // 
            this.addDepthprocStepButton.Location = new System.Drawing.Point(69, 193);
            this.addDepthprocStepButton.Name = "addDepthprocStepButton";
            this.addDepthprocStepButton.Size = new System.Drawing.Size(57, 25);
            this.addDepthprocStepButton.TabIndex = 14;
            this.addDepthprocStepButton.Text = "Add step";
            this.addDepthprocStepButton.UseVisualStyleBackColor = true;
            this.addDepthprocStepButton.Click += new System.EventHandler(this.addDepthprocStepButton_Click);
            // 
            // clearDepthprocQueueButton
            // 
            this.clearDepthprocQueueButton.Location = new System.Drawing.Point(6, 193);
            this.clearDepthprocQueueButton.Name = "clearDepthprocQueueButton";
            this.clearDepthprocQueueButton.Size = new System.Drawing.Size(57, 25);
            this.clearDepthprocQueueButton.TabIndex = 3;
            this.clearDepthprocQueueButton.Text = "Clear";
            this.clearDepthprocQueueButton.UseVisualStyleBackColor = true;
            this.clearDepthprocQueueButton.Click += new System.EventHandler(this.clearDepthprocQueueButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Depthprocessing queue";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "H:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "H:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Window size:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Match method:";
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
            // windowHeightUpDown
            // 
            this.windowHeightUpDown.Location = new System.Drawing.Point(185, 79);
            this.windowHeightUpDown.Name = "windowHeightUpDown";
            this.windowHeightUpDown.Size = new System.Drawing.Size(48, 20);
            this.windowHeightUpDown.TabIndex = 4;
            // 
            // windowWidthUpDown
            // 
            this.windowWidthUpDown.Location = new System.Drawing.Point(109, 77);
            this.windowWidthUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.windowWidthUpDown.Name = "windowWidthUpDown";
            this.windowWidthUpDown.Size = new System.Drawing.Size(46, 20);
            this.windowWidthUpDown.TabIndex = 3;
            // 
            // sampleHeightUpDown
            // 
            this.sampleHeightUpDown.Location = new System.Drawing.Point(185, 51);
            this.sampleHeightUpDown.Name = "sampleHeightUpDown";
            this.sampleHeightUpDown.Size = new System.Drawing.Size(48, 20);
            this.sampleHeightUpDown.TabIndex = 2;
            // 
            // sampleWidthUpDown
            // 
            this.sampleWidthUpDown.Location = new System.Drawing.Point(109, 51);
            this.sampleWidthUpDown.Name = "sampleWidthUpDown";
            this.sampleWidthUpDown.Size = new System.Drawing.Size(46, 20);
            this.sampleWidthUpDown.TabIndex = 1;
            // 
            // matchMethodSelector
            // 
            this.matchMethodSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchMethodSelector.FormattingEnabled = true;
            this.matchMethodSelector.Location = new System.Drawing.Point(90, 19);
            this.matchMethodSelector.Name = "matchMethodSelector";
            this.matchMethodSelector.Size = new System.Drawing.Size(207, 21);
            this.matchMethodSelector.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.preprocListView);
            this.groupBox2.Location = new System.Drawing.Point(6, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preprocessing";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preprocessing queue";
            // 
            // preprocListView
            // 
            this.preprocListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preprocListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.step});
            this.preprocListView.FullRowSelect = true;
            this.preprocListView.GridLines = true;
            this.preprocListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.preprocListView.Location = new System.Drawing.Point(0, 32);
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.browseDataButton);
            this.groupBox1.Controls.Add(this.browseReferenceButton);
            this.groupBox1.Controls.Add(this.dataPathTextBox);
            this.groupBox1.Controls.Add(this.referencePathTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 83);
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
            this.browseDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.browseReferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseReferenceButton.Location = new System.Drawing.Point(370, 28);
            this.browseReferenceButton.Name = "browseReferenceButton";
            this.browseReferenceButton.Size = new System.Drawing.Size(60, 20);
            this.browseReferenceButton.TabIndex = 2;
            this.browseReferenceButton.Text = "Browse";
            this.browseReferenceButton.UseVisualStyleBackColor = true;
            this.browseReferenceButton.Click += new System.EventHandler(this.browseReferenceButton_Click);
            // 
            // dataPathTextBox
            // 
            this.dataPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPathTextBox.Location = new System.Drawing.Point(69, 54);
            this.dataPathTextBox.Name = "dataPathTextBox";
            this.dataPathTextBox.ReadOnly = true;
            this.dataPathTextBox.Size = new System.Drawing.Size(295, 20);
            this.dataPathTextBox.TabIndex = 1;
            // 
            // referencePathTextBox
            // 
            this.referencePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.referencePathTextBox.Location = new System.Drawing.Point(69, 28);
            this.referencePathTextBox.Name = "referencePathTextBox";
            this.referencePathTextBox.ReadOnly = true;
            this.referencePathTextBox.Size = new System.Drawing.Size(295, 20);
            this.referencePathTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 780);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Match visaulization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.matchVisualizationSelectorLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.matchVisualizationSelectorRight);
            this.splitContainer1.Size = new System.Drawing.Size(464, 774);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.matchVisaulised0);
            this.panel1.Controls.Add(this.matchVisaulised1);
            this.panel1.Controls.Add(this.matchVisaulised2);
            this.panel1.Controls.Add(this.matchVisaulised3);
            this.panel1.Controls.Add(this.matchVisaulised4);
            this.panel1.Controls.Add(this.matchVisaulised5);
            this.panel1.Controls.Add(this.matchVisaulised6);
            this.panel1.Controls.Add(this.matchVisaulised7);
            this.panel1.Controls.Add(this.matchVisaulised8);
            this.panel1.Controls.Add(this.matchVisaulised9);
            this.panel1.Controls.Add(this.matchVisaulised10);
            this.panel1.Controls.Add(this.matchVisaulised11);
            this.panel1.Controls.Add(this.matchVisaulised12);
            this.panel1.Controls.Add(this.matchVisaulised13);
            this.panel1.Controls.Add(this.matchVisaulised14);
            this.panel1.Controls.Add(this.matchVisaulised15);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 730);
            this.panel1.TabIndex = 20;
            // 
            // matchVisaulised0
            // 
            this.matchVisaulised0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised0.Location = new System.Drawing.Point(0, 3);
            this.matchVisaulised0.Name = "matchVisaulised0";
            this.matchVisaulised0.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised0.TabIndex = 51;
            this.matchVisaulised0.TabStop = false;
            // 
            // matchVisaulised1
            // 
            this.matchVisaulised1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised1.Location = new System.Drawing.Point(0, 49);
            this.matchVisaulised1.Name = "matchVisaulised1";
            this.matchVisaulised1.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised1.TabIndex = 52;
            this.matchVisaulised1.TabStop = false;
            // 
            // matchVisaulised2
            // 
            this.matchVisaulised2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised2.Location = new System.Drawing.Point(0, 95);
            this.matchVisaulised2.Name = "matchVisaulised2";
            this.matchVisaulised2.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised2.TabIndex = 53;
            this.matchVisaulised2.TabStop = false;
            // 
            // matchVisaulised3
            // 
            this.matchVisaulised3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised3.Location = new System.Drawing.Point(0, 141);
            this.matchVisaulised3.Name = "matchVisaulised3";
            this.matchVisaulised3.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised3.TabIndex = 54;
            this.matchVisaulised3.TabStop = false;
            // 
            // matchVisaulised4
            // 
            this.matchVisaulised4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised4.Location = new System.Drawing.Point(0, 187);
            this.matchVisaulised4.Name = "matchVisaulised4";
            this.matchVisaulised4.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised4.TabIndex = 55;
            this.matchVisaulised4.TabStop = false;
            // 
            // matchVisaulised5
            // 
            this.matchVisaulised5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised5.Location = new System.Drawing.Point(0, 230);
            this.matchVisaulised5.Name = "matchVisaulised5";
            this.matchVisaulised5.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised5.TabIndex = 56;
            this.matchVisaulised5.TabStop = false;
            // 
            // matchVisaulised6
            // 
            this.matchVisaulised6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised6.Location = new System.Drawing.Point(0, 276);
            this.matchVisaulised6.Name = "matchVisaulised6";
            this.matchVisaulised6.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised6.TabIndex = 57;
            this.matchVisaulised6.TabStop = false;
            // 
            // matchVisaulised7
            // 
            this.matchVisaulised7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised7.Location = new System.Drawing.Point(0, 322);
            this.matchVisaulised7.Name = "matchVisaulised7";
            this.matchVisaulised7.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised7.TabIndex = 58;
            this.matchVisaulised7.TabStop = false;
            // 
            // matchVisaulised8
            // 
            this.matchVisaulised8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised8.Location = new System.Drawing.Point(0, 368);
            this.matchVisaulised8.Name = "matchVisaulised8";
            this.matchVisaulised8.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised8.TabIndex = 59;
            this.matchVisaulised8.TabStop = false;
            // 
            // matchVisaulised9
            // 
            this.matchVisaulised9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised9.Location = new System.Drawing.Point(0, 414);
            this.matchVisaulised9.Name = "matchVisaulised9";
            this.matchVisaulised9.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised9.TabIndex = 60;
            this.matchVisaulised9.TabStop = false;
            // 
            // matchVisaulised10
            // 
            this.matchVisaulised10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised10.Location = new System.Drawing.Point(0, 460);
            this.matchVisaulised10.Name = "matchVisaulised10";
            this.matchVisaulised10.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised10.TabIndex = 61;
            this.matchVisaulised10.TabStop = false;
            // 
            // matchVisaulised11
            // 
            this.matchVisaulised11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised11.Location = new System.Drawing.Point(0, 506);
            this.matchVisaulised11.Name = "matchVisaulised11";
            this.matchVisaulised11.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised11.TabIndex = 62;
            this.matchVisaulised11.TabStop = false;
            // 
            // matchVisaulised12
            // 
            this.matchVisaulised12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised12.Location = new System.Drawing.Point(0, 552);
            this.matchVisaulised12.Name = "matchVisaulised12";
            this.matchVisaulised12.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised12.TabIndex = 63;
            this.matchVisaulised12.TabStop = false;
            // 
            // matchVisaulised13
            // 
            this.matchVisaulised13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised13.Location = new System.Drawing.Point(0, 598);
            this.matchVisaulised13.Name = "matchVisaulised13";
            this.matchVisaulised13.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised13.TabIndex = 64;
            this.matchVisaulised13.TabStop = false;
            // 
            // matchVisaulised14
            // 
            this.matchVisaulised14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised14.Location = new System.Drawing.Point(0, 644);
            this.matchVisaulised14.Name = "matchVisaulised14";
            this.matchVisaulised14.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised14.TabIndex = 65;
            this.matchVisaulised14.TabStop = false;
            // 
            // matchVisaulised15
            // 
            this.matchVisaulised15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised15.Location = new System.Drawing.Point(0, 690);
            this.matchVisaulised15.Name = "matchVisaulised15";
            this.matchVisaulised15.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised15.TabIndex = 66;
            this.matchVisaulised15.TabStop = false;
            // 
            // matchVisualizationSelectorLeft
            // 
            this.matchVisualizationSelectorLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisualizationSelectorLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchVisualizationSelectorLeft.FormattingEnabled = true;
            this.matchVisualizationSelectorLeft.Location = new System.Drawing.Point(3, 3);
            this.matchVisualizationSelectorLeft.Name = "matchVisualizationSelectorLeft";
            this.matchVisualizationSelectorLeft.Size = new System.Drawing.Size(224, 21);
            this.matchVisualizationSelectorLeft.TabIndex = 19;
            this.matchVisualizationSelectorLeft.SelectedIndexChanged += new System.EventHandler(this.matchVisualizationSelectorLeft_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.matchVisaulised16);
            this.panel2.Controls.Add(this.matchVisaulised17);
            this.panel2.Controls.Add(this.matchVisaulised18);
            this.panel2.Controls.Add(this.matchVisaulised19);
            this.panel2.Controls.Add(this.matchVisaulised20);
            this.panel2.Controls.Add(this.matchVisaulised21);
            this.panel2.Controls.Add(this.matchVisaulised22);
            this.panel2.Controls.Add(this.matchVisaulised23);
            this.panel2.Controls.Add(this.matchVisaulised24);
            this.panel2.Controls.Add(this.matchVisaulised25);
            this.panel2.Controls.Add(this.matchVisaulised26);
            this.panel2.Controls.Add(this.matchVisaulised27);
            this.panel2.Controls.Add(this.matchVisaulised28);
            this.panel2.Controls.Add(this.matchVisaulised29);
            this.panel2.Controls.Add(this.matchVisaulised30);
            this.panel2.Controls.Add(this.matchVisaulised31);
            this.panel2.Location = new System.Drawing.Point(3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 730);
            this.panel2.TabIndex = 67;
            // 
            // matchVisaulised16
            // 
            this.matchVisaulised16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised16.Location = new System.Drawing.Point(0, 3);
            this.matchVisaulised16.Name = "matchVisaulised16";
            this.matchVisaulised16.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised16.TabIndex = 51;
            this.matchVisaulised16.TabStop = false;
            // 
            // matchVisaulised17
            // 
            this.matchVisaulised17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised17.Location = new System.Drawing.Point(0, 49);
            this.matchVisaulised17.Name = "matchVisaulised17";
            this.matchVisaulised17.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised17.TabIndex = 52;
            this.matchVisaulised17.TabStop = false;
            // 
            // matchVisaulised18
            // 
            this.matchVisaulised18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised18.Location = new System.Drawing.Point(0, 95);
            this.matchVisaulised18.Name = "matchVisaulised18";
            this.matchVisaulised18.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised18.TabIndex = 53;
            this.matchVisaulised18.TabStop = false;
            // 
            // matchVisaulised19
            // 
            this.matchVisaulised19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised19.Location = new System.Drawing.Point(0, 141);
            this.matchVisaulised19.Name = "matchVisaulised19";
            this.matchVisaulised19.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised19.TabIndex = 54;
            this.matchVisaulised19.TabStop = false;
            // 
            // matchVisaulised20
            // 
            this.matchVisaulised20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised20.Location = new System.Drawing.Point(0, 187);
            this.matchVisaulised20.Name = "matchVisaulised20";
            this.matchVisaulised20.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised20.TabIndex = 55;
            this.matchVisaulised20.TabStop = false;
            // 
            // matchVisaulised21
            // 
            this.matchVisaulised21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised21.Location = new System.Drawing.Point(0, 233);
            this.matchVisaulised21.Name = "matchVisaulised21";
            this.matchVisaulised21.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised21.TabIndex = 56;
            this.matchVisaulised21.TabStop = false;
            // 
            // matchVisaulised22
            // 
            this.matchVisaulised22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised22.Location = new System.Drawing.Point(0, 276);
            this.matchVisaulised22.Name = "matchVisaulised22";
            this.matchVisaulised22.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised22.TabIndex = 57;
            this.matchVisaulised22.TabStop = false;
            // 
            // matchVisaulised23
            // 
            this.matchVisaulised23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised23.Location = new System.Drawing.Point(0, 322);
            this.matchVisaulised23.Name = "matchVisaulised23";
            this.matchVisaulised23.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised23.TabIndex = 58;
            this.matchVisaulised23.TabStop = false;
            // 
            // matchVisaulised24
            // 
            this.matchVisaulised24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised24.Location = new System.Drawing.Point(0, 368);
            this.matchVisaulised24.Name = "matchVisaulised24";
            this.matchVisaulised24.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised24.TabIndex = 59;
            this.matchVisaulised24.TabStop = false;
            // 
            // matchVisaulised25
            // 
            this.matchVisaulised25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised25.Location = new System.Drawing.Point(0, 417);
            this.matchVisaulised25.Name = "matchVisaulised25";
            this.matchVisaulised25.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised25.TabIndex = 60;
            this.matchVisaulised25.TabStop = false;
            // 
            // matchVisaulised26
            // 
            this.matchVisaulised26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised26.Location = new System.Drawing.Point(0, 460);
            this.matchVisaulised26.Name = "matchVisaulised26";
            this.matchVisaulised26.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised26.TabIndex = 61;
            this.matchVisaulised26.TabStop = false;
            // 
            // matchVisaulised27
            // 
            this.matchVisaulised27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised27.Location = new System.Drawing.Point(0, 506);
            this.matchVisaulised27.Name = "matchVisaulised27";
            this.matchVisaulised27.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised27.TabIndex = 62;
            this.matchVisaulised27.TabStop = false;
            // 
            // matchVisaulised28
            // 
            this.matchVisaulised28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised28.Location = new System.Drawing.Point(0, 552);
            this.matchVisaulised28.Name = "matchVisaulised28";
            this.matchVisaulised28.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised28.TabIndex = 63;
            this.matchVisaulised28.TabStop = false;
            // 
            // matchVisaulised29
            // 
            this.matchVisaulised29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised29.Location = new System.Drawing.Point(0, 598);
            this.matchVisaulised29.Name = "matchVisaulised29";
            this.matchVisaulised29.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised29.TabIndex = 64;
            this.matchVisaulised29.TabStop = false;
            // 
            // matchVisaulised30
            // 
            this.matchVisaulised30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised30.Location = new System.Drawing.Point(0, 644);
            this.matchVisaulised30.Name = "matchVisaulised30";
            this.matchVisaulised30.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised30.TabIndex = 65;
            this.matchVisaulised30.TabStop = false;
            // 
            // matchVisaulised31
            // 
            this.matchVisaulised31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisaulised31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchVisaulised31.Location = new System.Drawing.Point(0, 690);
            this.matchVisaulised31.Name = "matchVisaulised31";
            this.matchVisaulised31.Size = new System.Drawing.Size(224, 40);
            this.matchVisaulised31.TabIndex = 66;
            this.matchVisaulised31.TabStop = false;
            // 
            // matchVisualizationSelectorRight
            // 
            this.matchVisualizationSelectorRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matchVisualizationSelectorRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matchVisualizationSelectorRight.FormattingEnabled = true;
            this.matchVisualizationSelectorRight.Location = new System.Drawing.Point(3, 3);
            this.matchVisualizationSelectorRight.Name = "matchVisualizationSelectorRight";
            this.matchVisualizationSelectorRight.Size = new System.Drawing.Size(224, 21);
            this.matchVisualizationSelectorRight.TabIndex = 18;
            this.matchVisualizationSelectorRight.SelectedIndexChanged += new System.EventHandler(this.matchVisualizationSelectorRight_SelectedIndexChanged);
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
            this.MinimumSize = new System.Drawing.Size(1165, 898);
            this.Name = "MainWindow";
            this.Text = "Kinect Raw Data Processing";
            ((System.ComponentModel.ISupportInitialize)(this.dataImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.group_selectedRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_selectedRegion)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowWidthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleHeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWidthUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised15)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchVisaulised31)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dataImage;
        private System.Windows.Forms.OpenFileDialog openDataImageDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preprocessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scalePreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussPreprocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dogPreprocMenuItem;
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
        private System.Windows.Forms.TextBox dataPathTextBox;
        private System.Windows.Forms.TextBox referencePathTextBox;
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
        private System.Windows.Forms.NumericUpDown windowHeightUpDown;
        private System.Windows.Forms.NumericUpDown windowWidthUpDown;
        private System.Windows.Forms.NumericUpDown sampleHeightUpDown;
        private System.Windows.Forms.NumericUpDown sampleWidthUpDown;
        private System.Windows.Forms.ComboBox matchMethodSelector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView depthprocListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addDepthprocStepButton;
        private System.Windows.Forms.Button clearDepthprocQueueButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox matchVisualizationSelectorLeft;
        private System.Windows.Forms.ComboBox matchVisualizationSelectorRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox matchVisaulised15;
        private System.Windows.Forms.PictureBox matchVisaulised2;
        private System.Windows.Forms.PictureBox matchVisaulised14;
        private System.Windows.Forms.PictureBox matchVisaulised7;
        private System.Windows.Forms.PictureBox matchVisaulised0;
        private System.Windows.Forms.PictureBox matchVisaulised6;
        private System.Windows.Forms.PictureBox matchVisaulised13;
        private System.Windows.Forms.PictureBox matchVisaulised8;
        private System.Windows.Forms.PictureBox matchVisaulised1;
        private System.Windows.Forms.PictureBox matchVisaulised5;
        private System.Windows.Forms.PictureBox matchVisaulised12;
        private System.Windows.Forms.PictureBox matchVisaulised9;
        private System.Windows.Forms.PictureBox matchVisaulised4;
        private System.Windows.Forms.PictureBox matchVisaulised11;
        private System.Windows.Forms.PictureBox matchVisaulised10;
        private System.Windows.Forms.PictureBox matchVisaulised3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox matchVisaulised31;
        private System.Windows.Forms.PictureBox matchVisaulised18;
        private System.Windows.Forms.PictureBox matchVisaulised30;
        private System.Windows.Forms.PictureBox matchVisaulised23;
        private System.Windows.Forms.PictureBox matchVisaulised16;
        private System.Windows.Forms.PictureBox matchVisaulised22;
        private System.Windows.Forms.PictureBox matchVisaulised29;
        private System.Windows.Forms.PictureBox matchVisaulised24;
        private System.Windows.Forms.PictureBox matchVisaulised17;
        private System.Windows.Forms.PictureBox matchVisaulised21;
        private System.Windows.Forms.PictureBox matchVisaulised28;
        private System.Windows.Forms.PictureBox matchVisaulised25;
        private System.Windows.Forms.PictureBox matchVisaulised20;
        private System.Windows.Forms.PictureBox matchVisaulised27;
        private System.Windows.Forms.PictureBox matchVisaulised26;
        private System.Windows.Forms.PictureBox matchVisaulised19;
    }
}