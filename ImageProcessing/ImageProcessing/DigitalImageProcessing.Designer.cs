namespace ImageProcessing
{
    partial class DigitalImageProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DigitalImageProcessing));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixGrayLevelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageEnhancementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEqualisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logarithmicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitPlaneSlicingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spatialFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averagingFilterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weightedAveragingFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenedLaplacToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSegmentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageMorphologicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBox_AnhGoc = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBox_AnhDaXuLy = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnhGoc)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnhDaXuLy)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.ImageEnhancementToolStripMenuItem,
            this.imageSegmentationToolStripMenuItem,
            this.imageMorphologicalToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeImageToolStripMenuItem,
            this.matrixGrayLevelToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sizeImageToolStripMenuItem
            // 
            this.sizeImageToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.size;
            this.sizeImageToolStripMenuItem.Name = "sizeImageToolStripMenuItem";
            this.sizeImageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sizeImageToolStripMenuItem.Text = "Size Image";
            this.sizeImageToolStripMenuItem.Click += new System.EventHandler(this.sizeImageToolStripMenuItem_Click);
            // 
            // matrixGrayLevelToolStripMenuItem1
            // 
            this.matrixGrayLevelToolStripMenuItem1.Image = global::ImageProcessing.Properties.Resources.matrix;
            this.matrixGrayLevelToolStripMenuItem1.Name = "matrixGrayLevelToolStripMenuItem1";
            this.matrixGrayLevelToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.matrixGrayLevelToolStripMenuItem1.Text = "Matrix Gray Level";
            this.matrixGrayLevelToolStripMenuItem1.Click += new System.EventHandler(this.matrixGrayLevelToolStripMenuItem1_Click);
            // 
            // ImageEnhancementToolStripMenuItem
            // 
            this.ImageEnhancementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramEqualisationToolStripMenuItem,
            this.pointProcessingToolStripMenuItem,
            this.spatialFilteringToolStripMenuItem});
            this.ImageEnhancementToolStripMenuItem.Name = "ImageEnhancementToolStripMenuItem";
            this.ImageEnhancementToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.ImageEnhancementToolStripMenuItem.Text = "Image Enhancement";
            // 
            // histogramEqualisationToolStripMenuItem
            // 
            this.histogramEqualisationToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.equalisation;
            this.histogramEqualisationToolStripMenuItem.Name = "histogramEqualisationToolStripMenuItem";
            this.histogramEqualisationToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.histogramEqualisationToolStripMenuItem.Text = "Histogram Equalisation";
            this.histogramEqualisationToolStripMenuItem.Click += new System.EventHandler(this.histogramEqualisationToolStripMenuItem_Click);
            // 
            // pointProcessingToolStripMenuItem
            // 
            this.pointProcessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativeImageToolStripMenuItem,
            this.thresholdingToolStripMenuItem1,
            this.logarithmicToolStripMenuItem,
            this.powerToolStripMenuItem,
            this.bitPlaneSlicingToolStripMenuItem});
            this.pointProcessingToolStripMenuItem.Name = "pointProcessingToolStripMenuItem";
            this.pointProcessingToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.pointProcessingToolStripMenuItem.Text = "Point Processing";
            // 
            // negativeImageToolStripMenuItem
            // 
            this.negativeImageToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.negative;
            this.negativeImageToolStripMenuItem.Name = "negativeImageToolStripMenuItem";
            this.negativeImageToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.negativeImageToolStripMenuItem.Text = "Negative Image";
            this.negativeImageToolStripMenuItem.Click += new System.EventHandler(this.negativeImageToolStripMenuItem_Click);
            // 
            // thresholdingToolStripMenuItem1
            // 
            this.thresholdingToolStripMenuItem1.Image = global::ImageProcessing.Properties.Resources.thresholding;
            this.thresholdingToolStripMenuItem1.Name = "thresholdingToolStripMenuItem1";
            this.thresholdingToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.thresholdingToolStripMenuItem1.Text = "Thresholding";
            this.thresholdingToolStripMenuItem1.Click += new System.EventHandler(this.thresholdingToolStripMenuItem1_Click);
            // 
            // logarithmicToolStripMenuItem
            // 
            this.logarithmicToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.logarit;
            this.logarithmicToolStripMenuItem.Name = "logarithmicToolStripMenuItem";
            this.logarithmicToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.logarithmicToolStripMenuItem.Text = "Logarithmic";
            this.logarithmicToolStripMenuItem.Click += new System.EventHandler(this.logarithmicToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.power;
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // bitPlaneSlicingToolStripMenuItem
            // 
            this.bitPlaneSlicingToolStripMenuItem.Name = "bitPlaneSlicingToolStripMenuItem";
            this.bitPlaneSlicingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.bitPlaneSlicingToolStripMenuItem.Text = "Bit plane slicing";
            this.bitPlaneSlicingToolStripMenuItem.Click += new System.EventHandler(this.bitPlaneSlicingToolStripMenuItem_Click);
            // 
            // spatialFilteringToolStripMenuItem
            // 
            this.spatialFilteringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.medianToolStripMenuItem,
            this.averagingFilterToolStripMenuItem1,
            this.weightedAveragingFilterToolStripMenuItem,
            this.laplacToolStripMenuItem,
            this.sharpenedLaplacToolStripMenuItem1,
            this.sobelToolStripMenuItem});
            this.spatialFilteringToolStripMenuItem.Name = "spatialFilteringToolStripMenuItem";
            this.spatialFilteringToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.spatialFilteringToolStripMenuItem.Text = "Spatial Filtering";
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.min;
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.max;
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.median;
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // averagingFilterToolStripMenuItem1
            // 
            this.averagingFilterToolStripMenuItem1.Image = global::ImageProcessing.Properties.Resources.average;
            this.averagingFilterToolStripMenuItem1.Name = "averagingFilterToolStripMenuItem1";
            this.averagingFilterToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.averagingFilterToolStripMenuItem1.Text = "Averaging filter";
            this.averagingFilterToolStripMenuItem1.Click += new System.EventHandler(this.averagingFilterToolStripMenuItem1_Click);
            // 
            // weightedAveragingFilterToolStripMenuItem
            // 
            this.weightedAveragingFilterToolStripMenuItem.Image = global::ImageProcessing.Properties.Resources.weightedAverage;
            this.weightedAveragingFilterToolStripMenuItem.Name = "weightedAveragingFilterToolStripMenuItem";
            this.weightedAveragingFilterToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.weightedAveragingFilterToolStripMenuItem.Text = "Weighted averaging filter";
            this.weightedAveragingFilterToolStripMenuItem.Click += new System.EventHandler(this.weightedAveragingFilterToolStripMenuItem_Click);
            // 
            // laplacToolStripMenuItem
            // 
            this.laplacToolStripMenuItem.Name = "laplacToolStripMenuItem";
            this.laplacToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.laplacToolStripMenuItem.Text = "Laplac";
            this.laplacToolStripMenuItem.Click += new System.EventHandler(this.laplacToolStripMenuItem_Click);
            // 
            // sharpenedLaplacToolStripMenuItem1
            // 
            this.sharpenedLaplacToolStripMenuItem1.Name = "sharpenedLaplacToolStripMenuItem1";
            this.sharpenedLaplacToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.sharpenedLaplacToolStripMenuItem1.Text = "Sharpened Laplac";
            this.sharpenedLaplacToolStripMenuItem1.Click += new System.EventHandler(this.sharpenedLaplacToolStripMenuItem1_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // imageSegmentationToolStripMenuItem
            // 
            this.imageSegmentationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsToolStripMenuItem,
            this.linesToolStripMenuItem,
            this.edgesToolStripMenuItem});
            this.imageSegmentationToolStripMenuItem.Name = "imageSegmentationToolStripMenuItem";
            this.imageSegmentationToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.imageSegmentationToolStripMenuItem.Text = "Image Segmentation";
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.pointsToolStripMenuItem_Click);
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.linesToolStripMenuItem.Text = "Lines";
            this.linesToolStripMenuItem.Click += new System.EventHandler(this.linesToolStripMenuItem_Click);
            // 
            // edgesToolStripMenuItem
            // 
            this.edgesToolStripMenuItem.Name = "edgesToolStripMenuItem";
            this.edgesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.edgesToolStripMenuItem.Text = "Edges";
            // 
            // imageMorphologicalToolStripMenuItem
            // 
            this.imageMorphologicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hitToolStripMenuItem,
            this.fitToolStripMenuItem});
            this.imageMorphologicalToolStripMenuItem.Name = "imageMorphologicalToolStripMenuItem";
            this.imageMorphologicalToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.imageMorphologicalToolStripMenuItem.Text = "Image Morphological";
            // 
            // hitToolStripMenuItem
            // 
            this.hitToolStripMenuItem.Name = "hitToolStripMenuItem";
            this.hitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.hitToolStripMenuItem.Text = "Hit - Giản ảnh";
            this.hitToolStripMenuItem.Click += new System.EventHandler(this.hitToolStripMenuItem_Click);
            // 
            // fitToolStripMenuItem
            // 
            this.fitToolStripMenuItem.Name = "fitToolStripMenuItem";
            this.fitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fitToolStripMenuItem.Text = "Fit - Co ảnh";
            this.fitToolStripMenuItem.Click += new System.EventHandler(this.fitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBox_AnhGoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(9, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(375, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh gốc";
            // 
            // picBox_AnhGoc
            // 
            this.picBox_AnhGoc.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_AnhGoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_AnhGoc.Image = global::ImageProcessing.Properties.Resources.picture;
            this.picBox_AnhGoc.Location = new System.Drawing.Point(2, 18);
            this.picBox_AnhGoc.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_AnhGoc.Name = "picBox_AnhGoc";
            this.picBox_AnhGoc.Size = new System.Drawing.Size(371, 305);
            this.picBox_AnhGoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_AnhGoc.TabIndex = 0;
            this.picBox_AnhGoc.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.zedGraphControl2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(394, 355);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(375, 244);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.IsShowPointValues = false;
            this.zedGraphControl2.Location = new System.Drawing.Point(2, 18);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(2);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.PointValueFormat = "G";
            this.zedGraphControl2.Size = new System.Drawing.Size(371, 224);
            this.zedGraphControl2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zedGraphControl1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(9, 355);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(375, 244);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Histogram của ảnh gốc";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(2, 18);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(2);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(371, 224);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBox_AnhDaXuLy);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(392, 25);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(375, 325);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // picBox_AnhDaXuLy
            // 
            this.picBox_AnhDaXuLy.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_AnhDaXuLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_AnhDaXuLy.Image = global::ImageProcessing.Properties.Resources.picture;
            this.picBox_AnhDaXuLy.Location = new System.Drawing.Point(2, 18);
            this.picBox_AnhDaXuLy.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_AnhDaXuLy.Name = "picBox_AnhDaXuLy";
            this.picBox_AnhDaXuLy.Size = new System.Drawing.Size(371, 305);
            this.picBox_AnhDaXuLy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_AnhDaXuLy.TabIndex = 0;
            this.picBox_AnhDaXuLy.TabStop = false;
            // 
            // DigitalImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(775, 612);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DigitalImageProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Image Processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnhGoc)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_AnhDaXuLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImageEnhancementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEqualisationToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picBox_AnhGoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picBox_AnhDaXuLy;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixGrayLevelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imageSegmentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageMorphologicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spatialFilteringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logarithmicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitPlaneSlicingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averagingFilterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem weightedAveragingFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenedLaplacToolStripMenuItem1;
    }
}

