using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PierceStat
{
    public partial class Form_MainWindow : Form
    {
        public Form_MainWindow()
        {
            InitializeComponent();
            updateCOMPortsToolStripMenuItem_Click(1, null);
            InterfaceEnable(false);

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

            stopWatch = new System.Diagnostics.Stopwatch(); //Clock for plots
            stopWatch.Reset();

            timer1.Start(); //Timer for UART messages (configuration in MainWindow Form)

            chart_Temps.ChartAreas[0].AxisX.Minimum = 0;
            chart_Freq.ChartAreas[0].AxisX.Minimum = 0;

            numericUpDown_U_HeaterMeas.Controls[0].Enabled = false;
            numericUpDown_U_PowerMeas.Controls[0].Enabled = false;
            numericUpDown_CurrentCh1Meas.Controls[0].Enabled = false;
            numericUpDown_CurrentCh2Meas.Controls[0].Enabled = false;
            numericUpDown_FreqMeas.Controls[0].Enabled = false;
            numericUpDown_FreqMeas2.Controls[0].Enabled = false;
            numericUpDown_Temp1Meas.Controls[0].Enabled = false;
            numericUpDown_Temp2Meas.Controls[0].Enabled = false;
            numericUpDown_Temp3Meas.Controls[0].Enabled = false;
            numericUpDown_Temp4Meas.Controls[0].Enabled = false;

            kprt = numericUpDown_KprtValue.Value;
            offset = numericUpDown_freqOffset.Value;
            bandwidth = numericUpDown_FilterBand.Value;
            deltaF = numericUpDown_DeltaF.Value;
            awaitTime = numericUpDown_AwaitTime.Value;
            modeDependent = radioButton_ModeDependent.Checked;

            ToolTip toolTip = new ToolTip();



            toolTip.SetToolTip(numericUpDown_U_HeaterSet, pierceStat.U_HeaterSet.Description);
            toolTip.SetToolTip(numericUpDown_U_HeaterMeas, pierceStat.U_HeaterMeas.Description);
            toolTip.SetToolTip(numericUpDown_U_HeaterMax, pierceStat.U_HeaterMaxAlarm.Description);
            toolTip.SetToolTip(numericUpDown_U_HeaterMin, pierceStat.U_HeaterMinAlarm.Description);
            toolTip.SetToolTip(checkBox_U_HeaterEnable, pierceStat.U_HeaterOn.Description);
            toolTip.SetToolTip(numericUpDown_U_PowerMeas, pierceStat.U_PowerMeas.Description);
            toolTip.SetToolTip(numericUpDown_U_PowerMax, pierceStat.U_PowerMaxAlarm.Description);
            toolTip.SetToolTip(numericUpDown_U_PowerMin, pierceStat.U_PowerMinAlarm.Description);

            toolTip.SetToolTip(numericUpDown_Temp1Meas, pierceStat.TempMeas[0].Description);
            toolTip.SetToolTip(numericUpDown_Temp2Meas, pierceStat.TempMeas[1].Description);
            toolTip.SetToolTip(numericUpDown_Temp3Meas, pierceStat.TempMeas[2].Description);
            toolTip.SetToolTip(numericUpDown_Temp4Meas, pierceStat.TempMeas[3].Description);
            toolTip.SetToolTip(numericUpDown_Temp1Min, pierceStat.TempMinAlarm[0].Description);
            toolTip.SetToolTip(numericUpDown_Temp2Min, pierceStat.TempMinAlarm[1].Description);
            toolTip.SetToolTip(numericUpDown_Temp3Min, pierceStat.TempMinAlarm[2].Description);
            toolTip.SetToolTip(numericUpDown_Temp4Min, pierceStat.TempMinAlarm[3].Description);
            toolTip.SetToolTip(numericUpDown_Temp1Max, pierceStat.TempMaxAlarm[0].Description);
            toolTip.SetToolTip(numericUpDown_Temp2Max, pierceStat.TempMaxAlarm[1].Description);
            toolTip.SetToolTip(numericUpDown_Temp3Max, pierceStat.TempMaxAlarm[2].Description);
            toolTip.SetToolTip(numericUpDown_Temp4Max, pierceStat.TempMaxAlarm[3].Description);

            toolTip.SetToolTip(numericUpDown_CurrentCh1Meas, "Signed current of Channel 1");
            toolTip.SetToolTip(numericUpDown_CurrentCh2Meas, "Signed current of Channel 2");
            toolTip.SetToolTip(numericUpDown_CurrentCh1Max, "Max current of Channel 1 (abs)");
            toolTip.SetToolTip(numericUpDown_CurrentCh2Max, "Max current of Channel 2 (abs)");

            toolTip.SetToolTip(comboBox_Load1, pierceStat.Load[0].Description);
            toolTip.SetToolTip(comboBox_Load2, pierceStat.Load[1].Description);
            toolTip.SetToolTip(button_EnableCh1, pierceStat.ChannelOn[0].Description);
            toolTip.SetToolTip(button_EnableCh2, pierceStat.ChannelOn[1].Description);
            toolTip.SetToolTip(comboBox_Source1, pierceStat.Source[0].Description);
            toolTip.SetToolTip(comboBox_Source2, pierceStat.Source[1].Description);

            toolTip.SetToolTip(numericUpDown_PTemp1, pierceStat.PIDTemp[0][0].Description);
            toolTip.SetToolTip(numericUpDown_ITemp1, pierceStat.PIDTemp[0][1].Description);
            toolTip.SetToolTip(numericUpDown_DTemp1, pierceStat.PIDTemp[0][2].Description);
            toolTip.SetToolTip(numericUpDown_PTemp2, pierceStat.PIDTemp[1][0].Description);
            toolTip.SetToolTip(numericUpDown_ITemp2, pierceStat.PIDTemp[1][1].Description);
            toolTip.SetToolTip(numericUpDown_DTemp2, pierceStat.PIDTemp[1][2].Description);

            toolTip.SetToolTip(numericUpDown_PFreq1, pierceStat.PIDFreq[0][0].Description);
            toolTip.SetToolTip(numericUpDown_IFreq1, pierceStat.PIDFreq[0][1].Description);
            toolTip.SetToolTip(numericUpDown_DFreq1, pierceStat.PIDFreq[0][2].Description);
            toolTip.SetToolTip(numericUpDown_PFreq2, pierceStat.PIDFreq[1][0].Description);
            toolTip.SetToolTip(numericUpDown_IFreq2, pierceStat.PIDFreq[1][1].Description);
            toolTip.SetToolTip(numericUpDown_DFreq2, pierceStat.PIDFreq[1][2].Description);

            toolTip.SetToolTip(numericUpDown_SetPointTemp1, pierceStat.TempSet[0].Description);
            toolTip.SetToolTip(numericUpDown_SetPointTemp2, pierceStat.TempSet[1].Description);
            toolTip.SetToolTip(numericUpDown_ISet1, pierceStat.CurrentSet[0].Description);
            toolTip.SetToolTip(numericUpDown_ISet2, pierceStat.CurrentSet[1].Description);

            toolTip.SetToolTip(checkBox_Polarity1, pierceStat.Polarity[0].Description);
            toolTip.SetToolTip(checkBox_Polarity2, pierceStat.Polarity[1].Description);

            toolTip.SetToolTip(numericUpDown_FreqMeas, pierceStat.FreqMeas.Description);
            toolTip.SetToolTip(numericUpDown_FreqMeas2, pierceStat.FreqMeas.Description);
            toolTip.SetToolTip(numericUpDown_SetPointFreq1, pierceStat.FreqSet.Description);
            toolTip.SetToolTip(numericUpDown_SetPointFreq2, pierceStat.FreqSet.Description);

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

        private Decimal kprt;
        private Decimal offset;
        private Decimal bandwidth;
        private Decimal deltaF;
        private Decimal awaitTime;
        private bool modeDependent;

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
            button_AddData.Enabled = bl;
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
                pierceStat.FreqSet,
                pierceStat.FreqMin,
                pierceStat.FreqMax,
                pierceStat.Alarms,
                pierceStat.AlarmMasks
            };
            StringBuilder commandString = new StringBuilder();
            foreach(var param in parametersToPull) 
            { 
                commandString.Append(param.CommandGet); 
            }
            pierceStat.WriteRs(commandString.ToString());
            commandString.Clear();

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
                {
                    numericUpDown_FreqMeas.Value = tempD;
                    numericUpDown_FreqMeas2.Value = tempD;
                }
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
            tempD = pierceStat.FreqMin.ReadFromCOM();
            if (!numericUpDown_FreqMin.Focused)
                numericUpDown_FreqMin.Value = tempD;
            tempD = pierceStat.FreqMax.ReadFromCOM();
            if (!numericUpDown_FreqMax.Focused)
                numericUpDown_FreqMax.Value = tempD;
            pierceStat.Alarms.ReadFromCOM();
            pierceStat.AlarmMasks.ReadFromCOM();
            if (!checkBox_AlarmCurrentCh1Masked.Focused)
                checkBox_AlarmCurrentCh1Masked.Checked = ((pierceStat.AlarmMasks.Value >> 0) & 1) == 0;
            if (!checkBox_AlarmCurrentCh2Masked.Focused)
                checkBox_AlarmCurrentCh2Masked.Checked = ((pierceStat.AlarmMasks.Value >> 1) & 1) == 0;
            if (!checkBox_AlarmU_PowerMasked.Focused)
                checkBox_AlarmU_PowerMasked.Checked = ((pierceStat.AlarmMasks.Value >> 2) & 1) == 0;
            if (!checkBox_AlarmU_HeaterMasked.Focused)
                checkBox_AlarmU_HeaterMasked.Checked = ((pierceStat.AlarmMasks.Value >> 3) & 1) == 0;
            if (!checkBox_AlarmTemp1Masked.Focused)
                checkBox_AlarmTemp1Masked.Checked = ((pierceStat.AlarmMasks.Value >> 4) & 1) == 0;
            if (!checkBox_AlarmTemp2Masked.Focused)
                checkBox_AlarmTemp2Masked.Checked = ((pierceStat.AlarmMasks.Value >> 5) & 1) == 0;
            if (!checkBox_AlarmTemp3Masked.Focused)
                checkBox_AlarmTemp3Masked.Checked = ((pierceStat.AlarmMasks.Value >> 6) & 1) == 0;
            if (!checkBox_AlarmTemp4Masked.Focused)
                checkBox_AlarmTemp4Masked.Checked = ((pierceStat.AlarmMasks.Value >> 7) & 1) == 0;
            if (!checkBox_AlarmFreqMasked.Focused)
                checkBox_AlarmFreqMasked.Checked = ((pierceStat.AlarmMasks.Value >> 8) & 1) == 0;

            pictureBox_AlarmCurrentCh1.Refresh();
            pictureBox_AlarmCurrentCh2.Refresh();
            pictureBox_AlarmFreq.Refresh();
            pictureBox_AlarmTemp1.Refresh();
            pictureBox_AlarmTemp2.Refresh();
            pictureBox_AlarmTemp3.Refresh();
            pictureBox_AlarmTemp4.Refresh();
            pictureBox_AlarmU_Heater.Refresh();
            pictureBox_AlarmU_Power.Refresh();
            
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
            chart_Temps.Series[4].Enabled = checkBox_PlotTempFreq.Checked;
            chart_Freq.Series[0].Enabled = checkBox_PlotFreq.Checked;
            chart_Freq.Series[1].Enabled = checkBox_PlotDeriv.Checked;

            if(checkBox_PeakFilter.Checked && frequency.Count > 2)
            {
                
                if (System.Math.Abs(frequency[frequency.Count - 1] - frequency[frequency.Count - 2]) < bandwidth)
                {
                    Decimal average = (frequency[frequency.Count - 1] + frequency[frequency.Count - 2]) / 2;
                    if (System.Math.Abs(pierceStat.FreqMeas.Value - average) > bandwidth)
                    {
                        frequency.Add(frequency[frequency.Count - 1]);
                    }
                    else
                    {
                        frequency.Add(pierceStat.FreqMeas.Value);
                    }
                }
                else
                {
                    frequency.Add(pierceStat.FreqMeas.Value);
                }                
            }
            else
            {
                frequency.Add(pierceStat.FreqMeas.Value);
            }
            temperature[4].Add((frequency.Last() - offset)/kprt);
            chart_Temps.Series[4].Points.AddXY(time.Last(), temperature[4].Last());
            chart_Freq.Series[0].Points.AddXY(time.Last(), frequency.Last());
            int numPointsDeriv = (int)numericUpDown_DerNumber.Value;
            if (time.Count > (numPointsDeriv - 1))
                derivative.Add(Math.LeastSquared(time.GetRange(time.Count - numPointsDeriv, numPointsDeriv), 
                    frequency.GetRange(frequency.Count - numPointsDeriv, numPointsDeriv)).deriv);
            else
                derivative.Add(0);
            chart_Freq.Series[1].Points.AddXY(time.Last(), derivative.Last());
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
            if (sender is PictureBox pB)
            {
                Color color = Color.Black;
                color = (pB == pictureBox_AlarmCurrentCh1) ? ((pierceStat.Alarms.Value & (1 << 0)) != 0 ? Color.Red : Color.Green) : color;
                color = (pB == pictureBox_AlarmCurrentCh2) ? ((pierceStat.Alarms.Value & (1 << 1)) != 0 ? Color.Red : Color.Green) : color;
                color = (pB == pictureBox_AlarmFreq) ? ((pierceStat.Alarms.Value & (1 << 8)) != 0 ? Color.Red : Color.Green) : color;
                color = (pB == pictureBox_AlarmTemp1) ? ((pierceStat.Alarms.Value & (1 << 4)) != 0 ? Color.Red : Color.Green) : color;
                color = (pB == pictureBox_AlarmTemp2) ? ((pierceStat.Alarms.Value & (1 << 5)) != 0 ? Color.Red : Color.Green) : color;
                color = (pB == pictureBox_AlarmTemp3) ? ((pierceStat.Alarms.Value & (1 << 6)) != 0 ? Color.Red : Color.Green) : color;
                color = (pB == pictureBox_AlarmTemp4) ? ((pierceStat.Alarms.Value & (1 << 7)) != 0 ? Color.Red : Color.Green) : color;
                color = (pB == pictureBox_AlarmU_Heater) ? ((pierceStat.Alarms.Value & (1 << 3)) != 0 ? Color.Red : Color.Green) : color;
                color = (pB == pictureBox_AlarmU_Power) ? ((pierceStat.Alarms.Value & (1 << 2)) != 0 ? Color.Red : Color.Green) : color;
                e.Graphics.FillEllipse(new SolidBrush(color),
                new Rectangle(0, 0, pictureBox_AlarmCurrentCh1.ClientSize.Width - 1, pictureBox_AlarmCurrentCh1.ClientSize.Height - 1));
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
                if (modeDependent)
                {
                    pierceStat.ChannelOn[1].Value = pierceStat.ChannelOn[0].Value;
                    button_EnableCh2.Text = button_EnableCh1.Text;
                }
            }
        }

        private void button_EnableCh2_Click(object sender, EventArgs e)
        {
            //Changed from GUI
            if (button_EnableCh2.Focused)
            {
                pierceStat.ChannelOn[1].Value = (button_EnableCh2.Text == "Enable") ? true : false;
                button_EnableCh2.Text = (button_EnableCh2.Text == "Enable") ? "Disable" : "Enable";
                if (modeDependent)
                {
                    pierceStat.ChannelOn[0].Value = pierceStat.ChannelOn[1].Value;
                    button_EnableCh1.Text = button_EnableCh2.Text;
                }
            }
        }

        private void radioButton_ModeDependent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ModeDependent.Checked)
            {
                modeDependent = true;
            }
            else
            {
                modeDependent = false;
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
                if (modeDependent)
                {
                    numericUpDown_SetPointTemp2.Value = numericUpDown_SetPointTemp1.Value;
                    pierceStat.TempSet[1].Value = pierceStat.TempSet[0].Value;
                }                
            }
        }

        private void numericUpDown_SetPointTemp2_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_SetPointTemp2.Focused)
            {
                pierceStat.TempSet[1].Value = numericUpDown_SetPointTemp2.Value;
                if (modeDependent)
                {
                    numericUpDown_SetPointTemp1.Value = numericUpDown_SetPointTemp2.Value;
                    pierceStat.TempSet[0].Value = pierceStat.TempSet[1].Value;
                }
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
            if (numericUpDown_FreqMin.Focused)
            {
                pierceStat.FreqMin.Value = numericUpDown_FreqMin.Value;
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

        private void button_SaveData_Click(object sender, EventArgs e)
        {
            string delim = "\t";
            System.IO.StreamWriter file
                = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + $"PierceStatData_{DateTime.Now.ToString("M_d_yyyy__hh_mm_ss")}.dat");
            file.WriteLine("Time,s" + delim + "Temp1,C" + delim + "Temp2,C" + delim + "Temp3,C" + delim + "Temp4,C" + delim + "Temp(f),C" + delim + "Freq, Hz" + delim + "Deriv, Hz/s");
            for(int i = 0; i < time.Count; i++)
            {
                file.WriteLine($"{time[i]}{delim}{temperature[0][i]}{delim}{temperature[1][i]}{delim}{temperature[2][i]}{delim}{temperature[3][i]}{delim}" +
                    $"{temperature[4][i]}{delim}" + 
                    $"{frequency[i]}{delim}{derivative[i]}");
            }

            file.Close();
        }

        private async void button_CalibrateKprt_Click(object sender, EventArgs e)
        {
            if (button_CalibrateKprt.Text == "Calibrate")
            {
                button_CalibrateKprt.Text = "Stop";
                Decimal tStart = numericUpDown_TstartKprt.Value;
                Decimal tStop = numericUpDown_TstopKprt.Value;
                Decimal numberOfPoints = numericUpDown_NumPointsKprt.Value;
                List<Decimal> tempList = new List<Decimal>();
                List<Decimal> freqList = new List<Decimal>();
                for (int i = 0; i < numberOfPoints; i++)
                {
                    ResetPlot();
                    tempList.Add(i * (tStop - tStart) / (numberOfPoints - 1) + tStart);
                    Console.WriteLine(tempList.Last());
                    pierceStat.TempSet[0].Value = tempList.Last();
                    pierceStat.TempSet[1].Value = tempList.Last();
                    pierceStat.ChannelOn[0].Value = true;
                    pierceStat.ChannelOn[1].Value = true;
                    await WaitForSteadyCondition();
                    if (button_CalibrateKprt.Text == "Calibrate")
                        return;
                    freqList.Add(pierceStat.FreqMeas.Value);
                    dataGridView_Data.Rows.Add(pierceStat.TempMeas[0].Value, pierceStat.TempMeas[1].Value, temperature[4].Last(), pierceStat.FreqMeas.Value, "");
                }

                (kprt, offset) = Math.LeastSquared(tempList, freqList);
                numericUpDown_KprtValue.Value = kprt;
                numericUpDown_freqOffset.Value = offset;
                button_CalibrateKprt.Text = "Calibrate";
                ResetPlot();
                checkBox_PlotTempFreq.Checked = true;
            }
            else
            {
                pierceStat.ChannelOn[0].Value = false;
                pierceStat.ChannelOn[1].Value = false;
                button_CalibrateKprt.Text = "Calibrate";
            }
            
        }

        async Task WaitForSteadyCondition()
        {
            bool steady = false;
            while (!steady)
            {
                if (button_CalibrateKprt.Text == "Calibrate")
                    break;
                int avaliablePoints = frequency.Count;
                int amount = (int) (awaitTime / timer1.Interval * 1000M);
                if (avaliablePoints > amount)
                {
                    List<decimal> freq = frequency.GetRange(avaliablePoints - amount - 1, amount);
                    if (freq.Max() - freq.Min() < deltaF)
                    {
                        steady = true;
                    }
                }
                await Task.Delay(1000);
            }
        }

        private void numericUpDown_FreqMax_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_FreqMax.Focused)
            {
                pierceStat.FreqMax.Value = numericUpDown_FreqMax.Value;
            }
        }

        private void checkBox_AlarmCurrentCh1Masked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmCurrentCh1Masked.Focused)
            {
                int bitValue = checkBox_AlarmCurrentCh1Masked.Checked ? 0 : 1;
                int bitPosition = 0;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void checkBox_AlarmCurrentCh2Masked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmCurrentCh2Masked.Focused)
            {
                int bitValue = checkBox_AlarmCurrentCh2Masked.Checked ? 0 : 1;
                int bitPosition = 1;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void checkBox_AlarmU_PowerMasked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmU_PowerMasked.Focused)
            {
                int bitValue = checkBox_AlarmU_PowerMasked.Checked ? 0 : 1;
                int bitPosition = 2;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void checkBox_AlarmU_HeaterMasked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmU_HeaterMasked.Focused)
            {
                int bitValue = checkBox_AlarmU_HeaterMasked.Checked ? 0 : 1;
                int bitPosition = 3;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void checkBox_AlarmTemp1Masked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmTemp1Masked.Focused)
            {
                int bitValue = checkBox_AlarmTemp1Masked.Checked ? 0 : 1;
                int bitPosition = 4;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void checkBox_AlarmTemp2Masked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmTemp2Masked.Focused)
            {
                int bitValue = checkBox_AlarmTemp2Masked.Checked ? 0 : 1;
                int bitPosition = 5;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void checkBox_AlarmTemp3Masked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmTemp3Masked.Focused)
            {
                int bitValue = checkBox_AlarmTemp3Masked.Checked ? 0 : 1;
                int bitPosition = 6;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void checkBox_AlarmTemp4Masked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmTemp4Masked.Focused)
            {
                int bitValue = checkBox_AlarmTemp4Masked.Checked ? 0 : 1;
                int bitPosition = 7;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void checkBox_AlarmFreqMasked_CheckedChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (checkBox_AlarmFreqMasked.Focused)
            {
                int bitValue = checkBox_AlarmFreqMasked.Checked ? 0 : 1;
                int bitPosition = 8;
                pierceStat.AlarmMasks.Value = (pierceStat.AlarmMasks.Value & ~(1 << bitPosition)) | (bitValue << bitPosition);
            }
        }

        private void numericUpDown_KprtValue_ValueChanged(object sender, EventArgs e)
        {
            kprt = numericUpDown_KprtValue.Value;
        }

        private void numericUpDown_freqOffset_ValueChanged(object sender, EventArgs e)
        {
            offset = numericUpDown_freqOffset.Value;
        }

        private void numericUpDown_FilterBand_ValueChanged(object sender, EventArgs e)
        {
            bandwidth = numericUpDown_FilterBand.Value;
        }

        private void numericUpDown_DeltaF_ValueChanged(object sender, EventArgs e)
        {
            deltaF = numericUpDown_DeltaF.Value;
        }

        private void numericUpDown_AwaitTime_ValueChanged(object sender, EventArgs e)
        {
            awaitTime = numericUpDown_AwaitTime.Value;
        }

        private void button_AddData_Click(object sender, EventArgs e)
        {
            dataGridView_Data.Rows.Add(pierceStat.TempMeas[0].Value, pierceStat.TempMeas[1].Value, temperature[4].Last(), pierceStat.FreqMeas.Value, "");
        }

        private void button_ClearTable_Click(object sender, EventArgs e)
        {
            dataGridView_Data.Rows.Clear();
        }

        private void button_SaveTable_Click(object sender, EventArgs e)
        {
            string delim = "\t";
            System.IO.StreamWriter file
                = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + $"Table_PierceStatData_{DateTime.Now.ToString("M_d_yyyy__hh_mm_ss")}.dat");
            file.WriteLine("Temp1,C" + delim + "Temp2,C" + delim + "Temp(f),C" + delim + "Freq, Hz" + delim + "Power, W");
            foreach (DataGridViewRow row in dataGridView_Data.Rows)
            {
                file.WriteLine($"{row.Cells[0].Value}{delim}{row.Cells[1].Value}{delim}{row.Cells[2].Value}{delim}{row.Cells[3].Value}{delim}{row.Cells[4].Value}");
            }

            file.Close();
        }
    }    
}
