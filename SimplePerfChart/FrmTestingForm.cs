using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using canlibCLSNET;
using System.Diagnostics;
using System.Net;

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

        Thread canThread;
        bool exit_request = false;

        public FrmTestingForm()
        {

            InitializeComponent();

            this.Font = SystemInformation.MenuFont;

            propertyGrid.SelectedObject = mainChart.ChartStyle;

            propGrid1.SelectedObject = mainChart.PenStyles[0];
            propGrid2.SelectedObject = mainChart.PenStyles[1];
            propGrid3.SelectedObject = mainChart.PenStyles[2];
            propGrid4.SelectedObject = mainChart.PenStyles[3];

            // Apply default Properties
            mainChart.TimerInterval = 1000;

            // Populate DrowDown Boxes
            foreach (String item in System.Enum.GetNames(typeof(Border3DStyle)))
            {
                cmbBxBorder.Items.Add(item);
            }
            foreach (String item in System.Enum.GetNames(typeof(realtimeChart.TimerMode)))
            {
                cmbBxTimerMode.Items.Add(item);
            }

            // Select default values
            cmbBxTimerMode.SelectedItem = mainChart.TimerMode.ToString();
            cmbBxBorder.SelectedItem = mainChart.BorderStyle.ToString();

            
        }

        private void canThreadFunct()
        {
            int canHandle;
            Canlib.canStatus status;

            int channel_number = 0;
            int id;
            byte[] msg = new byte[8];
            int dlc;
            int flag;
            long time;
            long timeout;
            int val0 = 0;
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            long count0 = 1;
            long count1 = 2;
            long count2 = 3;
            long count3 = 4;

            Canlib.canInitializeLibrary();
            canHandle = Canlib.canOpenChannel(channel_number, Canlib.canOPEN_NO_INIT_ACCESS);
            CheckStatus((Canlib.canStatus)canHandle, "canOpenChannel");

            // Next, take the channel on bus using the canBusOn method. This
            // needs to be done before we can send a message.
            status = Canlib.canBusOn(canHandle);
            CheckStatus(status, "canBusOn");

            timeout = 1000;

            while (!exit_request)
            {
                status = Canlib.canReadWait(canHandle, out id, msg, out dlc, out flag, out time, timeout );
                CheckStatus(status, "canReadWait");
                if (id == 0x700)
                {
                    val0 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(msg, 0));
                    count0 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(msg, 4));
                }
                if (id == 0x701)
                {
                    val1 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(msg, 0));
                    count1 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(msg, 4));
                }
                if (id == 0x702)
                {
                    val2 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(msg, 0));
                    count2 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(msg, 4));
                }
                if (id == 0x703)
                {
                    val3 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(msg, 0));
                    count3 = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(msg, 4));
                }
                if (count0 == count1 && count0 == count2 && count0 == count3)
                {
                    realtimeChart.DataSample genValue = new realtimeChart.DataSample();
                    genValue.value[0] = val0;
                    genValue.value[1] = val1;
                    genValue.value[2] = val2;
                    genValue.value[3] = val3;
                    mainChart.AddValue(genValue);
                }
            }
            status = Canlib.canBusOff(canHandle);
            CheckStatus(status, "canBusOff");

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
            realtimeChart.DataSample genValue = new realtimeChart.DataSample();
            genValue.value[0] = value;
            value++;
            if (value < valueGenFrom)
                value = valueGenFrom;
            if (value > valueGenTo)
                value = valueGenFrom;

            genValue.value[1] = randGen.Next(valueGenFrom, valueGenTo);
            genValue.value[2] = randGen.Next(valueGenFrom, valueGenTo);
            genValue.value[3] = randGen.Next(valueGenFrom, valueGenTo);

            mainChart.AddValue(genValue);

            //hScrollBar.Maximum = perfChart.
            if (chkBxTimerEnabled.Checked)
            {
                //Simply restart, if still enabled
                RunTimer();
            }
        }

        private void cmbBxBorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainChart.BorderStyle = (Border3DStyle)Enum.Parse(
                typeof(Border3DStyle), cmbBxBorder.SelectedItem.ToString()
            );
        }

        private void cmbBxScaleMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //perfChart.ScaleMode = (SpPerfChart.ScaleMode)Enum.Parse(
            //    typeof(SpPerfChart.ScaleMode), cmbBxScaleMode.SelectedItem.ToString()
            //);
        }

        private void cmbBxTimerMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainChart.TimerMode = (realtimeChart.TimerMode)Enum.Parse(
                typeof(realtimeChart.TimerMode), cmbBxTimerMode.SelectedItem.ToString()
            );
        }

        private void numUpDnTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            mainChart.TimerInterval = Convert.ToInt32(numUpDnTimerInterval.Value);
        }

        private void numUpDnChartSize_ValueChanged(object sender, EventArgs e)
        {
            mainChart.ChartSize = Convert.ToInt32(numUpDnChartSize.Value);
        }

        private void numUpDnChartOffset_ValueChanged(object sender, EventArgs e)
        {
            mainChart.ChartOffset = Convert.ToInt32(numUpDnChartOffset.Value);
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
            mainChart.Clear();
        }


        // The check method takes a canStatus (which is an enumerable) and the method
        // name as a string argument. If the status is an error code, it will print it.
        // Most Canlib method return a status, and checking it with a method like this
        // is a useful practice to avoid code duplication.
        private static void CheckStatus(Canlib.canStatus status, string method)
        {
            if (status < 0)
            {
                string errorText;
                Canlib.canGetErrorText(status, out errorText);
                Debug.WriteLine(method + " failed: " + errorText);
            }
        }

        private void btnCanOFF_Click(object sender, EventArgs e)
        {
            if (canThread != null)
            {
                exit_request = true;
                canThread.Join(2000);
                canThread = null;
            }
        }

        private void btnCanOn_Click(object sender, EventArgs e)
        {
            if (canThread == null)
            {
                exit_request = false;
                canThread = new Thread(canThreadFunct);
                canThread.Start();
            }
        }
    }
}