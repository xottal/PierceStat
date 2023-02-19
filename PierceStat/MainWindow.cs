using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PierceStat
{
    public partial class Form_MainWindow : Form
    {
        public Form_MainWindow()
        {
            InitializeComponent();
            updateCOMPortsToolStripMenuItem_Click(1, null);
            

            PierceStat_Class.MessageHandler messageHandler = new PierceStat_Class.MessageHandler(AddMessage);
            pierceStat = new PierceStat_Class(messageHandler);
            form_Settings = new Form_Settings(pierceStat);

            time = new List<decimal>();
            temperature = new List<List<decimal>>();
            for(int i = 0; i < 5; i++)
            {
                temperature.Add(new List<decimal>());
            }
            frequency = new List<decimal>();
            derivative = new List<decimal>();

            stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Reset();

            timer1.Start();

            chart_Temps.ChartAreas[0].AxisX.Minimum = 0;
            chart_Freq.ChartAreas[0].AxisX.Minimum = 0;

            numericUpDown_U_HeaterMeas.Controls[0].Enabled = false;
            numericUpDown_U_PowerMeas.Controls[0].Enabled = false;

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown
                || e.CloseReason == CloseReason.ApplicationExitCall)
                return;

            if (button_ConnectCOM.Text == "Disconnect")
            {
                button_ConnectCOM_Click(this, new EventArgs());
            }

        }

        private PierceStat_Class pierceStat;
        private Form_Settings form_Settings;
        private List<decimal> time;
        private List<List<decimal>> temperature;
        private List<decimal> frequency;
        private List<decimal> derivative;
        private System.Diagnostics.Stopwatch stopWatch;

        public void AddMessage(string message)
        {
            richTextBox_Messages.AppendText(message + '\n');
            richTextBox_Messages.ScrollToCaret();
        }
        public void AddMessage(object source, MessageArgs e)
        {
            richTextBox_Messages.AppendText($"{e.MessageTime}: {e.MessageSource} \n {e.MessageInfo}\n");
            richTextBox_Messages.ScrollToCaret();

        }

        public void InterfaceEnable(bool bl)
        {
            comboBox_ComPortsList.Enabled = bl;
            groupBox_PierceStat.Enabled = bl;
        }

        public void PullParamaters()
        {
            List<IParameter> parametersToPull = new List<IParameter> { 
                pierceStat.U_HeaterSet,
                pierceStat.U_HeaterMeas,
                pierceStat.U_HeaterMaxAlarm,
                pierceStat.U_HeaterMinAlarm,
                pierceStat.U_HeaterOn,
                pierceStat.U_PowerMeas,
                pierceStat.U_PowerMaxAlarm,
                pierceStat.U_PowerMinAlarm,
                pierceStat.TempMeas[0],
                pierceStat.TempMeas[1],
                pierceStat.TempMeas[2],
                pierceStat.TempMeas[3],
                pierceStat.TempMinAlarm[0],
                pierceStat.TempMinAlarm[1],
                pierceStat.TempMinAlarm[2],
                pierceStat.TempMinAlarm[3],
                pierceStat.TempMaxAlarm[0],
                pierceStat.TempMaxAlarm[1],
                pierceStat.TempMaxAlarm[2],
                pierceStat.TempMaxAlarm[3],
                pierceStat.IMeas[0],
                pierceStat.IMeas[1],
                pierceStat.IMeas[2],
                pierceStat.IMeas[3],
                pierceStat.IMaxAlarm[0],
                pierceStat.IMaxAlarm[1],
                pierceStat.IMaxAlarm[2],
                pierceStat.IMaxAlarm[3],
                pierceStat.Load[0],
                pierceStat.Load[1],
                pierceStat.Mode[0],
                pierceStat.Mode[1],
                pierceStat.ChannelOn[0],
                pierceStat.ChannelOn[1],
                pierceStat.Source[0],
                pierceStat.Source[1],
                pierceStat.PIDTemp[0][0],
                pierceStat.PIDTemp[0][1],
                pierceStat.PIDTemp[0][2],
                pierceStat.PIDTemp[1][0],
                pierceStat.PIDTemp[1][1],
                pierceStat.PIDTemp[1][2],
                pierceStat.PIDFreq[0][0],
                pierceStat.PIDFreq[0][1],
                pierceStat.PIDFreq[0][2],
                pierceStat.PIDFreq[1][0],
                pierceStat.PIDFreq[1][1],
                pierceStat.PIDFreq[1][2],
                pierceStat.TempSet[0],
                pierceStat.TempSet[1],
                pierceStat.CurrentSet[0],
                pierceStat.CurrentSet[1],
                pierceStat.Polarity[0],
                pierceStat.Polarity[1],
                pierceStat.FreqMeas,
                pierceStat.FreqSet };
            StringBuilder command = new StringBuilder();
            foreach(var param in parametersToPull) 
            { 
                command.Append(param.CommandGet); 
            }
            pierceStat.WriteRs(command.ToString());
            command.Clear();

            decimal tempD = pierceStat.U_HeaterSet.ReadFromCOM();
            if (!numericUpDown_U_HeaterSet.Focused)
                numericUpDown_U_HeaterSet.Value = tempD;
            tempD = pierceStat.U_HeaterMeas.ReadFromCOM();
            if (!numericUpDown_U_HeaterMeas.Focused)
                numericUpDown_U_HeaterMeas.Value = tempD;
            tempD = pierceStat.U_HeaterMaxAlarm.ReadFromCOM();
            if (!numericUpDown_U_HeaterMax.Focused)
                numericUpDown_U_HeaterMax.Value = tempD;
            tempD = pierceStat.U_HeaterMinAlarm.ReadFromCOM();
            if (!numericUpDown_U_HeaterMin.Focused)
                numericUpDown_U_HeaterMin.Value = tempD;
            bool tempB = pierceStat.U_HeaterOn.ReadFromCOM();
            if (!checkBox_U_HeaterEnable.Focused)
                checkBox_U_HeaterEnable.Checked = tempB;
            tempD = pierceStat.U_PowerMeas.ReadFromCOM();
            if (!numericUpDown_U_PowerMeas.Focused)
                numericUpDown_U_PowerMeas.Value = tempD;
            tempD = pierceStat.U_PowerMaxAlarm.ReadFromCOM();
            if (!numericUpDown_U_PowerMax.Focused)
                numericUpDown_U_PowerMax.Value = tempD;
            tempD = pierceStat.U_PowerMinAlarm.ReadFromCOM();
            if (!numericUpDown_U_PowerMin.Focused)
                numericUpDown_U_PowerMin.Value = tempD;
            for(int i = 0; i < 4; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_Temp1Meas;
                switch(i)
                {
                    case 0: 
                        numericUpDown = numericUpDown_Temp1Meas;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_Temp2Meas;
                        break;
                    case 2:
                        numericUpDown = numericUpDown_Temp3Meas;
                        break;
                    case 3:
                        numericUpDown = numericUpDown_Temp4Meas;
                        break;
                }
                tempD = pierceStat.TempMeas[i].ReadFromCOM();
                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }
            for (int i = 0; i < 4; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_Temp1Min;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_Temp1Min;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_Temp2Min;
                        break;
                    case 2:
                        numericUpDown = numericUpDown_Temp3Min;
                        break;
                    case 3:
                        numericUpDown = numericUpDown_Temp4Min;
                        break;
                }
                tempD = pierceStat.TempMinAlarm[i].ReadFromCOM();
                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }

            for (int i = 0; i < 4; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_Temp1Max;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_Temp1Max;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_Temp2Max;
                        break;
                    case 2:
                        numericUpDown = numericUpDown_Temp3Max;
                        break;
                    case 3:
                        numericUpDown = numericUpDown_Temp4Max;
                        break;
                }
                tempD = pierceStat.TempMaxAlarm[i].ReadFromCOM();
                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }

            for (int i = 0; i < 2; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_CurrentCh1Meas;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_CurrentCh1Meas;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_CurrentCh2Meas;
                        break;
                }
                decimal tempD1 = pierceStat.IMeas[i*2].ReadFromCOM();
                decimal tempD2 = pierceStat.IMeas[i * 2 + 1].ReadFromCOM();
                decimal current;
                if (tempD1 > tempD2)
                    current = tempD1;
                else 
                    current = -tempD2;
                if (!numericUpDown.Focused)
                    numericUpDown.Value = current;
            }     

            for (int i = 0; i < 2; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_CurrentCh1Max;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_CurrentCh1Max;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_CurrentCh2Max;
                        break;
                }
                tempD = pierceStat.IMaxAlarm[i * 2].ReadFromCOM();
                tempD = pierceStat.IMaxAlarm[i * 2 + 1].ReadFromCOM();

                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }

            for (int i = 0; i < 2; i++)
            {
                System.Windows.Forms.ComboBox comboBox = comboBox_Load1;
                switch (i)
                {
                    case 0:
                        comboBox = comboBox_Load1;
                        break;
                    case 1:
                        comboBox = comboBox_Load2;
                        break;
                }
                tempB = pierceStat.Load[i].ReadFromCOM();

                if (!comboBox.Focused)
                    comboBox.SelectedIndex = tempB ? 1 : 0;
            }

            for (int i = 0; i < 2; i++)
            {
                System.Windows.Forms.ComboBox comboBox = comboBox_Mode1;
                switch (i)
                {
                    case 0:
                        comboBox = comboBox_Mode1;
                        break;
                    case 1:
                        comboBox = comboBox_Mode2;
                        break;
                }
                tempB = pierceStat.Mode[i].ReadFromCOM();

                if (!comboBox.Focused)
                    comboBox.SelectedIndex = tempB ? 1 : 0;
            }

            for (int i = 0; i < 2; i++)
            {
                System.Windows.Forms.Button button = button_EnableCh1;
                switch (i)
                {
                    case 0:
                        button = button_EnableCh1;
                        break;
                    case 1:
                        button = button_EnableCh2;
                        break;
                }
                tempB = pierceStat.ChannelOn[i].ReadFromCOM();

                if (!button.Focused)
                    button.Text = tempB ? "Disable" : "Enable";
            }

            for (int i = 0; i < 2; i++)
            {
                System.Windows.Forms.ComboBox comboBox = comboBox_Source1;
                switch (i)
                {
                    case 0:
                        comboBox = comboBox_Source1;
                        break;
                    case 1:
                        comboBox = comboBox_Source2;
                        break;
                }
                int tempI = pierceStat.Source[i].ReadFromCOM();

                if (!comboBox.Focused)
                    comboBox.SelectedIndex = tempI;
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    NumericUpDown numericUpDown = numericUpDown_PTemp1;
                    switch (i)
                    {
                        case 0:
                            switch (j)
                            {
                                case 0:
                                    numericUpDown = numericUpDown_PTemp1;
                                    break;
                                case 1:
                                    numericUpDown = numericUpDown_ITemp1;
                                    break;
                                case 2:
                                    numericUpDown = numericUpDown_DTemp1;
                                    break;
                            }
                            break;
                        case 1:
                            switch (j)
                            {
                                case 0:
                                    numericUpDown = numericUpDown_PTemp2;
                                    break;
                                case 1:
                                    numericUpDown = numericUpDown_ITemp2;
                                    break;
                                case 2:
                                    numericUpDown = numericUpDown_DTemp2;
                                    break;
                            }
                            break;
                    }
                    tempD = pierceStat.PIDTemp[i][j].ReadFromCOM();
                    if (!numericUpDown.Focused)
                        numericUpDown.Value = tempD;
                }        
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    NumericUpDown numericUpDown = numericUpDown_PFreq1;
                    switch (i)
                    {
                        case 0:
                            switch (j)
                            {
                                case 0:
                                    numericUpDown = numericUpDown_PFreq1;
                                    break;
                                case 1:
                                    numericUpDown = numericUpDown_IFreq1;
                                    break;
                                case 2:
                                    numericUpDown = numericUpDown_DFreq1;
                                    break;
                            }
                            break;
                        case 1:
                            switch (j)
                            {
                                case 0:
                                    numericUpDown = numericUpDown_PFreq2;
                                    break;
                                case 1:
                                    numericUpDown = numericUpDown_IFreq2;
                                    break;
                                case 2:
                                    numericUpDown = numericUpDown_DFreq2;
                                    break;
                            }
                            break;
                    }
                    tempD = pierceStat.PIDFreq[i][j].ReadFromCOM();
                    if (!numericUpDown.Focused)
                        numericUpDown.Value = tempD;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_SetPointTemp1;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_SetPointTemp1;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_SetPointTemp2;
                        break;
                }
                tempD = pierceStat.TempSet[i].ReadFromCOM();

                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }
            for (int i = 0; i < 2; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_ISet1;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_ISet1;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_ISet2;
                        break;
                }
                tempD = pierceStat.CurrentSet[i].ReadFromCOM();

                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }
            for (int i = 0; i < 2; i++)
            {
                CheckBox checkBox = checkBox_Polarity1;
                switch (i)
                {
                    case 0:
                        checkBox = checkBox_Polarity1;
                        break;
                    case 1:
                        checkBox = checkBox_Polarity2;
                        break;
                }
                tempB = pierceStat.Polarity[i].ReadFromCOM();

                if (!checkBox.Focused)
                    checkBox.Checked = tempB;
            }

            tempD = pierceStat.FreqMeas.ReadFromCOM();
            try
            {
                if (!numericUpDown_SetPointFreq1.Focused)
                    numericUpDown_FreqMeas.Value = tempD;
            }
            catch
            {
                //AddMessage("Incorrect frequency");
            }

            tempD = pierceStat.FreqSet.ReadFromCOM();
            if (!numericUpDown_SetPointFreq1.Focused)
                numericUpDown_SetPointFreq1.Value = tempD;
            if (!numericUpDown_SetPointFreq2.Focused)
                numericUpDown_SetPointFreq2.Value = tempD;
            
        }

        public void UpdatePlot()
        {
            if (time.Count == 0)
            {
                stopWatch.Start();
                time.Add(0m);
            }
            else
            {
                time.Add((decimal)(stopWatch.ElapsedMilliseconds) / 1000.0m);
            }
                
            for (int i = 0; i < 4; i++)
            {
                temperature[i].Add(pierceStat.TempMeas[i].Value);
                chart_Temps.Series[i].Points.AddXY(time.Last(), temperature[i].Last());
            }
            chart_Temps.Series[0].Enabled = checkBox_PlotTemp1.Checked;
            chart_Temps.Series[1].Enabled = checkBox_PlotTemp2.Checked;
            chart_Temps.Series[2].Enabled = checkBox_PlotTemp3.Checked;
            chart_Temps.Series[3].Enabled = checkBox_PlotTemp4.Checked;
            frequency.Add(pierceStat.FreqMeas.Value);
            chart_Freq.Series[0].Points.AddXY(time.Last(), frequency.Last());
            int numPointsDeriv = (int)numericUpDown_DerNumber.Value;
            if (time.Count > (numPointsDeriv - 1)) {
                derivative.Add(Math.LeastSquared(time.GetRange(time.Count - numPointsDeriv, numPointsDeriv), 
                    frequency.GetRange(frequency.Count - numPointsDeriv, numPointsDeriv)).deriv);

                chart_Freq.Series[1].Points.AddXY(time.Last(), derivative.Last());
            }
        }

        public void ResetPlot()
        {
            for (int i = 0; i < 5; i++)
            {
                chart_Temps.Series[i].Points.Clear();
                temperature[i].Clear();
            }
            chart_Freq.Series[0].Points.Clear();
            chart_Freq.Series[1].Points.Clear();
            time.Clear();
            frequency.Clear();
            derivative.Clear();
            stopWatch.Reset();
        }

        private void button_ConnectCOM_Click(object sender, EventArgs e)
        {
            switch (button_ConnectCOM.Text)
            {
                case "Connect":
                    try
                    {
                        if (comboBox_ComPortsList.SelectedItem.ToString() == null)
                            return;
                    }
                    catch (System.NullReferenceException)
                    {
                        return;
                    }
                    bool bl = pierceStat.Connect(comboBox_ComPortsList.SelectedItem.ToString());
                    if (bl)
                    {
                        button_ConnectCOM.Text = "Disconnect";
                        InterfaceEnable(true);
                        while (button_ConnectCOM.Text == "Disconnect")
                        {
                            
                            Window_Activated(this, new EventArgs());
                            Application.DoEvents();
                        }

                    }
                    break;
                case "Disconnect":
                    //if (button_monitoring.Text == "Stop monitoring")
                    //Button_monitoring_Click(1, System.EventArgs.Empty);
                    bl = pierceStat.Disconnect();
                    if (bl)
                    {
                        button_ConnectCOM.Text = "Connect";

                        InterfaceEnable(false);
                    }
                    break;
                default:
                    return;
            }
        }

        private void updateCOMPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox_ComPortsList.Items.Clear();
            comboBox_ComPortsList.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            comboBox_ComPortsList.SelectedIndex = comboBox_ComPortsList.Items.Count - 1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle(0, 0, pictureBox_AlarmCurrentCh1.ClientSize.Width - 1, pictureBox_AlarmCurrentCh1.ClientSize.Height - 1);
            System.Drawing.Color color = (System.Drawing.Color.Green);
            using (System.Drawing.Brush brush = new SolidBrush(color))
            {
                e.Graphics.FillEllipse(brush, rect);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            form_Settings.Show();
        }

        private void comboBox_Source1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Source1.Enabled)
            {
                if (comboBox_Source1.SelectedIndex == 4)
                {
                    groupBox_Freq1.Enabled = true;
                    groupBox_Temp1.Enabled = false;
                }
                else
                {
                    groupBox_Freq1.Enabled = false;
                    groupBox_Temp1.Enabled = true;
                }
            }
            //Changed from GUI
            if (comboBox_Source1.Focused)
            {
                pierceStat.Source[0].Value = comboBox_Source1.SelectedIndex;
            }
        }

        private void comboBox_Mode1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Mode1.SelectedIndex == 0)
            {
                numericUpDown_ISet1.Enabled = false;
                comboBox_Source1.Enabled = true;
            }
            else
            {
                numericUpDown_ISet1.Enabled = true;
                comboBox_Source1.Enabled = false;
            }
            //Changed from GUI
            if (comboBox_Mode1.Focused)
            {
                pierceStat.Mode[0].Value = (comboBox_Mode1.SelectedIndex == 0) ? false : true;
            }
        }

        private void comboBox_Mode2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Mode2.SelectedIndex == 0)
            {
                numericUpDown_ISet2.Enabled = false;
                comboBox_Source2.Enabled = true;
            }
            else
            {
                numericUpDown_ISet2.Enabled = true;
                comboBox_Source2.Enabled = false;
            }
            //Changed from GUI
            if (comboBox_Mode2.Focused)
            {
                pierceStat.Mode[1].Value = (comboBox_Mode2.SelectedIndex == 0) ? false : true;
            }
        }

        private void comboBox_Source2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Source2.Enabled)
            {
                if (comboBox_Source2.SelectedIndex == 4)
                {
                    groupBox_Freq2.Enabled = true;
                    groupBox_Temp2.Enabled = false;
                }
                else
                {
                    groupBox_Freq2.Enabled = false;
                    groupBox_Temp2.Enabled = true;
                }
            }
            //Changed from GUI
            if (comboBox_Source2.Focused)
            {
                pierceStat.Source[1].Value = comboBox_Source2.SelectedIndex;
            }
        }

        private void comboBox_Source1_EnabledChanged(object sender, EventArgs e)
        {
            if (comboBox_Source1.Enabled)
            {
                if (comboBox_Source1.SelectedIndex == 4)
                {
                    groupBox_Freq1.Enabled = true;
                    groupBox_Temp1.Enabled = false;
                }
                else
                {
                    groupBox_Freq1.Enabled = false;
                    groupBox_Temp1.Enabled = true;
                }
            }
            else
            {
                groupBox_Freq1.Enabled = false;
                groupBox_Temp1.Enabled = false;
            }
            //Changed from GUI
            if (comboBox_Source1.Focused)
            {

            }
        }

        private void comboBox_Source2_EnabledChanged(object sender, EventArgs e)
        {
            if (comboBox_Source2.Enabled)
            {
                if (comboBox_Source2.SelectedIndex == 4)
                {
                    groupBox_Freq2.Enabled = true;
                    groupBox_Temp2.Enabled = false;
                }
                else
                {
                    groupBox_Freq2.Enabled = false;
                    groupBox_Temp2.Enabled = true;
                }
            }
            else
            {
                groupBox_Freq2.Enabled = false;
                groupBox_Temp2.Enabled = false;
            }
            //Changed from GUI
            if (comboBox_Source2.Focused)
            {

            }
        }

        private void button_EnableCh1_Click(object sender, EventArgs e)
        {
            //Changed from GUI
            if (button_EnableCh1.Focused)
            {
                pierceStat.ChannelOn[0].Value = (button_EnableCh1.Text == "Enable") ? true : false;
                button_EnableCh1.Text = (button_EnableCh1.Text == "Enable") ? "Disable" : "Enable";
            }
        }

        private void button_EnableCh2_Click(object sender, EventArgs e)
        {
            //Changed from GUI
            if (button_EnableCh2.Focused)
            {
                pierceStat.ChannelOn[1].Value = (button_EnableCh2.Text == "Enable") ? true : false;
                button_EnableCh2.Text = (button_EnableCh2.Text == "Enable") ? "Disable" : "Enable";
            }
        }

        private void radioButton_ModeDependent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ModeDependent.Checked)
            {
                groupBox_Channel2.Enabled = false;
            }
            else
            {
                groupBox_Channel2.Enabled = true;
            }
            //Changed from GUI
            if (radioButton_ModeDependent.Focused)
            {

            }
        }

        private void numericUpDown_U_HeaterSet_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_U_HeaterSet.Focused)
            {
                pierceStat.U_HeaterSet.Value = numericUpDown_U_HeaterSet.Value;
            }
        }
        void Window_Activated(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void checkBox_U_HeaterEnable_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_U_HeaterEnable.Focused)
            {
                pierceStat.U_HeaterOn.Value = checkBox_U_HeaterEnable.Checked;
            }
        }

        private void comboBox_Load1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (comboBox_Load1.Focused)
            {
                pierceStat.Load[0].Value = (comboBox_Load1.SelectedIndex == 0) ? false : true;
            }
        }

        private void comboBox_Load2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (comboBox_Load2.Focused)
            {
                pierceStat.Load[1].Value = (comboBox_Load2.SelectedIndex == 0) ? false : true;
            }
        }

        private void checkBox_Polarity1_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_Polarity1.Focused)
            {
                pierceStat.Polarity[0].Value = checkBox_Polarity1.Checked;
            }
        }

        private void checkBox_Polarity2_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_Polarity2.Focused)
            {
                pierceStat.Polarity[1].Value = checkBox_Polarity2.Checked;
            }
        }

        private void numericUpDown_ISet1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_ISet1.Focused)
            {
                pierceStat.CurrentSet[0].Value = numericUpDown_ISet1.Value;
            }
        }

        private void numericUpDown_ISet2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_ISet2.Focused)
            {
                pierceStat.CurrentSet[1].Value = numericUpDown_ISet2.Value;
            }
        }

        private void numericUpDown_SetPointTemp1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_SetPointTemp1.Focused)
            {
                pierceStat.TempSet[0].Value = numericUpDown_SetPointTemp1.Value;
            }
        }

        private void numericUpDown_SetPointTemp2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_SetPointTemp2.Focused)
            {
                pierceStat.TempSet[1].Value = numericUpDown_SetPointTemp2.Value;
            }
        }

        private void numericUpDown_SetPointFreq1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_SetPointFreq1.Focused)
            {
                pierceStat.FreqSet.Value = numericUpDown_SetPointFreq1.Value;
            }
        }

        private void numericUpDown_SetPointFreq2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_SetPointFreq2.Focused)
            {
                pierceStat.FreqSet.Value = numericUpDown_SetPointFreq2.Value;
            }
        }

        private void numericUpDown_PTemp1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_PTemp1.Focused)
            {
                pierceStat.PIDTemp[0][0].Value = numericUpDown_PTemp1.Value;
            }
        }

        private void numericUpDown_ITemp1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_ITemp1.Focused)
            {
                pierceStat.PIDTemp[0][1].Value = numericUpDown_ITemp1.Value;
            }
        }

        private void numericUpDown_DTemp1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_DTemp1.Focused)
            {
                pierceStat.PIDTemp[0][2].Value = numericUpDown_DTemp1.Value;
            }
        }

        private void numericUpDown_PFreq1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_PFreq1.Focused)
            {
                pierceStat.PIDFreq[0][0].Value = numericUpDown_PFreq1.Value;
            }
        }

        private void numericUpDown_IFreq1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_IFreq1.Focused)
            {
                pierceStat.PIDFreq[0][1].Value = numericUpDown_IFreq1.Value;
            }
        }

        private void numericUpDown_DFreq1_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_DFreq1.Focused)
            {
                pierceStat.PIDFreq[0][2].Value = numericUpDown_DFreq1.Value;
            }
        }

        private void numericUpDown_PTemp2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_PTemp2.Focused)
            {
                pierceStat.PIDTemp[1][0].Value = numericUpDown_PTemp2.Value;
            }
        }

        private void numericUpDown_ITemp2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_ITemp2.Focused)
            {
                pierceStat.PIDTemp[1][1].Value = numericUpDown_ITemp2.Value;
            }
        }

        private void numericUpDown_DTemp2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_DTemp2.Focused)
            {
                pierceStat.PIDTemp[1][2].Value = numericUpDown_DTemp2.Value;
            }
        }

        private void numericUpDown_PFreq2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_PFreq2.Focused)
            {
                pierceStat.PIDFreq[1][0].Value = numericUpDown_PFreq2.Value;
            }
        }

        private void numericUpDown_IFreq2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_IFreq2.Focused)
            {
                pierceStat.PIDFreq[1][1].Value = numericUpDown_IFreq2.Value;
            }
        }

        private void numericUpDown_DFreq2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_DFreq2.Focused)
            {
                pierceStat.PIDFreq[1][2].Value = numericUpDown_DFreq2.Value;
            }
        }

        private void numericUpDown_U_PowerMin_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_U_PowerMin.Focused)
            {
                pierceStat.U_PowerMinAlarm.Value = numericUpDown_U_PowerMin.Value;
            }
        }

        private void numericUpDown_U_PowerMax_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_U_PowerMax.Focused)
            {
                pierceStat.U_PowerMaxAlarm.Value = numericUpDown_U_PowerMax.Value;
            }
        }

        private void numericUpDown_U_HeaterMin_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_U_HeaterMin.Focused)
            {
                pierceStat.U_HeaterMinAlarm.Value = numericUpDown_U_HeaterMin.Value;
            }
        }

        private void numericUpDown_U_HeaterMax_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_U_HeaterMax.Focused)
            {
                pierceStat.U_HeaterMaxAlarm.Value = numericUpDown_U_HeaterMax.Value;
            }
        }

        private void numericUpDown_Temp1Min_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_Temp1Min.Focused)
            {
                pierceStat.TempMinAlarm[0].Value = numericUpDown_Temp1Min.Value;
            }
        }

        private void numericUpDown_Temp2Min_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_Temp2Min.Focused)
            {
                pierceStat.TempMinAlarm[1].Value = numericUpDown_Temp2Min.Value;
            }
        }

        private void numericUpDown_Temp3Min_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_Temp3Min.Focused)
            {
                pierceStat.TempMinAlarm[2].Value = numericUpDown_Temp3Min.Value;
            }
        }

        private void numericUpDown_Temp4Min_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_Temp4Min.Focused)
            {
                pierceStat.TempMinAlarm[3].Value = numericUpDown_Temp4Min.Value;
            }
        }

        private void numericUpDown_Temp1Max_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_Temp1Max.Focused)
            {
                pierceStat.TempMaxAlarm[0].Value = numericUpDown_Temp1Max.Value;
            }
        }

        private void numericUpDown_Temp2Max_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_Temp2Max.Focused)
            {
                pierceStat.TempMaxAlarm[1].Value = numericUpDown_Temp2Max.Value;
            }
        }

        private void numericUpDown_Temp3Max_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_Temp3Max.Focused)
            {
                pierceStat.TempMaxAlarm[2].Value = numericUpDown_Temp3Max.Value;
            }
        }

        private void numericUpDown_Temp4Max_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_Temp4Max.Focused)
            {
                pierceStat.TempMaxAlarm[3].Value = numericUpDown_Temp4Max.Value;
            }
        }

        private void numericUpDown_FreqMin_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_FreqMax.Focused)
            {

            }
        }

        private void button_ResetPlots_Click(object sender, EventArgs e)
        {
            ResetPlot();
        }

        private void numericUpDown_TimeInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown_TimeInterval.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Tick -= timer1_Tick;
            if (button_ConnectCOM.Text == "Disconnect")
            {
                PullParamaters();
                if(form_Settings.Visible)
                    form_Settings.PullParamaters();
                Application.DoEvents();
                UpdatePlot();
                
                
            }
            timer1.Tick += timer1_Tick;
        }

        private void button_SaveFlash_Click(object sender, EventArgs e)
        {
            pierceStat.SaveFlash.DoCommand();
        }
    }    
}
