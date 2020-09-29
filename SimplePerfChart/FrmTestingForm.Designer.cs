namespace SimplePerfChart
{
    partial class FrmTestingForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
       private void InitializeComponent() {
            realtimeChart.ChartPen chartPen1 = new realtimeChart.ChartPen();
            realtimeChart.ChartPen chartPen2 = new realtimeChart.ChartPen();
            realtimeChart.PenStyle penStyle1 = new realtimeChart.PenStyle();
            realtimeChart.ChartPen chartPen3 = new realtimeChart.ChartPen();
            realtimeChart.PenStyle penStyle2 = new realtimeChart.PenStyle();
            realtimeChart.ChartPen chartPen4 = new realtimeChart.ChartPen();
            realtimeChart.PenStyle penStyle3 = new realtimeChart.PenStyle();
            realtimeChart.ChartPen chartPen5 = new realtimeChart.ChartPen();
            realtimeChart.PenStyle penStyle4 = new realtimeChart.PenStyle();
            realtimeChart.ChartPen chartPen6 = new realtimeChart.ChartPen();
            this.grpBxRandVal = new System.Windows.Forms.GroupBox();
            this.chkBxTimerEnabled = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numUpDnToInterval = new System.Windows.Forms.NumericUpDown();
            this.numUpDnFromInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBxValueGen = new System.Windows.Forms.GroupBox();
            this.numUpDnValTo = new System.Windows.Forms.NumericUpDown();
            this.numUpDnValFrom = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numUpDnChartOffset = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDnChartSize = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numUpDnTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBxTimerMode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBxBorder = new System.Windows.Forms.ComboBox();
            this.bgWrkTimer = new System.ComponentModel.BackgroundWorker();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Chart = new System.Windows.Forms.TabPage();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.Pen1 = new System.Windows.Forms.TabPage();
            this.propGrid1 = new System.Windows.Forms.PropertyGrid();
            this.Pen2 = new System.Windows.Forms.TabPage();
            this.propGrid2 = new System.Windows.Forms.PropertyGrid();
            this.Pen3 = new System.Windows.Forms.TabPage();
            this.propGrid3 = new System.Windows.Forms.PropertyGrid();
            this.Pen4 = new System.Windows.Forms.TabPage();
            this.propGrid4 = new System.Windows.Forms.PropertyGrid();
            this.btnCanOn = new System.Windows.Forms.Button();
            this.btnCanOFF = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainChart = new realtimeChart.RealtimeChart();
            this.grpBxRandVal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnToInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFromInterval)).BeginInit();
            this.grpBxValueGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnValTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnValFrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnChartOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnChartSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnTimerInterval)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Chart.SuspendLayout();
            this.Pen1.SuspendLayout();
            this.Pen2.SuspendLayout();
            this.Pen3.SuspendLayout();
            this.Pen4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxRandVal
            // 
            this.grpBxRandVal.Controls.Add(this.chkBxTimerEnabled);
            this.grpBxRandVal.Controls.Add(this.label5);
            this.grpBxRandVal.Controls.Add(this.numUpDnToInterval);
            this.grpBxRandVal.Controls.Add(this.numUpDnFromInterval);
            this.grpBxRandVal.Controls.Add(this.label3);
            this.grpBxRandVal.Controls.Add(this.label2);
            this.grpBxRandVal.Location = new System.Drawing.Point(250, 465);
            this.grpBxRandVal.Name = "grpBxRandVal";
            this.grpBxRandVal.Size = new System.Drawing.Size(259, 90);
            this.grpBxRandVal.TabIndex = 1;
            this.grpBxRandVal.TabStop = false;
            this.grpBxRandVal.Text = "Value Generator Timer";
            // 
            // chkBxTimerEnabled
            // 
            this.chkBxTimerEnabled.AutoSize = true;
            this.chkBxTimerEnabled.Location = new System.Drawing.Point(16, 48);
            this.chkBxTimerEnabled.Name = "chkBxTimerEnabled";
            this.chkBxTimerEnabled.Size = new System.Drawing.Size(94, 17);
            this.chkBxTimerEnabled.TabIndex = 7;
            this.chkBxTimerEnabled.Text = "Timer Enabled";
            this.chkBxTimerEnabled.UseVisualStyleBackColor = true;
            this.chkBxTimerEnabled.CheckedChanged += new System.EventHandler(this.chkBxTimerEnabled_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ms";
            // 
            // numUpDnToInterval
            // 
            this.numUpDnToInterval.Location = new System.Drawing.Point(139, 22);
            this.numUpDnToInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDnToInterval.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnToInterval.Name = "numUpDnToInterval";
            this.numUpDnToInterval.Size = new System.Drawing.Size(65, 20);
            this.numUpDnToInterval.TabIndex = 5;
            this.numUpDnToInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numUpDnFromInterval
            // 
            this.numUpDnFromInterval.Location = new System.Drawing.Point(46, 22);
            this.numUpDnFromInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDnFromInterval.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUpDnFromInterval.Name = "numUpDnFromInterval";
            this.numUpDnFromInterval.Size = new System.Drawing.Size(65, 20);
            this.numUpDnFromInterval.TabIndex = 3;
            this.numUpDnFromInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "from";
            // 
            // grpBxValueGen
            // 
            this.grpBxValueGen.Controls.Add(this.numUpDnValTo);
            this.grpBxValueGen.Controls.Add(this.numUpDnValFrom);
            this.grpBxValueGen.Controls.Add(this.label4);
            this.grpBxValueGen.Controls.Add(this.label6);
            this.grpBxValueGen.Location = new System.Drawing.Point(250, 561);
            this.grpBxValueGen.Name = "grpBxValueGen";
            this.grpBxValueGen.Size = new System.Drawing.Size(259, 68);
            this.grpBxValueGen.TabIndex = 2;
            this.grpBxValueGen.TabStop = false;
            this.grpBxValueGen.Text = "Generated Values";
            // 
            // numUpDnValTo
            // 
            this.numUpDnValTo.Location = new System.Drawing.Point(139, 22);
            this.numUpDnValTo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDnValTo.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numUpDnValTo.Name = "numUpDnValTo";
            this.numUpDnValTo.Size = new System.Drawing.Size(65, 20);
            this.numUpDnValTo.TabIndex = 10;
            this.numUpDnValTo.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numUpDnValFrom
            // 
            this.numUpDnValFrom.Location = new System.Drawing.Point(46, 22);
            this.numUpDnValFrom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDnValFrom.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numUpDnValFrom.Name = "numUpDnValFrom";
            this.numUpDnValFrom.Size = new System.Drawing.Size(65, 20);
            this.numUpDnValFrom.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "from";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numUpDnChartOffset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numUpDnChartSize);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numUpDnTimerInterval);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbBxTimerMode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbBxBorder);
            this.groupBox1.Location = new System.Drawing.Point(515, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Engine Properties";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Chart Offset";
            // 
            // numUpDnChartOffset
            // 
            this.numUpDnChartOffset.Location = new System.Drawing.Point(91, 120);
            this.numUpDnChartOffset.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDnChartOffset.Name = "numUpDnChartOffset";
            this.numUpDnChartOffset.Size = new System.Drawing.Size(65, 20);
            this.numUpDnChartOffset.TabIndex = 11;
            this.numUpDnChartOffset.ValueChanged += new System.EventHandler(this.numUpDnChartOffset_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chart Size";
            // 
            // numUpDnChartSize
            // 
            this.numUpDnChartSize.Location = new System.Drawing.Point(91, 94);
            this.numUpDnChartSize.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numUpDnChartSize.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDnChartSize.Name = "numUpDnChartSize";
            this.numUpDnChartSize.Size = new System.Drawing.Size(65, 20);
            this.numUpDnChartSize.TabIndex = 9;
            this.numUpDnChartSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDnChartSize.ValueChanged += new System.EventHandler(this.numUpDnChartSize_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "ms";
            // 
            // numUpDnTimerInterval
            // 
            this.numUpDnTimerInterval.Location = new System.Drawing.Point(91, 68);
            this.numUpDnTimerInterval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUpDnTimerInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUpDnTimerInterval.Name = "numUpDnTimerInterval";
            this.numUpDnTimerInterval.Size = new System.Drawing.Size(65, 20);
            this.numUpDnTimerInterval.TabIndex = 7;
            this.numUpDnTimerInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDnTimerInterval.ValueChanged += new System.EventHandler(this.numUpDnTimerInterval_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "TimerInterval";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "TimerMode";
            // 
            // cmbBxTimerMode
            // 
            this.cmbBxTimerMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxTimerMode.FormattingEnabled = true;
            this.cmbBxTimerMode.Location = new System.Drawing.Point(91, 41);
            this.cmbBxTimerMode.Name = "cmbBxTimerMode";
            this.cmbBxTimerMode.Size = new System.Drawing.Size(162, 21);
            this.cmbBxTimerMode.TabIndex = 4;
            this.cmbBxTimerMode.SelectedIndexChanged += new System.EventHandler(this.cmbBxTimerMode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "BorderStyle";
            // 
            // cmbBxBorder
            // 
            this.cmbBxBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxBorder.FormattingEnabled = true;
            this.cmbBxBorder.Location = new System.Drawing.Point(91, 14);
            this.cmbBxBorder.Name = "cmbBxBorder";
            this.cmbBxBorder.Size = new System.Drawing.Size(162, 21);
            this.cmbBxBorder.TabIndex = 0;
            this.cmbBxBorder.SelectedIndexChanged += new System.EventHandler(this.cmbBxBorder_SelectedIndexChanged);
            // 
            // bgWrkTimer
            // 
            this.bgWrkTimer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWrkTimer_DoWork);
            this.bgWrkTimer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWrkTimer_RunWorkerCompleted);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(788, 526);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(788, 497);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Chart);
            this.tabControl1.Controls.Add(this.Pen1);
            this.tabControl1.Controls.Add(this.Pen2);
            this.tabControl1.Controls.Add(this.Pen3);
            this.tabControl1.Controls.Add(this.Pen4);
            this.tabControl1.Location = new System.Drawing.Point(12, 454);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(232, 175);
            this.tabControl1.TabIndex = 7;
            // 
            // Chart
            // 
            this.Chart.Controls.Add(this.propertyGrid);
            this.Chart.Location = new System.Drawing.Point(4, 22);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(224, 149);
            this.Chart.TabIndex = 4;
            this.Chart.Text = "Chart";
            this.Chart.UseVisualStyleBackColor = true;
            // 
            // propertyGrid
            // 
            this.propertyGrid.CommandsVisibleIfAvailable = false;
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.HelpVisible = false;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGrid.Size = new System.Drawing.Size(224, 149);
            this.propertyGrid.TabIndex = 2;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // Pen1
            // 
            this.Pen1.Controls.Add(this.propGrid1);
            this.Pen1.Location = new System.Drawing.Point(4, 22);
            this.Pen1.Name = "Pen1";
            this.Pen1.Padding = new System.Windows.Forms.Padding(3);
            this.Pen1.Size = new System.Drawing.Size(224, 149);
            this.Pen1.TabIndex = 0;
            this.Pen1.Text = "Pen 1";
            this.Pen1.UseVisualStyleBackColor = true;
            // 
            // propGrid1
            // 
            this.propGrid1.CommandsVisibleIfAvailable = false;
            this.propGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGrid1.HelpVisible = false;
            this.propGrid1.Location = new System.Drawing.Point(3, 3);
            this.propGrid1.Name = "propGrid1";
            this.propGrid1.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propGrid1.Size = new System.Drawing.Size(218, 143);
            this.propGrid1.TabIndex = 1;
            this.propGrid1.ToolbarVisible = false;
            // 
            // Pen2
            // 
            this.Pen2.Controls.Add(this.propGrid2);
            this.Pen2.Location = new System.Drawing.Point(4, 22);
            this.Pen2.Name = "Pen2";
            this.Pen2.Padding = new System.Windows.Forms.Padding(3);
            this.Pen2.Size = new System.Drawing.Size(224, 149);
            this.Pen2.TabIndex = 1;
            this.Pen2.Text = "Pen2";
            this.Pen2.UseVisualStyleBackColor = true;
            // 
            // propGrid2
            // 
            this.propGrid2.CommandsVisibleIfAvailable = false;
            this.propGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGrid2.HelpVisible = false;
            this.propGrid2.Location = new System.Drawing.Point(3, 3);
            this.propGrid2.Name = "propGrid2";
            this.propGrid2.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propGrid2.Size = new System.Drawing.Size(218, 143);
            this.propGrid2.TabIndex = 2;
            this.propGrid2.ToolbarVisible = false;
            // 
            // Pen3
            // 
            this.Pen3.Controls.Add(this.propGrid3);
            this.Pen3.Location = new System.Drawing.Point(4, 22);
            this.Pen3.Name = "Pen3";
            this.Pen3.Padding = new System.Windows.Forms.Padding(3);
            this.Pen3.Size = new System.Drawing.Size(224, 149);
            this.Pen3.TabIndex = 2;
            this.Pen3.Text = "Pen3";
            this.Pen3.UseVisualStyleBackColor = true;
            // 
            // propGrid3
            // 
            this.propGrid3.CommandsVisibleIfAvailable = false;
            this.propGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGrid3.HelpVisible = false;
            this.propGrid3.Location = new System.Drawing.Point(3, 3);
            this.propGrid3.Name = "propGrid3";
            this.propGrid3.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propGrid3.Size = new System.Drawing.Size(218, 143);
            this.propGrid3.TabIndex = 2;
            this.propGrid3.ToolbarVisible = false;
            // 
            // Pen4
            // 
            this.Pen4.Controls.Add(this.propGrid4);
            this.Pen4.Location = new System.Drawing.Point(4, 22);
            this.Pen4.Name = "Pen4";
            this.Pen4.Padding = new System.Windows.Forms.Padding(3);
            this.Pen4.Size = new System.Drawing.Size(224, 149);
            this.Pen4.TabIndex = 3;
            this.Pen4.Text = "Pen4";
            this.Pen4.UseVisualStyleBackColor = true;
            // 
            // propGrid4
            // 
            this.propGrid4.CommandsVisibleIfAvailable = false;
            this.propGrid4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propGrid4.HelpVisible = false;
            this.propGrid4.Location = new System.Drawing.Point(3, 3);
            this.propGrid4.Name = "propGrid4";
            this.propGrid4.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propGrid4.Size = new System.Drawing.Size(218, 143);
            this.propGrid4.TabIndex = 2;
            this.propGrid4.ToolbarVisible = false;
            // 
            // btnCanOn
            // 
            this.btnCanOn.Location = new System.Drawing.Point(1015, 497);
            this.btnCanOn.Name = "btnCanOn";
            this.btnCanOn.Size = new System.Drawing.Size(75, 23);
            this.btnCanOn.TabIndex = 10;
            this.btnCanOn.Text = "Can ON";
            this.btnCanOn.UseVisualStyleBackColor = true;
            this.btnCanOn.Click += new System.EventHandler(this.btnCanOn_Click);
            // 
            // btnCanOFF
            // 
            this.btnCanOFF.Location = new System.Drawing.Point(1015, 526);
            this.btnCanOFF.Name = "btnCanOFF";
            this.btnCanOFF.Size = new System.Drawing.Size(75, 23);
            this.btnCanOFF.TabIndex = 11;
            this.btnCanOFF.Text = "Can OFF";
            this.btnCanOFF.UseVisualStyleBackColor = true;
            this.btnCanOFF.Click += new System.EventHandler(this.btnCanOFF_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainChart);
            this.groupBox2.Location = new System.Drawing.Point(16, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1092, 408);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart";
            // 
            // mainChart
            // 
            this.mainChart.ChartOffset = 0;
            this.mainChart.ChartSize = 5000;
            this.mainChart.ChartStyle.AntiAliasing = false;
            this.mainChart.ChartStyle.BackgroundColorBottom = System.Drawing.Color.DimGray;
            this.mainChart.ChartStyle.BackgroundColorTop = System.Drawing.Color.DimGray;
            chartPen1.Color = System.Drawing.Color.Black;
            chartPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen1.Width = 1F;
            this.mainChart.ChartStyle.HorizontalGridPen = chartPen1;
            this.mainChart.ChartStyle.ShowHorizontalGridLines = false;
            this.mainChart.ChartStyle.ShowVerticalGridLines = false;
            chartPen2.Color = System.Drawing.Color.Black;
            chartPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen2.Width = 1F;
            this.mainChart.ChartStyle.VerticalGridPen = chartPen2;
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainChart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.mainChart.Location = new System.Drawing.Point(3, 16);
            this.mainChart.Name = "mainChart";
            chartPen3.Color = System.Drawing.Color.Black;
            chartPen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen3.Width = 1F;
            penStyle1.ChartLinePen = chartPen3;
            penStyle1.Offset = 0D;
            penStyle1.Scale = 1D;
            penStyle1.ScaleMode = realtimeChart.ScaleMode.Absolute;
            penStyle1.ShowAverageLine = true;
            penStyle1.ShowPen = true;
            chartPen4.Color = System.Drawing.Color.Black;
            chartPen4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen4.Width = 1F;
            penStyle2.ChartLinePen = chartPen4;
            penStyle2.Offset = 0D;
            penStyle2.Scale = 1D;
            penStyle2.ScaleMode = realtimeChart.ScaleMode.Absolute;
            penStyle2.ShowAverageLine = true;
            penStyle2.ShowPen = true;
            chartPen5.Color = System.Drawing.Color.Black;
            chartPen5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen5.Width = 1F;
            penStyle3.ChartLinePen = chartPen5;
            penStyle3.Offset = 0D;
            penStyle3.Scale = 1D;
            penStyle3.ScaleMode = realtimeChart.ScaleMode.Absolute;
            penStyle3.ShowAverageLine = true;
            penStyle3.ShowPen = true;
            chartPen6.Color = System.Drawing.Color.Black;
            chartPen6.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen6.Width = 1F;
            penStyle4.ChartLinePen = chartPen6;
            penStyle4.Offset = 0D;
            penStyle4.Scale = 1D;
            penStyle4.ScaleMode = realtimeChart.ScaleMode.Absolute;
            penStyle4.ShowAverageLine = true;
            penStyle4.ShowPen = true;
            this.mainChart.PenStyles = new realtimeChart.PenStyle[] {
        penStyle1,
        penStyle2,
        penStyle3,
        penStyle4};
            this.mainChart.Size = new System.Drawing.Size(1086, 389);
            this.mainChart.TabIndex = 0;
            this.mainChart.TimerInterval = 100;
            this.mainChart.TimerMode = realtimeChart.TimerMode.Disabled;
            this.mainChart.VisibleValues = 0;
            // 
            // FrmTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCanOFF);
            this.Controls.Add(this.btnCanOn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxValueGen);
            this.Controls.Add(this.grpBxRandVal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTestingForm";
            this.Text = "PerfChart Testing Application";
            this.grpBxRandVal.ResumeLayout(false);
            this.grpBxRandVal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnToInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFromInterval)).EndInit();
            this.grpBxValueGen.ResumeLayout(false);
            this.grpBxValueGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnValTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnValFrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnChartOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnChartSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnTimerInterval)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Chart.ResumeLayout(false);
            this.Pen1.ResumeLayout(false);
            this.Pen2.ResumeLayout(false);
            this.Pen3.ResumeLayout(false);
            this.Pen4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBxRandVal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUpDnToInterval;
        private System.Windows.Forms.NumericUpDown numUpDnFromInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBxValueGen;
        private System.Windows.Forms.NumericUpDown numUpDnValTo;
        private System.Windows.Forms.NumericUpDown numUpDnValFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBxTimerEnabled;
        private System.ComponentModel.BackgroundWorker bgWrkTimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numUpDnTimerInterval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBxTimerMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBxBorder;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pen1;
        private System.Windows.Forms.PropertyGrid propGrid1;
        private System.Windows.Forms.TabPage Pen2;
        private System.Windows.Forms.PropertyGrid propGrid2;
        private System.Windows.Forms.TabPage Pen3;
        private System.Windows.Forms.PropertyGrid propGrid3;
        private System.Windows.Forms.TabPage Pen4;
        private System.Windows.Forms.PropertyGrid propGrid4;
        private System.Windows.Forms.TabPage Chart;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDnChartSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numUpDnChartOffset;
        private System.Windows.Forms.Button btnCanOn;
        private System.Windows.Forms.Button btnCanOFF;
        private System.Windows.Forms.GroupBox groupBox2;
        private realtimeChart.RealtimeChart mainChart;
    }
}