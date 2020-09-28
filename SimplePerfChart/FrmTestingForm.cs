using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SimplePerfChart
{
    public partial class FrmTestingForm : Form
    {
        private object valueGenSync = new object();
        private Random randGen = new Random();

        private int valueGenFrom = 0;
        private int valueGenTo = 1000;
        private int valueGenTimerFrom = 100;
        private int valueGenTimerTo = 1000;

        private int value = 0;

        public FrmTestingForm()
        {
            InitializeComponent();

            this.Font = SystemInformation.MenuFont;

            propertyGrid.SelectedObject = perfChart.PerfChartStyle;

            propGrid1.SelectedObject = perfChart.PerfChartPenStyles[0];
            propGrid2.SelectedObject = perfChart.PerfChartPenStyles[1];
            propGrid3.SelectedObject = perfChart.PerfChartPenStyles[2];
            propGrid4.SelectedObject = perfChart.PerfChartPenStyles[3];

            // Apply default Properties
            perfChart.TimerInterval = 1000;

            // Populate DrowDown Boxes
            foreach (String item in System.Enum.GetNames(typeof(Border3DStyle)))
            {
                cmbBxBorder.Items.Add(item);
            }
            foreach (String item in System.Enum.GetNames(typeof(SpPerfChart.ScaleMode)))
            {
                cmbBxScaleMode.Items.Add(item);
            }
            foreach (String item in System.Enum.GetNames(typeof(SpPerfChart.TimerMode)))
            {
                cmbBxTimerMode.Items.Add(item);
            }

            // Select default values
            cmbBxTimerMode.SelectedItem = perfChart.TimerMode.ToString();
            cmbBxScaleMode.SelectedItem = perfChart.ScaleMode.ToString();
            cmbBxBorder.SelectedItem = perfChart.BorderStyle.ToString();
        }



        private void chkBxTimerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxTimerEnabled.Checked && !bgWrkTimer.IsBusy)
            {
                RunTimer();
            }
        }

        private void RunTimer()
        {
            int waitFor = randGen.Next(valueGenTimerFrom, valueGenTimerTo);
            bgWrkTimer.RunWorkerAsync(waitFor);
        }

        private void bgWrkTimer_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(Convert.ToInt32(e.Argument));
        }

        private void bgWrkTimer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SpPerfChart.DataSample genValue = new SpPerfChart.DataSample();
            genValue.value[0] = value;
            value++;
            if (value < valueGenFrom)
                value = valueGenFrom;
            if (value > valueGenTo)
                value = valueGenFrom;

            genValue.value[1] = randGen.Next(valueGenFrom, valueGenTo);
            genValue.value[2] = randGen.Next(valueGenFrom, valueGenTo);
            genValue.value[3] = randGen.Next(valueGenFrom, valueGenTo);

            perfChart.AddValue(genValue);

            hScrollBar.Maximum = perfChart.
            if (chkBxTimerEnabled.Checked)
            {
                //Simply restart, if still enabled
                RunTimer();
            }
        }

        private void cmbBxBorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            perfChart.BorderStyle = (Border3DStyle)Enum.Parse(
                typeof(Border3DStyle), cmbBxBorder.SelectedItem.ToString()
            );
        }

        private void cmbBxScaleMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            perfChart.ScaleMode = (SpPerfChart.ScaleMode)Enum.Parse(
                typeof(SpPerfChart.ScaleMode), cmbBxScaleMode.SelectedItem.ToString()
            );
        }

        private void cmbBxTimerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            perfChart.TimerMode = (SpPerfChart.TimerMode)Enum.Parse(
                typeof(SpPerfChart.TimerMode), cmbBxTimerMode.SelectedItem.ToString()
            );
        }

        private void numUpDnTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            perfChart.TimerInterval = Convert.ToInt32(numUpDnTimerInterval.Value);
        }

        private void numUpDnChartSize_ValueChanged(object sender, EventArgs e)
        {
            perfChart.ChartSize = Convert.ToInt32(numUpDnChartSize.Value);
        }

        private void numUpDnChartOffset_ValueChanged(object sender, EventArgs e)
        {
            perfChart.ChartOffset = Convert.ToInt32(numUpDnChartOffset.Value);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            valueGenFrom = Convert.ToInt32(numUpDnValFrom.Value);
            valueGenTo = Convert.ToInt32(numUpDnValTo.Value);
            if (valueGenTo < valueGenFrom)
            {
                valueGenTo = valueGenFrom;
                numUpDnValTo.Value = valueGenTo;
            }

            valueGenTimerFrom = Convert.ToInt32(numUpDnFromInterval.Value);
            valueGenTimerTo = Convert.ToInt32(numUpDnToInterval.Value);
            if (valueGenTimerTo < valueGenTimerFrom)
            {
                valueGenTimerTo = valueGenTimerFrom;
                numUpDnToInterval.Value = valueGenTimerTo;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            perfChart.Clear();
        }

    }
}