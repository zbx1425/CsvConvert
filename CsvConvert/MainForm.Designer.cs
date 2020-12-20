
namespace CsvConvert
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBoxCredit;
		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.LinkLabel linkLabelCredit;
		private System.Windows.Forms.GroupBox groupBoxOutputFormat;
		private System.Windows.Forms.GroupBox groupBoxTransform;
		private System.Windows.Forms.GroupBox groupBoxMisc;
		private System.Windows.Forms.GroupBox groupBoxStart;
		private System.Windows.Forms.FlowLayoutPanel flpOutputFormat;
		private System.Windows.Forms.RadioButton rbCsvModel;
		private System.Windows.Forms.RadioButton rbStaticHmmo;
		private System.Windows.Forms.TableLayoutPanel tlpTransform;
		private System.Windows.Forms.Label labelTranslate;
		private System.Windows.Forms.Label labelScale;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Label labelRotate;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.Label labelZ;
		private System.Windows.Forms.NumericUpDown nudSZ;
		private System.Windows.Forms.NumericUpDown nudSY;
		private System.Windows.Forms.NumericUpDown nudSX;
		private System.Windows.Forms.NumericUpDown nudRZ;
		private System.Windows.Forms.NumericUpDown nudRY;
		private System.Windows.Forms.NumericUpDown nudRX;
		private System.Windows.Forms.NumericUpDown nudTZ;
		private System.Windows.Forms.NumericUpDown nudTY;
		private System.Windows.Forms.NumericUpDown nudTX;
		private System.Windows.Forms.TableLayoutPanel tlpCredit;
		private System.Windows.Forms.PictureBox pictureBoxAvatar;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.Label labelDragDrop;
		private System.Windows.Forms.Label labelMirror;
		private System.Windows.Forms.Label labelTransformSequence;
		private System.Windows.Forms.CheckBox cbMirrorY;
		private System.Windows.Forms.CheckBox cbMirrorX;
		private System.Windows.Forms.CheckBox cbMirrorZ;
		private System.Windows.Forms.TableLayoutPanel tlpStart;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCredit = new System.Windows.Forms.GroupBox();
            this.tlpCredit = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelCredit = new System.Windows.Forms.LinkLabel();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.groupBoxOutputFormat = new System.Windows.Forms.GroupBox();
            this.flpOutputFormat = new System.Windows.Forms.FlowLayoutPanel();
            this.rbCsvModel = new System.Windows.Forms.RadioButton();
            this.cbOutputNormals = new System.Windows.Forms.CheckBox();
            this.rbStaticHmmo = new System.Windows.Forms.RadioButton();
            this.groupBoxTransform = new System.Windows.Forms.GroupBox();
            this.tlpTransform = new System.Windows.Forms.TableLayoutPanel();
            this.cbMirrorZ = new System.Windows.Forms.CheckBox();
            this.labelTransformSequence = new System.Windows.Forms.Label();
            this.cbMirrorY = new System.Windows.Forms.CheckBox();
            this.labelMirror = new System.Windows.Forms.Label();
            this.nudSZ = new System.Windows.Forms.NumericUpDown();
            this.nudSY = new System.Windows.Forms.NumericUpDown();
            this.nudSX = new System.Windows.Forms.NumericUpDown();
            this.nudRZ = new System.Windows.Forms.NumericUpDown();
            this.nudRY = new System.Windows.Forms.NumericUpDown();
            this.nudRX = new System.Windows.Forms.NumericUpDown();
            this.nudTZ = new System.Windows.Forms.NumericUpDown();
            this.nudTY = new System.Windows.Forms.NumericUpDown();
            this.labelScale = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelRotate = new System.Windows.Forms.Label();
            this.labelTranslate = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.nudTX = new System.Windows.Forms.NumericUpDown();
            this.cbMirrorX = new System.Windows.Forms.CheckBox();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.tlpMisc = new System.Windows.Forms.TableLayoutPanel();
            this.labelLocalCP = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelFace2Type = new System.Windows.Forms.Label();
            this.labelTransparentColor = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.cbFace2Type = new System.Windows.Forms.ComboBox();
            this.btnSetTransparent = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRoundV = new System.Windows.Forms.Label();
            this.nudRoundV = new System.Windows.Forms.NumericUpDown();
            this.labelRoundUV = new System.Windows.Forms.Label();
            this.nudRoundUV = new System.Windows.Forms.NumericUpDown();
            this.cbLocalCP = new System.Windows.Forms.CheckBox();
            this.groupBoxStart = new System.Windows.Forms.GroupBox();
            this.tlpStart = new System.Windows.Forms.TableLayoutPanel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.labelDragDrop = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.groupBoxCredit.SuspendLayout();
            this.tlpCredit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.groupBoxOutputFormat.SuspendLayout();
            this.flpOutputFormat.SuspendLayout();
            this.groupBoxTransform.SuspendLayout();
            this.tlpTransform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTX)).BeginInit();
            this.groupBoxMisc.SuspendLayout();
            this.tlpMisc.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundUV)).BeginInit();
            this.groupBoxStart.SuspendLayout();
            this.tlpStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.groupBoxCredit, 0, 0);
            this.tlpMain.Controls.Add(this.groupBoxOutputFormat, 1, 0);
            this.tlpMain.Controls.Add(this.groupBoxTransform, 0, 2);
            this.tlpMain.Controls.Add(this.groupBoxMisc, 0, 1);
            this.tlpMain.Controls.Add(this.groupBoxStart, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(8);
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(584, 435);
            this.tlpMain.TabIndex = 0;
            // 
            // groupBoxCredit
            // 
            this.groupBoxCredit.AutoSize = true;
            this.groupBoxCredit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCredit.Controls.Add(this.tlpCredit);
            this.groupBoxCredit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxCredit.Location = new System.Drawing.Point(11, 11);
            this.groupBoxCredit.Name = "groupBoxCredit";
            this.groupBoxCredit.Size = new System.Drawing.Size(302, 80);
            this.groupBoxCredit.TabIndex = 0;
            this.groupBoxCredit.TabStop = false;
            this.groupBoxCredit.Text = "Credit";
            // 
            // tlpCredit
            // 
            this.tlpCredit.AutoSize = true;
            this.tlpCredit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCredit.ColumnCount = 2;
            this.tlpCredit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCredit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCredit.Controls.Add(this.linkLabelCredit, 1, 0);
            this.tlpCredit.Controls.Add(this.pictureBoxAvatar, 0, 0);
            this.tlpCredit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCredit.Location = new System.Drawing.Point(3, 17);
            this.tlpCredit.Name = "tlpCredit";
            this.tlpCredit.RowCount = 1;
            this.tlpCredit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCredit.Size = new System.Drawing.Size(296, 60);
            this.tlpCredit.TabIndex = 0;
            // 
            // linkLabelCredit
            // 
            this.linkLabelCredit.AutoSize = true;
            this.linkLabelCredit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabelCredit.LinkArea = new System.Windows.Forms.LinkArea(30, 14);
            this.linkLabelCredit.Location = new System.Drawing.Point(68, 0);
            this.linkLabelCredit.Name = "linkLabelCredit";
            this.linkLabelCredit.Size = new System.Drawing.Size(225, 60);
            this.linkLabelCredit.TabIndex = 2;
            this.linkLabelCredit.TabStop = true;
            this.linkLabelCredit.Text = "(C) Nemo (zbx1425) 2020\r\nWeb: www.zbx1425.cn\r\nEmail: zbx1425@outlook.com\r\nParsers" +
    " (C) OpenBVE Project";
            this.linkLabelCredit.UseCompatibleTextRendering = true;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.Image")));
            this.pictureBoxAvatar.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(59, 54);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 3;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // groupBoxOutputFormat
            // 
            this.groupBoxOutputFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxOutputFormat.Controls.Add(this.flpOutputFormat);
            this.groupBoxOutputFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputFormat.Location = new System.Drawing.Point(326, 11);
            this.groupBoxOutputFormat.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBoxOutputFormat.Name = "groupBoxOutputFormat";
            this.groupBoxOutputFormat.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.groupBoxOutputFormat.Size = new System.Drawing.Size(247, 80);
            this.groupBoxOutputFormat.TabIndex = 1;
            this.groupBoxOutputFormat.TabStop = false;
            this.groupBoxOutputFormat.Text = "Output Format";
            // 
            // flpOutputFormat
            // 
            this.flpOutputFormat.AutoSize = true;
            this.flpOutputFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpOutputFormat.Controls.Add(this.rbCsvModel);
            this.flpOutputFormat.Controls.Add(this.cbOutputNormals);
            this.flpOutputFormat.Controls.Add(this.rbStaticHmmo);
            this.flpOutputFormat.Location = new System.Drawing.Point(8, 17);
            this.flpOutputFormat.Name = "flpOutputFormat";
            this.flpOutputFormat.Size = new System.Drawing.Size(194, 44);
            this.flpOutputFormat.TabIndex = 0;
            // 
            // rbCsvModel
            // 
            this.rbCsvModel.AutoSize = true;
            this.rbCsvModel.Checked = true;
            this.rbCsvModel.Location = new System.Drawing.Point(3, 3);
            this.rbCsvModel.Name = "rbCsvModel";
            this.rbCsvModel.Size = new System.Drawing.Size(77, 16);
            this.rbCsvModel.TabIndex = 0;
            this.rbCsvModel.TabStop = true;
            this.rbCsvModel.Text = "CSV Model";
            this.rbCsvModel.UseVisualStyleBackColor = true;
            this.rbCsvModel.CheckedChanged += new System.EventHandler(this.rbCsvModel_CheckedChanged);
            // 
            // cbOutputNormals
            // 
            this.cbOutputNormals.AutoSize = true;
            this.flpOutputFormat.SetFlowBreak(this.cbOutputNormals, true);
            this.cbOutputNormals.Location = new System.Drawing.Point(83, 3);
            this.cbOutputNormals.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cbOutputNormals.Name = "cbOutputNormals";
            this.cbOutputNormals.Size = new System.Drawing.Size(108, 16);
            this.cbOutputNormals.TabIndex = 2;
            this.cbOutputNormals.Text = "(With Normals)";
            this.cbOutputNormals.UseVisualStyleBackColor = true;
            // 
            // rbStaticHmmo
            // 
            this.rbStaticHmmo.AutoSize = true;
            this.rbStaticHmmo.Enabled = false;
            this.rbStaticHmmo.Location = new System.Drawing.Point(3, 25);
            this.rbStaticHmmo.Name = "rbStaticHmmo";
            this.rbStaticHmmo.Size = new System.Drawing.Size(89, 16);
            this.rbStaticHmmo.TabIndex = 1;
            this.rbStaticHmmo.Text = "Static HMMO";
            this.rbStaticHmmo.UseVisualStyleBackColor = true;
            // 
            // groupBoxTransform
            // 
            this.groupBoxTransform.AutoSize = true;
            this.groupBoxTransform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxTransform.Controls.Add(this.tlpTransform);
            this.groupBoxTransform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTransform.Location = new System.Drawing.Point(11, 267);
            this.groupBoxTransform.Name = "groupBoxTransform";
            this.groupBoxTransform.Size = new System.Drawing.Size(302, 158);
            this.groupBoxTransform.TabIndex = 2;
            this.groupBoxTransform.TabStop = false;
            this.groupBoxTransform.Text = "Transform";
            // 
            // tlpTransform
            // 
            this.tlpTransform.AutoSize = true;
            this.tlpTransform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTransform.ColumnCount = 4;
            this.tlpTransform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTransform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTransform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTransform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTransform.Controls.Add(this.cbMirrorZ, 3, 4);
            this.tlpTransform.Controls.Add(this.labelTransformSequence, 0, 0);
            this.tlpTransform.Controls.Add(this.cbMirrorY, 2, 4);
            this.tlpTransform.Controls.Add(this.labelMirror, 0, 4);
            this.tlpTransform.Controls.Add(this.nudSZ, 3, 3);
            this.tlpTransform.Controls.Add(this.nudSY, 2, 3);
            this.tlpTransform.Controls.Add(this.nudSX, 1, 3);
            this.tlpTransform.Controls.Add(this.nudRZ, 3, 2);
            this.tlpTransform.Controls.Add(this.nudRY, 2, 2);
            this.tlpTransform.Controls.Add(this.nudRX, 1, 2);
            this.tlpTransform.Controls.Add(this.nudTZ, 3, 1);
            this.tlpTransform.Controls.Add(this.nudTY, 2, 1);
            this.tlpTransform.Controls.Add(this.labelScale, 0, 3);
            this.tlpTransform.Controls.Add(this.labelX, 1, 0);
            this.tlpTransform.Controls.Add(this.labelRotate, 0, 2);
            this.tlpTransform.Controls.Add(this.labelTranslate, 0, 1);
            this.tlpTransform.Controls.Add(this.labelY, 2, 0);
            this.tlpTransform.Controls.Add(this.labelZ, 3, 0);
            this.tlpTransform.Controls.Add(this.nudTX, 1, 1);
            this.tlpTransform.Controls.Add(this.cbMirrorX, 1, 4);
            this.tlpTransform.Location = new System.Drawing.Point(3, 17);
            this.tlpTransform.Name = "tlpTransform";
            this.tlpTransform.RowCount = 5;
            this.tlpTransform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTransform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTransform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTransform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTransform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTransform.Size = new System.Drawing.Size(293, 121);
            this.tlpTransform.TabIndex = 0;
            // 
            // cbMirrorZ
            // 
            this.cbMirrorZ.AutoSize = true;
            this.cbMirrorZ.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMirrorZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMirrorZ.Location = new System.Drawing.Point(220, 104);
            this.cbMirrorZ.Name = "cbMirrorZ";
            this.cbMirrorZ.Size = new System.Drawing.Size(70, 14);
            this.cbMirrorZ.TabIndex = 19;
            this.cbMirrorZ.UseVisualStyleBackColor = true;
            // 
            // labelTransformSequence
            // 
            this.labelTransformSequence.AutoSize = true;
            this.labelTransformSequence.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTransformSequence.Location = new System.Drawing.Point(3, 0);
            this.labelTransformSequence.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.labelTransformSequence.Name = "labelTransformSequence";
            this.labelTransformSequence.Size = new System.Drawing.Size(59, 12);
            this.labelTransformSequence.TabIndex = 18;
            this.labelTransformSequence.Text = "M>S>R>T";
            this.labelTransformSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMirrorY
            // 
            this.cbMirrorY.AutoSize = true;
            this.cbMirrorY.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMirrorY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMirrorY.Location = new System.Drawing.Point(144, 104);
            this.cbMirrorY.Name = "cbMirrorY";
            this.cbMirrorY.Size = new System.Drawing.Size(70, 14);
            this.cbMirrorY.TabIndex = 17;
            this.cbMirrorY.UseVisualStyleBackColor = true;
            // 
            // labelMirror
            // 
            this.labelMirror.AutoSize = true;
            this.labelMirror.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMirror.Location = new System.Drawing.Point(3, 101);
            this.labelMirror.Name = "labelMirror";
            this.labelMirror.Size = new System.Drawing.Size(59, 12);
            this.labelMirror.TabIndex = 15;
            this.labelMirror.Text = "Mirror";
            this.labelMirror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSZ
            // 
            this.nudSZ.DecimalPlaces = 3;
            this.nudSZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSZ.Location = new System.Drawing.Point(220, 77);
            this.nudSZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSZ.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudSZ.Name = "nudSZ";
            this.nudSZ.Size = new System.Drawing.Size(70, 21);
            this.nudSZ.TabIndex = 14;
            this.nudSZ.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudSY
            // 
            this.nudSY.DecimalPlaces = 3;
            this.nudSY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSY.Location = new System.Drawing.Point(144, 77);
            this.nudSY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSY.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudSY.Name = "nudSY";
            this.nudSY.Size = new System.Drawing.Size(70, 21);
            this.nudSY.TabIndex = 13;
            this.nudSY.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudSX
            // 
            this.nudSX.DecimalPlaces = 3;
            this.nudSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudSX.Location = new System.Drawing.Point(68, 77);
            this.nudSX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSX.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudSX.Name = "nudSX";
            this.nudSX.Size = new System.Drawing.Size(70, 21);
            this.nudSX.TabIndex = 12;
            this.nudSX.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudRZ
            // 
            this.nudRZ.DecimalPlaces = 3;
            this.nudRZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRZ.Location = new System.Drawing.Point(220, 50);
            this.nudRZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRZ.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudRZ.Name = "nudRZ";
            this.nudRZ.Size = new System.Drawing.Size(70, 21);
            this.nudRZ.TabIndex = 11;
            this.nudRZ.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudRY
            // 
            this.nudRY.DecimalPlaces = 3;
            this.nudRY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRY.Location = new System.Drawing.Point(144, 50);
            this.nudRY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRY.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudRY.Name = "nudRY";
            this.nudRY.Size = new System.Drawing.Size(70, 21);
            this.nudRY.TabIndex = 10;
            this.nudRY.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudRX
            // 
            this.nudRX.DecimalPlaces = 3;
            this.nudRX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudRX.Location = new System.Drawing.Point(68, 50);
            this.nudRX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRX.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudRX.Name = "nudRX";
            this.nudRX.Size = new System.Drawing.Size(70, 21);
            this.nudRX.TabIndex = 9;
            this.nudRX.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudTZ
            // 
            this.nudTZ.DecimalPlaces = 3;
            this.nudTZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTZ.Location = new System.Drawing.Point(220, 23);
            this.nudTZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTZ.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTZ.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudTZ.Name = "nudTZ";
            this.nudTZ.Size = new System.Drawing.Size(70, 21);
            this.nudTZ.TabIndex = 8;
            this.nudTZ.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // nudTY
            // 
            this.nudTY.DecimalPlaces = 3;
            this.nudTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTY.Location = new System.Drawing.Point(144, 23);
            this.nudTY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTY.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudTY.Name = "nudTY";
            this.nudTY.Size = new System.Drawing.Size(70, 21);
            this.nudTY.TabIndex = 7;
            this.nudTY.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelScale.Location = new System.Drawing.Point(3, 74);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(59, 12);
            this.labelScale.TabIndex = 3;
            this.labelScale.Text = "Scale";
            this.labelScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX.Location = new System.Drawing.Point(68, 0);
            this.labelX.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(70, 12);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRotate
            // 
            this.labelRotate.AutoSize = true;
            this.labelRotate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRotate.Location = new System.Drawing.Point(3, 47);
            this.labelRotate.Name = "labelRotate";
            this.labelRotate.Size = new System.Drawing.Size(59, 12);
            this.labelRotate.TabIndex = 1;
            this.labelRotate.Text = "Rotate";
            this.labelRotate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTranslate
            // 
            this.labelTranslate.AutoSize = true;
            this.labelTranslate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTranslate.Location = new System.Drawing.Point(3, 20);
            this.labelTranslate.Name = "labelTranslate";
            this.labelTranslate.Size = new System.Drawing.Size(59, 12);
            this.labelTranslate.TabIndex = 0;
            this.labelTranslate.Text = "Translate";
            this.labelTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelY.Location = new System.Drawing.Point(144, 0);
            this.labelY.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(70, 12);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelZ.Location = new System.Drawing.Point(220, 0);
            this.labelZ.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(70, 12);
            this.labelZ.TabIndex = 5;
            this.labelZ.Text = "Z";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTX
            // 
            this.nudTX.DecimalPlaces = 3;
            this.nudTX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTX.Location = new System.Drawing.Point(68, 23);
            this.nudTX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTX.MinimumSize = new System.Drawing.Size(70, 0);
            this.nudTX.Name = "nudTX";
            this.nudTX.Size = new System.Drawing.Size(70, 21);
            this.nudTX.TabIndex = 6;
            this.nudTX.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // cbMirrorX
            // 
            this.cbMirrorX.AutoSize = true;
            this.cbMirrorX.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbMirrorX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMirrorX.Location = new System.Drawing.Point(68, 104);
            this.cbMirrorX.Name = "cbMirrorX";
            this.cbMirrorX.Size = new System.Drawing.Size(70, 14);
            this.cbMirrorX.TabIndex = 16;
            this.cbMirrorX.UseVisualStyleBackColor = true;
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.AutoSize = true;
            this.groupBoxMisc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxMisc.Controls.Add(this.tlpMisc);
            this.groupBoxMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMisc.Location = new System.Drawing.Point(11, 97);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Padding = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.groupBoxMisc.Size = new System.Drawing.Size(302, 164);
            this.groupBoxMisc.TabIndex = 3;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Misc";
            // 
            // tlpMisc
            // 
            this.tlpMisc.AutoSize = true;
            this.tlpMisc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMisc.ColumnCount = 2;
            this.tlpMisc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMisc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMisc.Controls.Add(this.labelLocalCP, 0, 4);
            this.tlpMisc.Controls.Add(this.cbLanguage, 1, 0);
            this.tlpMisc.Controls.Add(this.labelLanguage, 0, 0);
            this.tlpMisc.Controls.Add(this.labelFace2Type, 0, 3);
            this.tlpMisc.Controls.Add(this.labelTransparentColor, 0, 2);
            this.tlpMisc.Controls.Add(this.labelRound, 0, 1);
            this.tlpMisc.Controls.Add(this.cbFace2Type, 1, 3);
            this.tlpMisc.Controls.Add(this.btnSetTransparent, 1, 2);
            this.tlpMisc.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tlpMisc.Controls.Add(this.cbLocalCP, 1, 4);
            this.tlpMisc.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMisc.Location = new System.Drawing.Point(8, 17);
            this.tlpMisc.Name = "tlpMisc";
            this.tlpMisc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tlpMisc.RowCount = 5;
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMisc.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMisc.Size = new System.Drawing.Size(291, 144);
            this.tlpMisc.TabIndex = 1;
            // 
            // labelLocalCP
            // 
            this.labelLocalCP.AutoSize = true;
            this.labelLocalCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLocalCP.Location = new System.Drawing.Point(3, 114);
            this.labelLocalCP.Name = "labelLocalCP";
            this.labelLocalCP.Size = new System.Drawing.Size(107, 12);
            this.labelLocalCP.TabIndex = 12;
            this.labelLocalCP.Text = "Local Code Page";
            this.labelLocalCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbLanguage
            // 
            this.cbLanguage.DisplayMember = "Value";
            this.cbLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(116, 3);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(172, 20);
            this.cbLanguage.TabIndex = 11;
            this.cbLanguage.ValueMember = "Key";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLanguage.Location = new System.Drawing.Point(3, 0);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(107, 12);
            this.labelLanguage.TabIndex = 10;
            this.labelLanguage.Text = "Language 语言";
            this.labelLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFace2Type
            // 
            this.labelFace2Type.AutoSize = true;
            this.labelFace2Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFace2Type.Location = new System.Drawing.Point(3, 88);
            this.labelFace2Type.Name = "labelFace2Type";
            this.labelFace2Type.Size = new System.Drawing.Size(107, 12);
            this.labelFace2Type.TabIndex = 4;
            this.labelFace2Type.Text = "Double-sided Face";
            this.labelFace2Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTransparentColor
            // 
            this.labelTransparentColor.AutoSize = true;
            this.labelTransparentColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTransparentColor.Location = new System.Drawing.Point(3, 59);
            this.labelTransparentColor.Name = "labelTransparentColor";
            this.labelTransparentColor.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.labelTransparentColor.Size = new System.Drawing.Size(107, 28);
            this.labelTransparentColor.TabIndex = 3;
            this.labelTransparentColor.Text = "Transparent Color";
            this.labelTransparentColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRound.Location = new System.Drawing.Point(3, 26);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(107, 12);
            this.labelRound.TabIndex = 1;
            this.labelRound.Text = "Digit Places";
            this.labelRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFace2Type
            // 
            this.cbFace2Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFace2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFace2Type.FormattingEnabled = true;
            this.cbFace2Type.Items.AddRange(new object[] {
            "No modification",
            "Face2 (Incorrect lighting)",
            "Copy all (Bad perf)"});
            this.cbFace2Type.Location = new System.Drawing.Point(116, 91);
            this.cbFace2Type.Name = "cbFace2Type";
            this.cbFace2Type.Size = new System.Drawing.Size(172, 20);
            this.cbFace2Type.TabIndex = 5;
            // 
            // btnSetTransparent
            // 
            this.btnSetTransparent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetTransparent.Location = new System.Drawing.Point(116, 62);
            this.btnSetTransparent.Name = "btnSetTransparent";
            this.btnSetTransparent.Size = new System.Drawing.Size(172, 23);
            this.btnSetTransparent.TabIndex = 8;
            this.btnSetTransparent.Text = "Not Assigned";
            this.btnSetTransparent.UseVisualStyleBackColor = true;
            this.btnSetTransparent.Click += new System.EventHandler(this.btnSetTransparent_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.labelRoundV);
            this.flowLayoutPanel1.Controls.Add(this.nudRoundV);
            this.flowLayoutPanel1.Controls.Add(this.labelRoundUV);
            this.flowLayoutPanel1.Controls.Add(this.nudRoundUV);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(153, 27);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // labelRoundV
            // 
            this.labelRoundV.AutoSize = true;
            this.labelRoundV.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRoundV.Location = new System.Drawing.Point(3, 0);
            this.labelRoundV.Name = "labelRoundV";
            this.labelRoundV.Size = new System.Drawing.Size(47, 12);
            this.labelRoundV.TabIndex = 9;
            this.labelRoundV.Text = "Vertex:";
            this.labelRoundV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRoundV
            // 
            this.nudRoundV.AutoSize = true;
            this.nudRoundV.Location = new System.Drawing.Point(56, 3);
            this.nudRoundV.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudRoundV.Name = "nudRoundV";
            this.nudRoundV.Size = new System.Drawing.Size(27, 21);
            this.nudRoundV.TabIndex = 8;
            this.nudRoundV.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelRoundUV
            // 
            this.labelRoundUV.AutoSize = true;
            this.labelRoundUV.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRoundUV.Location = new System.Drawing.Point(94, 0);
            this.labelRoundUV.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.labelRoundUV.Name = "labelRoundUV";
            this.labelRoundUV.Size = new System.Drawing.Size(23, 12);
            this.labelRoundUV.TabIndex = 10;
            this.labelRoundUV.Text = "UV:";
            this.labelRoundUV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudRoundUV
            // 
            this.nudRoundUV.AutoSize = true;
            this.nudRoundUV.Location = new System.Drawing.Point(123, 3);
            this.nudRoundUV.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudRoundUV.Name = "nudRoundUV";
            this.nudRoundUV.Size = new System.Drawing.Size(27, 21);
            this.nudRoundUV.TabIndex = 11;
            this.nudRoundUV.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cbLocalCP
            // 
            this.cbLocalCP.AutoSize = true;
            this.cbLocalCP.Location = new System.Drawing.Point(116, 117);
            this.cbLocalCP.Name = "cbLocalCP";
            this.cbLocalCP.Size = new System.Drawing.Size(168, 16);
            this.cbLocalCP.TabIndex = 13;
            this.cbLocalCP.Text = "Tick if mojibake appears";
            this.cbLocalCP.UseVisualStyleBackColor = true;
            // 
            // groupBoxStart
            // 
            this.groupBoxStart.Controls.Add(this.tlpStart);
            this.groupBoxStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStart.Location = new System.Drawing.Point(326, 97);
            this.groupBoxStart.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBoxStart.Name = "groupBoxStart";
            this.tlpMain.SetRowSpan(this.groupBoxStart, 2);
            this.groupBoxStart.Size = new System.Drawing.Size(247, 328);
            this.groupBoxStart.TabIndex = 4;
            this.groupBoxStart.TabStop = false;
            this.groupBoxStart.Text = "Start Conversion";
            // 
            // tlpStart
            // 
            this.tlpStart.ColumnCount = 1;
            this.tlpStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStart.Controls.Add(this.tbLog, 0, 2);
            this.tlpStart.Controls.Add(this.labelDragDrop, 0, 1);
            this.tlpStart.Controls.Add(this.btnSelectFile, 0, 0);
            this.tlpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStart.Location = new System.Drawing.Point(3, 17);
            this.tlpStart.Name = "tlpStart";
            this.tlpStart.RowCount = 3;
            this.tlpStart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpStart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStart.Size = new System.Drawing.Size(241, 308);
            this.tlpStart.TabIndex = 0;
            // 
            // tbLog
            // 
            this.tbLog.AllowDrop = true;
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(3, 43);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(235, 262);
            this.tbLog.TabIndex = 2;
            this.tbLog.WordWrap = false;
            this.tbLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbLogDragDrop);
            this.tbLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbLogDragEnter);
            this.tbLog.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLog_KeyDown);
            // 
            // labelDragDrop
            // 
            this.labelDragDrop.AutoSize = true;
            this.labelDragDrop.Location = new System.Drawing.Point(3, 28);
            this.labelDragDrop.Name = "labelDragDrop";
            this.labelDragDrop.Size = new System.Drawing.Size(221, 12);
            this.labelDragDrop.TabIndex = 1;
            this.labelDragDrop.Text = "Or drag-drop them into the box below";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.AutoSize = true;
            this.btnSelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectFile.Location = new System.Drawing.Point(3, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSelectFile.Size = new System.Drawing.Size(107, 22);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select Files";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFileClick);
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 435);
            this.Controls.Add(this.tlpMain);
            this.Name = "MainForm";
            this.Text = "Csv Model Converter";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.groupBoxCredit.ResumeLayout(false);
            this.groupBoxCredit.PerformLayout();
            this.tlpCredit.ResumeLayout(false);
            this.tlpCredit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.groupBoxOutputFormat.ResumeLayout(false);
            this.groupBoxOutputFormat.PerformLayout();
            this.flpOutputFormat.ResumeLayout(false);
            this.flpOutputFormat.PerformLayout();
            this.groupBoxTransform.ResumeLayout(false);
            this.groupBoxTransform.PerformLayout();
            this.tlpTransform.ResumeLayout(false);
            this.tlpTransform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTX)).EndInit();
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.tlpMisc.ResumeLayout(false);
            this.tlpMisc.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoundUV)).EndInit();
            this.groupBoxStart.ResumeLayout(false);
            this.tlpStart.ResumeLayout(false);
            this.tlpStart.PerformLayout();
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.CheckBox cbOutputNormals;
        private System.Windows.Forms.TableLayoutPanel tlpMisc;
        private System.Windows.Forms.Label labelFace2Type;
        private System.Windows.Forms.Label labelTransparentColor;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.ComboBox cbFace2Type;
        private System.Windows.Forms.Button btnSetTransparent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelRoundV;
        private System.Windows.Forms.NumericUpDown nudRoundV;
        private System.Windows.Forms.Label labelRoundUV;
        private System.Windows.Forms.NumericUpDown nudRoundUV;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelLocalCP;
        private System.Windows.Forms.CheckBox cbLocalCP;
    }
}