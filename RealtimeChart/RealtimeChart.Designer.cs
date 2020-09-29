namespace realtimeChart
{
    partial class RealtimeChart
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.mainChart = new realtimeChart.ChartArea();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 433);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(800, 17);
            this.hScrollBar1.TabIndex = 0;
            // 
            // mainChart
            // 
            this.mainChart.ChartOffset = 0;
            this.mainChart.ChartSize = 5000;
            this.mainChart.ChartStyle.AntiAliasing = false;
            this.mainChart.ChartStyle.BackgroundColorBottom = System.Drawing.Color.DarkGreen;
            this.mainChart.ChartStyle.BackgroundColorTop = System.Drawing.Color.DarkGreen;
            chartPen1.Color = System.Drawing.Color.Black;
            chartPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen1.Width = 1F;
            this.mainChart.ChartStyle.HorizontalGridPen = chartPen1;
            this.mainChart.ChartStyle.ShowHorizontalGridLines = true;
            this.mainChart.ChartStyle.ShowVerticalGridLines = true;
            chartPen2.Color = System.Drawing.Color.Black;
            chartPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen2.Width = 1F;
            this.mainChart.ChartStyle.VerticalGridPen = chartPen2;
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainChart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.mainChart.Location = new System.Drawing.Point(0, 0);
            this.mainChart.Name = "mainChart";
            chartPen3.Color = System.Drawing.Color.Red;
            chartPen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen3.Width = 1F;
            penStyle1.ChartLinePen = chartPen3;
            penStyle1.Offset = 0D;
            penStyle1.Scale = 1D;
            penStyle1.ScaleMode = realtimeChart.ScaleMode.Absolute;
            penStyle1.ShowAverageLine = true;
            penStyle1.ShowPen = true;
            chartPen4.Color = System.Drawing.Color.LimeGreen;
            chartPen4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen4.Width = 1F;
            penStyle2.ChartLinePen = chartPen4;
            penStyle2.Offset = 0D;
            penStyle2.Scale = 1D;
            penStyle2.ScaleMode = realtimeChart.ScaleMode.Absolute;
            penStyle2.ShowAverageLine = true;
            penStyle2.ShowPen = true;
            chartPen5.Color = System.Drawing.Color.Blue;
            chartPen5.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen5.Width = 1F;
            penStyle3.ChartLinePen = chartPen5;
            penStyle3.Offset = 0D;
            penStyle3.Scale = 1D;
            penStyle3.ScaleMode = realtimeChart.ScaleMode.Absolute;
            penStyle3.ShowAverageLine = true;
            penStyle3.ShowPen = true;
            chartPen6.Color = System.Drawing.Color.Yellow;
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
            this.mainChart.Size = new System.Drawing.Size(800, 433);
            this.mainChart.TabIndex = 1;
            this.mainChart.TimerInterval = 100;
            this.mainChart.TimerMode = realtimeChart.TimerMode.Disabled;
            this.mainChart.VisibleValues = 0;
            // 
            // RealtimeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "RealtimeChart";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private ChartArea mainChart;
    }
}
