namespace GKProject2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FillGroupBox = new System.Windows.Forms.GroupBox();
            this.FillColorPictureBox = new System.Windows.Forms.PictureBox();
            this.FillTexturePictureBox = new System.Windows.Forms.PictureBox();
            this.FillTextureRadioButton = new System.Windows.Forms.RadioButton();
            this.FillColorRadioButton = new System.Windows.Forms.RadioButton();
            this.LightColorGroupBox = new System.Windows.Forms.GroupBox();
            this.LightColorPictureBox = new System.Windows.Forms.PictureBox();
            this.LightColorCustomRadioButton = new System.Windows.Forms.RadioButton();
            this.LightColorWhiteRadioButton = new System.Windows.Forms.RadioButton();
            this.NVectorGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeBubbleSizeButton = new System.Windows.Forms.Button();
            this.BubbleSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.BubbleCheckbox = new System.Windows.Forms.CheckBox();
            this.NVectorNormalMapPictureBox = new System.Windows.Forms.PictureBox();
            this.NVectorNormalMapRadioButton = new System.Windows.Forms.RadioButton();
            this.NVectorConstantRadioButton = new System.Windows.Forms.RadioButton();
            this.FillModeGroupBox = new System.Windows.Forms.GroupBox();
            this.FillModeInterpolateRadioButton = new System.Windows.Forms.RadioButton();
            this.FillModeAccurateRadioButton = new System.Windows.Forms.RadioButton();
            this.MeshGroupBox = new System.Windows.Forms.GroupBox();
            this.MeshNewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MeshVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.MeshM = new System.Windows.Forms.NumericUpDown();
            this.MeshN = new System.Windows.Forms.NumericUpDown();
            this.LightLocationGroupBox = new System.Windows.Forms.GroupBox();
            this.LightLocationCenterRadioButtton = new System.Windows.Forms.RadioButton();
            this.LightLocationAnimatedRadioButtton = new System.Windows.Forms.RadioButton();
            this.LightLocationDefaultRadioButton = new System.Windows.Forms.RadioButton();
            this.CoefficientsGroupBox = new System.Windows.Forms.GroupBox();
            this.MLabel = new System.Windows.Forms.Label();
            this.KsLabel = new System.Windows.Forms.Label();
            this.KdLabel = new System.Windows.Forms.Label();
            this.MBar = new System.Windows.Forms.TrackBar();
            this.KsBar = new System.Windows.Forms.TrackBar();
            this.KdBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.FillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillTexturePictureBox)).BeginInit();
            this.LightColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightColorPictureBox)).BeginInit();
            this.NVectorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BubbleSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NVectorNormalMapPictureBox)).BeginInit();
            this.FillModeGroupBox.SuspendLayout();
            this.MeshGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeshM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshN)).BeginInit();
            this.LightLocationGroupBox.SuspendLayout();
            this.CoefficientsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KsBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayoutPanel.Controls.Add(this.DrawingArea, 1, 0);
            this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 616F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1282, 651);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // DrawingArea
            // 
            this.DrawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingArea.Location = new System.Drawing.Point(203, 3);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(1083, 645);
            this.DrawingArea.TabIndex = 0;
            this.DrawingArea.TabStop = false;
            this.DrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseDown);
            this.DrawingArea.MouseLeave += new System.EventHandler(this.DrawingArea_MouseLeave);
            this.DrawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseMove);
            this.DrawingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingArea_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FillGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LightColorGroupBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.NVectorGroupBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.FillModeGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MeshGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LightLocationGroupBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CoefficientsGroupBox, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(194, 613);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // FillGroupBox
            // 
            this.FillGroupBox.Controls.Add(this.FillColorPictureBox);
            this.FillGroupBox.Controls.Add(this.FillTexturePictureBox);
            this.FillGroupBox.Controls.Add(this.FillTextureRadioButton);
            this.FillGroupBox.Controls.Add(this.FillColorRadioButton);
            this.FillGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillGroupBox.Location = new System.Drawing.Point(3, 83);
            this.FillGroupBox.Name = "FillGroupBox";
            this.FillGroupBox.Size = new System.Drawing.Size(188, 56);
            this.FillGroupBox.TabIndex = 0;
            this.FillGroupBox.TabStop = false;
            this.FillGroupBox.Text = "Fill";
            // 
            // FillColorPictureBox
            // 
            this.FillColorPictureBox.Location = new System.Drawing.Point(144, 16);
            this.FillColorPictureBox.Name = "FillColorPictureBox";
            this.FillColorPictureBox.Size = new System.Drawing.Size(16, 16);
            this.FillColorPictureBox.TabIndex = 3;
            this.FillColorPictureBox.TabStop = false;
            this.FillColorPictureBox.Click += new System.EventHandler(this.FillColorPictureBox_Click);
            // 
            // FillTexturePictureBox
            // 
            this.FillTexturePictureBox.Image = global::GKProject2.Properties.Resources.Texture;
            this.FillTexturePictureBox.Location = new System.Drawing.Point(144, 37);
            this.FillTexturePictureBox.Name = "FillTexturePictureBox";
            this.FillTexturePictureBox.Size = new System.Drawing.Size(16, 16);
            this.FillTexturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FillTexturePictureBox.TabIndex = 2;
            this.FillTexturePictureBox.TabStop = false;
            this.FillTexturePictureBox.Click += new System.EventHandler(this.FillTexturePictureBox_Click);
            // 
            // FillTextureRadioButton
            // 
            this.FillTextureRadioButton.AutoSize = true;
            this.FillTextureRadioButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FillTextureRadioButton.Location = new System.Drawing.Point(3, 36);
            this.FillTextureRadioButton.Name = "FillTextureRadioButton";
            this.FillTextureRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.FillTextureRadioButton.Size = new System.Drawing.Size(182, 17);
            this.FillTextureRadioButton.TabIndex = 1;
            this.FillTextureRadioButton.Text = "Texture";
            this.FillTextureRadioButton.UseVisualStyleBackColor = true;
            this.FillTextureRadioButton.CheckedChanged += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // FillColorRadioButton
            // 
            this.FillColorRadioButton.AutoSize = true;
            this.FillColorRadioButton.Checked = true;
            this.FillColorRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillColorRadioButton.Location = new System.Drawing.Point(3, 16);
            this.FillColorRadioButton.Name = "FillColorRadioButton";
            this.FillColorRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.FillColorRadioButton.Size = new System.Drawing.Size(182, 17);
            this.FillColorRadioButton.TabIndex = 0;
            this.FillColorRadioButton.TabStop = true;
            this.FillColorRadioButton.Text = "Color";
            this.FillColorRadioButton.UseVisualStyleBackColor = true;
            this.FillColorRadioButton.CheckedChanged += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // LightColorGroupBox
            // 
            this.LightColorGroupBox.Controls.Add(this.LightColorPictureBox);
            this.LightColorGroupBox.Controls.Add(this.LightColorCustomRadioButton);
            this.LightColorGroupBox.Controls.Add(this.LightColorWhiteRadioButton);
            this.LightColorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightColorGroupBox.Location = new System.Drawing.Point(3, 207);
            this.LightColorGroupBox.Name = "LightColorGroupBox";
            this.LightColorGroupBox.Size = new System.Drawing.Size(188, 56);
            this.LightColorGroupBox.TabIndex = 1;
            this.LightColorGroupBox.TabStop = false;
            this.LightColorGroupBox.Text = "Light Color";
            // 
            // LightColorPictureBox
            // 
            this.LightColorPictureBox.BackColor = System.Drawing.Color.White;
            this.LightColorPictureBox.Location = new System.Drawing.Point(144, 34);
            this.LightColorPictureBox.Name = "LightColorPictureBox";
            this.LightColorPictureBox.Size = new System.Drawing.Size(16, 16);
            this.LightColorPictureBox.TabIndex = 4;
            this.LightColorPictureBox.TabStop = false;
            this.LightColorPictureBox.Click += new System.EventHandler(this.LightColorPictureBox_Click);
            // 
            // LightColorCustomRadioButton
            // 
            this.LightColorCustomRadioButton.AutoSize = true;
            this.LightColorCustomRadioButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LightColorCustomRadioButton.Location = new System.Drawing.Point(3, 36);
            this.LightColorCustomRadioButton.Name = "LightColorCustomRadioButton";
            this.LightColorCustomRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.LightColorCustomRadioButton.Size = new System.Drawing.Size(182, 17);
            this.LightColorCustomRadioButton.TabIndex = 2;
            this.LightColorCustomRadioButton.Text = "Custom";
            this.LightColorCustomRadioButton.UseVisualStyleBackColor = true;
            this.LightColorCustomRadioButton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // LightColorWhiteRadioButton
            // 
            this.LightColorWhiteRadioButton.AutoSize = true;
            this.LightColorWhiteRadioButton.Checked = true;
            this.LightColorWhiteRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LightColorWhiteRadioButton.Location = new System.Drawing.Point(3, 16);
            this.LightColorWhiteRadioButton.Name = "LightColorWhiteRadioButton";
            this.LightColorWhiteRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.LightColorWhiteRadioButton.Size = new System.Drawing.Size(182, 17);
            this.LightColorWhiteRadioButton.TabIndex = 1;
            this.LightColorWhiteRadioButton.TabStop = true;
            this.LightColorWhiteRadioButton.Text = "White";
            this.LightColorWhiteRadioButton.UseVisualStyleBackColor = true;
            this.LightColorWhiteRadioButton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // NVectorGroupBox
            // 
            this.NVectorGroupBox.Controls.Add(this.ChangeBubbleSizeButton);
            this.NVectorGroupBox.Controls.Add(this.BubbleSizeNumeric);
            this.NVectorGroupBox.Controls.Add(this.BubbleCheckbox);
            this.NVectorGroupBox.Controls.Add(this.NVectorNormalMapPictureBox);
            this.NVectorGroupBox.Controls.Add(this.NVectorNormalMapRadioButton);
            this.NVectorGroupBox.Controls.Add(this.NVectorConstantRadioButton);
            this.NVectorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NVectorGroupBox.Location = new System.Drawing.Point(3, 349);
            this.NVectorGroupBox.Name = "NVectorGroupBox";
            this.NVectorGroupBox.Size = new System.Drawing.Size(188, 114);
            this.NVectorGroupBox.TabIndex = 2;
            this.NVectorGroupBox.TabStop = false;
            this.NVectorGroupBox.Text = "N Vector";
            // 
            // ChangeBubbleSizeButton
            // 
            this.ChangeBubbleSizeButton.Location = new System.Drawing.Point(90, 82);
            this.ChangeBubbleSizeButton.Name = "ChangeBubbleSizeButton";
            this.ChangeBubbleSizeButton.Size = new System.Drawing.Size(98, 23);
            this.ChangeBubbleSizeButton.TabIndex = 7;
            this.ChangeBubbleSizeButton.Text = "Set bubble radius";
            this.ChangeBubbleSizeButton.UseVisualStyleBackColor = true;
            this.ChangeBubbleSizeButton.Click += new System.EventHandler(this.ChangeBubbleSizeButton_Click);
            // 
            // BubbleSizeNumeric
            // 
            this.BubbleSizeNumeric.Location = new System.Drawing.Point(19, 82);
            this.BubbleSizeNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BubbleSizeNumeric.Name = "BubbleSizeNumeric";
            this.BubbleSizeNumeric.Size = new System.Drawing.Size(59, 20);
            this.BubbleSizeNumeric.TabIndex = 6;
            this.BubbleSizeNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BubbleCheckbox
            // 
            this.BubbleCheckbox.AutoSize = true;
            this.BubbleCheckbox.Location = new System.Drawing.Point(19, 59);
            this.BubbleCheckbox.Name = "BubbleCheckbox";
            this.BubbleCheckbox.Size = new System.Drawing.Size(59, 17);
            this.BubbleCheckbox.TabIndex = 5;
            this.BubbleCheckbox.Text = "Bubble";
            this.BubbleCheckbox.UseVisualStyleBackColor = true;
            // 
            // NVectorNormalMapPictureBox
            // 
            this.NVectorNormalMapPictureBox.Image = global::GKProject2.Properties.Resources.NormalMap;
            this.NVectorNormalMapPictureBox.Location = new System.Drawing.Point(144, 35);
            this.NVectorNormalMapPictureBox.Name = "NVectorNormalMapPictureBox";
            this.NVectorNormalMapPictureBox.Size = new System.Drawing.Size(16, 16);
            this.NVectorNormalMapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NVectorNormalMapPictureBox.TabIndex = 4;
            this.NVectorNormalMapPictureBox.TabStop = false;
            this.NVectorNormalMapPictureBox.Click += new System.EventHandler(this.NVectorNormalMapPictureBox_Click);
            // 
            // NVectorNormalMapRadioButton
            // 
            this.NVectorNormalMapRadioButton.AutoSize = true;
            this.NVectorNormalMapRadioButton.Location = new System.Drawing.Point(3, 36);
            this.NVectorNormalMapRadioButton.Name = "NVectorNormalMapRadioButton";
            this.NVectorNormalMapRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.NVectorNormalMapRadioButton.Size = new System.Drawing.Size(135, 17);
            this.NVectorNormalMapRadioButton.TabIndex = 1;
            this.NVectorNormalMapRadioButton.Text = "From normal map";
            this.NVectorNormalMapRadioButton.UseVisualStyleBackColor = true;
            this.NVectorNormalMapRadioButton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // NVectorConstantRadioButton
            // 
            this.NVectorConstantRadioButton.AutoSize = true;
            this.NVectorConstantRadioButton.Checked = true;
            this.NVectorConstantRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NVectorConstantRadioButton.Location = new System.Drawing.Point(3, 16);
            this.NVectorConstantRadioButton.Name = "NVectorConstantRadioButton";
            this.NVectorConstantRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.NVectorConstantRadioButton.Size = new System.Drawing.Size(182, 17);
            this.NVectorConstantRadioButton.TabIndex = 0;
            this.NVectorConstantRadioButton.TabStop = true;
            this.NVectorConstantRadioButton.Text = "Constant [0,0,1]";
            this.NVectorConstantRadioButton.UseVisualStyleBackColor = true;
            this.NVectorConstantRadioButton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // FillModeGroupBox
            // 
            this.FillModeGroupBox.Controls.Add(this.FillModeInterpolateRadioButton);
            this.FillModeGroupBox.Controls.Add(this.FillModeAccurateRadioButton);
            this.FillModeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillModeGroupBox.Location = new System.Drawing.Point(3, 145);
            this.FillModeGroupBox.Name = "FillModeGroupBox";
            this.FillModeGroupBox.Size = new System.Drawing.Size(188, 56);
            this.FillModeGroupBox.TabIndex = 6;
            this.FillModeGroupBox.TabStop = false;
            this.FillModeGroupBox.Text = "Fill Mode";
            // 
            // FillModeInterpolateRadioButton
            // 
            this.FillModeInterpolateRadioButton.AutoSize = true;
            this.FillModeInterpolateRadioButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FillModeInterpolateRadioButton.Location = new System.Drawing.Point(3, 36);
            this.FillModeInterpolateRadioButton.Name = "FillModeInterpolateRadioButton";
            this.FillModeInterpolateRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.FillModeInterpolateRadioButton.Size = new System.Drawing.Size(182, 17);
            this.FillModeInterpolateRadioButton.TabIndex = 1;
            this.FillModeInterpolateRadioButton.Text = "Interpolate";
            this.FillModeInterpolateRadioButton.UseVisualStyleBackColor = true;
            this.FillModeInterpolateRadioButton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // FillModeAccurateRadioButton
            // 
            this.FillModeAccurateRadioButton.AutoSize = true;
            this.FillModeAccurateRadioButton.Checked = true;
            this.FillModeAccurateRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FillModeAccurateRadioButton.Location = new System.Drawing.Point(3, 16);
            this.FillModeAccurateRadioButton.Name = "FillModeAccurateRadioButton";
            this.FillModeAccurateRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.FillModeAccurateRadioButton.Size = new System.Drawing.Size(182, 17);
            this.FillModeAccurateRadioButton.TabIndex = 0;
            this.FillModeAccurateRadioButton.TabStop = true;
            this.FillModeAccurateRadioButton.Text = "Accurate";
            this.FillModeAccurateRadioButton.UseVisualStyleBackColor = true;
            this.FillModeAccurateRadioButton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // MeshGroupBox
            // 
            this.MeshGroupBox.Controls.Add(this.MeshNewButton);
            this.MeshGroupBox.Controls.Add(this.label1);
            this.MeshGroupBox.Controls.Add(this.MeshVisibleCheckBox);
            this.MeshGroupBox.Controls.Add(this.MeshM);
            this.MeshGroupBox.Controls.Add(this.MeshN);
            this.MeshGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeshGroupBox.Location = new System.Drawing.Point(3, 3);
            this.MeshGroupBox.Name = "MeshGroupBox";
            this.MeshGroupBox.Size = new System.Drawing.Size(188, 74);
            this.MeshGroupBox.TabIndex = 7;
            this.MeshGroupBox.TabStop = false;
            this.MeshGroupBox.Text = "Mesh";
            // 
            // MeshNewButton
            // 
            this.MeshNewButton.Location = new System.Drawing.Point(6, 46);
            this.MeshNewButton.Name = "MeshNewButton";
            this.MeshNewButton.Size = new System.Drawing.Size(176, 23);
            this.MeshNewButton.TabIndex = 4;
            this.MeshNewButton.Text = "Set new mesh";
            this.MeshNewButton.UseVisualStyleBackColor = true;
            this.MeshNewButton.Click += new System.EventHandler(this.MeshNewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // MeshVisibleCheckBox
            // 
            this.MeshVisibleCheckBox.AutoSize = true;
            this.MeshVisibleCheckBox.Checked = true;
            this.MeshVisibleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MeshVisibleCheckBox.Location = new System.Drawing.Point(126, 23);
            this.MeshVisibleCheckBox.Name = "MeshVisibleCheckBox";
            this.MeshVisibleCheckBox.Size = new System.Drawing.Size(56, 17);
            this.MeshVisibleCheckBox.TabIndex = 2;
            this.MeshVisibleCheckBox.Text = "Visible";
            this.MeshVisibleCheckBox.UseVisualStyleBackColor = true;
            this.MeshVisibleCheckBox.CheckedChanged += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // MeshM
            // 
            this.MeshM.Location = new System.Drawing.Point(72, 19);
            this.MeshM.Name = "MeshM";
            this.MeshM.Size = new System.Drawing.Size(40, 20);
            this.MeshM.TabIndex = 1;
            this.MeshM.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // MeshN
            // 
            this.MeshN.Location = new System.Drawing.Point(6, 19);
            this.MeshN.Name = "MeshN";
            this.MeshN.Size = new System.Drawing.Size(40, 20);
            this.MeshN.TabIndex = 0;
            this.MeshN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // LightLocationGroupBox
            // 
            this.LightLocationGroupBox.Controls.Add(this.LightLocationCenterRadioButtton);
            this.LightLocationGroupBox.Controls.Add(this.LightLocationAnimatedRadioButtton);
            this.LightLocationGroupBox.Controls.Add(this.LightLocationDefaultRadioButton);
            this.LightLocationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightLocationGroupBox.Location = new System.Drawing.Point(3, 269);
            this.LightLocationGroupBox.Name = "LightLocationGroupBox";
            this.LightLocationGroupBox.Size = new System.Drawing.Size(188, 74);
            this.LightLocationGroupBox.TabIndex = 8;
            this.LightLocationGroupBox.TabStop = false;
            this.LightLocationGroupBox.Text = "Light Location";
            // 
            // LightLocationCenterRadioButtton
            // 
            this.LightLocationCenterRadioButtton.AutoSize = true;
            this.LightLocationCenterRadioButtton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LightLocationCenterRadioButtton.Location = new System.Drawing.Point(3, 33);
            this.LightLocationCenterRadioButtton.Name = "LightLocationCenterRadioButtton";
            this.LightLocationCenterRadioButtton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.LightLocationCenterRadioButtton.Size = new System.Drawing.Size(182, 21);
            this.LightLocationCenterRadioButtton.TabIndex = 4;
            this.LightLocationCenterRadioButtton.Text = "Center";
            this.LightLocationCenterRadioButtton.UseVisualStyleBackColor = true;
            this.LightLocationCenterRadioButtton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // LightLocationAnimatedRadioButtton
            // 
            this.LightLocationAnimatedRadioButtton.AutoSize = true;
            this.LightLocationAnimatedRadioButtton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LightLocationAnimatedRadioButtton.Location = new System.Drawing.Point(3, 54);
            this.LightLocationAnimatedRadioButtton.Name = "LightLocationAnimatedRadioButtton";
            this.LightLocationAnimatedRadioButtton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.LightLocationAnimatedRadioButtton.Size = new System.Drawing.Size(182, 17);
            this.LightLocationAnimatedRadioButtton.TabIndex = 3;
            this.LightLocationAnimatedRadioButtton.Text = "Animated";
            this.LightLocationAnimatedRadioButtton.UseVisualStyleBackColor = true;
            this.LightLocationAnimatedRadioButtton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // LightLocationDefaultRadioButton
            // 
            this.LightLocationDefaultRadioButton.AutoSize = true;
            this.LightLocationDefaultRadioButton.Checked = true;
            this.LightLocationDefaultRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LightLocationDefaultRadioButton.Location = new System.Drawing.Point(3, 16);
            this.LightLocationDefaultRadioButton.Name = "LightLocationDefaultRadioButton";
            this.LightLocationDefaultRadioButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.LightLocationDefaultRadioButton.Size = new System.Drawing.Size(182, 17);
            this.LightLocationDefaultRadioButton.TabIndex = 1;
            this.LightLocationDefaultRadioButton.TabStop = true;
            this.LightLocationDefaultRadioButton.Text = "Default";
            this.LightLocationDefaultRadioButton.UseVisualStyleBackColor = true;
            this.LightLocationDefaultRadioButton.Click += new System.EventHandler(this.RedrawBitmapHandler);
            // 
            // CoefficientsGroupBox
            // 
            this.CoefficientsGroupBox.Controls.Add(this.MLabel);
            this.CoefficientsGroupBox.Controls.Add(this.KsLabel);
            this.CoefficientsGroupBox.Controls.Add(this.KdLabel);
            this.CoefficientsGroupBox.Controls.Add(this.MBar);
            this.CoefficientsGroupBox.Controls.Add(this.KsBar);
            this.CoefficientsGroupBox.Controls.Add(this.KdBar);
            this.CoefficientsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoefficientsGroupBox.Location = new System.Drawing.Point(3, 469);
            this.CoefficientsGroupBox.Name = "CoefficientsGroupBox";
            this.CoefficientsGroupBox.Size = new System.Drawing.Size(188, 144);
            this.CoefficientsGroupBox.TabIndex = 9;
            this.CoefficientsGroupBox.TabStop = false;
            this.CoefficientsGroupBox.Text = "Coefficients";
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.Location = new System.Drawing.Point(130, 121);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(36, 13);
            this.MLabel.TabIndex = 5;
            this.MLabel.Text = " m = 1";
            // 
            // KsLabel
            // 
            this.KsLabel.AutoSize = true;
            this.KsLabel.Location = new System.Drawing.Point(130, 70);
            this.KsLabel.Name = "KsLabel";
            this.KsLabel.Size = new System.Drawing.Size(45, 13);
            this.KsLabel.TabIndex = 4;
            this.KsLabel.Text = "ks = 0.5";
            // 
            // KdLabel
            // 
            this.KdLabel.AutoSize = true;
            this.KdLabel.Location = new System.Drawing.Point(130, 19);
            this.KdLabel.Name = "KdLabel";
            this.KdLabel.Size = new System.Drawing.Size(46, 13);
            this.KdLabel.TabIndex = 3;
            this.KdLabel.Text = "kd = 0.5";
            // 
            // MBar
            // 
            this.MBar.Location = new System.Drawing.Point(9, 121);
            this.MBar.Maximum = 100;
            this.MBar.Minimum = 1;
            this.MBar.Name = "MBar";
            this.MBar.Size = new System.Drawing.Size(105, 45);
            this.MBar.TabIndex = 2;
            this.MBar.Value = 1;
            this.MBar.ValueChanged += new System.EventHandler(this.MBar_ValueChanged);
            // 
            // KsBar
            // 
            this.KsBar.Location = new System.Drawing.Point(9, 70);
            this.KsBar.Maximum = 100;
            this.KsBar.Name = "KsBar";
            this.KsBar.Size = new System.Drawing.Size(105, 45);
            this.KsBar.TabIndex = 1;
            this.KsBar.Value = 50;
            this.KsBar.ValueChanged += new System.EventHandler(this.KsBar_ValueChanged);
            // 
            // KdBar
            // 
            this.KdBar.Location = new System.Drawing.Point(9, 19);
            this.KdBar.Maximum = 100;
            this.KdBar.Name = "KdBar";
            this.KdBar.Size = new System.Drawing.Size(104, 45);
            this.KdBar.TabIndex = 0;
            this.KdBar.Value = 50;
            this.KdBar.ValueChanged += new System.EventHandler(this.KdBar_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Damian Bis - projekt2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.FillGroupBox.ResumeLayout(false);
            this.FillGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FillColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillTexturePictureBox)).EndInit();
            this.LightColorGroupBox.ResumeLayout(false);
            this.LightColorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LightColorPictureBox)).EndInit();
            this.NVectorGroupBox.ResumeLayout(false);
            this.NVectorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BubbleSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NVectorNormalMapPictureBox)).EndInit();
            this.FillModeGroupBox.ResumeLayout(false);
            this.FillModeGroupBox.PerformLayout();
            this.MeshGroupBox.ResumeLayout(false);
            this.MeshGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeshM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeshN)).EndInit();
            this.LightLocationGroupBox.ResumeLayout(false);
            this.LightLocationGroupBox.PerformLayout();
            this.CoefficientsGroupBox.ResumeLayout(false);
            this.CoefficientsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KsBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KdBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.PictureBox DrawingArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox FillGroupBox;
        private System.Windows.Forms.PictureBox FillColorPictureBox;
        private System.Windows.Forms.PictureBox FillTexturePictureBox;
        private System.Windows.Forms.RadioButton FillTextureRadioButton;
        private System.Windows.Forms.RadioButton FillColorRadioButton;
        private System.Windows.Forms.GroupBox LightColorGroupBox;
        private System.Windows.Forms.GroupBox NVectorGroupBox;
        private System.Windows.Forms.PictureBox NVectorNormalMapPictureBox;
        private System.Windows.Forms.RadioButton NVectorNormalMapRadioButton;
        private System.Windows.Forms.RadioButton NVectorConstantRadioButton;
        private System.Windows.Forms.GroupBox FillModeGroupBox;
        private System.Windows.Forms.RadioButton FillModeAccurateRadioButton;
        private System.Windows.Forms.RadioButton FillModeInterpolateRadioButton;
        private System.Windows.Forms.GroupBox MeshGroupBox;
        private System.Windows.Forms.GroupBox LightLocationGroupBox;
        private System.Windows.Forms.GroupBox CoefficientsGroupBox;
        private System.Windows.Forms.RadioButton LightColorCustomRadioButton;
        private System.Windows.Forms.RadioButton LightColorWhiteRadioButton;
        private System.Windows.Forms.RadioButton LightLocationCenterRadioButtton;
        private System.Windows.Forms.RadioButton LightLocationAnimatedRadioButtton;
        private System.Windows.Forms.RadioButton LightLocationDefaultRadioButton;
        private System.Windows.Forms.CheckBox MeshVisibleCheckBox;
        private System.Windows.Forms.NumericUpDown MeshM;
        private System.Windows.Forms.NumericUpDown MeshN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar MBar;
        private System.Windows.Forms.TrackBar KsBar;
        private System.Windows.Forms.TrackBar KdBar;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.Label KsLabel;
        private System.Windows.Forms.Label KdLabel;
        private System.Windows.Forms.PictureBox LightColorPictureBox;
        private System.Windows.Forms.Button MeshNewButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox BubbleCheckbox;
        private System.Windows.Forms.Button ChangeBubbleSizeButton;
        private System.Windows.Forms.NumericUpDown BubbleSizeNumeric;
    }
}

