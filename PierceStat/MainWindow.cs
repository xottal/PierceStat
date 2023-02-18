using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PierceStat
{
    public partial class Form_MainWindow : Form
    {
        public Form_MainWindow()
        {
            InitializeComponent();
            updateCOMPortsToolStripMenuItem_Click(1, null);
            form_Settings = new Form_Settings();

            pierceStat = new PierceStat_Class();
            pierceStat._comPort.RsMessage += new ErrorHandler(AddMessage);


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

        public void AddMessage(string message)
        {
            richTextBox_Messages.AppendText(message + '\n');
            richTextBox_Messages.ScrollToCaret();
        }
        public void AddMessage(object source, MyErrorArgs e)
        {
            richTextBox_Messages.AppendText($"{e.ErrorSource}: {e.ErrorInfo}\n");
            richTextBox_Messages.ScrollToCaret();

        }

        public void InterfaceEnable(bool bl)
        {
            comboBox_ComPortsList.Enabled = bl;
            groupBox_PierceStat.Enabled = bl;
        }

        public void PullParamaters()
        {
            string command = pierceStat.U_HeaterSet.CommandGet() +
                pierceStat.U_HeaterMeas.CommandGet() +
                pierceStat.U_HeaterMaxAlarm.CommandGet() +
                pierceStat.U_HeaterMinAlarm.CommandGet() +
                pierceStat.U_HeaterOn.CommandGet() +
                pierceStat.U_PowerMeas.CommandGet() +
                pierceStat.U_PowerMaxAlarm.CommandGet() +
                pierceStat.U_PowerMinAlarm.CommandGet() +
                pierceStat.TempMeas[0].CommandGet() +
                pierceStat.TempMeas[1].CommandGet() +
                pierceStat.TempMeas[2].CommandGet() +
                pierceStat.TempMeas[3].CommandGet() +
                pierceStat.TempMinAlarm[0].CommandGet() +
                pierceStat.TempMinAlarm[1].CommandGet() +
                pierceStat.TempMinAlarm[2].CommandGet() +
                pierceStat.TempMinAlarm[3].CommandGet() +
                pierceStat.TempMaxAlarm[0].CommandGet() +
                pierceStat.TempMaxAlarm[1].CommandGet() +
                pierceStat.TempMaxAlarm[2].CommandGet() +
                pierceStat.TempMaxAlarm[3].CommandGet() +
                pierceStat.IMeas[0].CommandGet() +
                pierceStat.IMeas[1].CommandGet() +
                pierceStat.IMeas[2].CommandGet() +
                pierceStat.IMeas[3].CommandGet() +
                pierceStat.IMaxAlarm[0].CommandGet() +
                pierceStat.IMaxAlarm[1].CommandGet() +
                pierceStat.IMaxAlarm[2].CommandGet() +
                pierceStat.IMaxAlarm[3].CommandGet() +
                pierceStat.Load[0].CommandGet() +
                pierceStat.Load[1].CommandGet() +
                pierceStat.Mode[0].CommandGet() +
                pierceStat.Mode[1].CommandGet() + 
                pierceStat.ChannelOn[0].CommandGet() +
                pierceStat.ChannelOn[1].CommandGet() + 
                pierceStat.Source[0].CommandGet() +
                pierceStat.Source[1].CommandGet();
            pierceStat._comPort.WriteRs(command);

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

            command = pierceStat.PIDTemp[0][0].CommandGet() +
                pierceStat.PIDTemp[0][1].CommandGet() +
                pierceStat.PIDTemp[0][2].CommandGet() +
                pierceStat.PIDTemp[1][0].CommandGet() +
                pierceStat.PIDTemp[1][1].CommandGet() +
                pierceStat.PIDTemp[1][2].CommandGet() +
                pierceStat.PIDFreq[0][0].CommandGet() +
                pierceStat.PIDFreq[0][1].CommandGet() +
                pierceStat.PIDFreq[0][2].CommandGet() +
                pierceStat.PIDFreq[1][0].CommandGet() +
                pierceStat.PIDFreq[1][1].CommandGet() +
                pierceStat.PIDFreq[1][2].CommandGet() +
                pierceStat.TempSet[0].CommandGet() +
                pierceStat.TempSet[1].CommandGet() +
                pierceStat.CurrentSet[0].CommandGet() +
                pierceStat.CurrentSet[1].CommandGet() +
                pierceStat.Polarity[0].CommandGet() +
                pierceStat.Polarity[1].CommandGet() +
                pierceStat.FreqMeas.CommandGet() +
                pierceStat.FreqSet.CommandGet()
                ;
            pierceStat._comPort.WriteRs(command);

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

                            PullParamaters();
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
            if (button_EnableCh1.Text == "Enable")
            {
                button_EnableCh1.Text = "Disable";
            }
            else
            {
                button_EnableCh1.Text = "Enable";
            }
            //Changed from GUI
            if (button_EnableCh1.Focused)
            {

            }
        }

        private void button_EnableCh2_Click(object sender, EventArgs e)
        {
            if (button_EnableCh2.Text == "Enable")
            {
                button_EnableCh2.Text = "Disable";
            }
            else
            {
                button_EnableCh2.Text = "Enable";
            }
            //Changed from GUI
            if (button_EnableCh2.Focused)
            {

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

        private void checkBox_Polarity1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Polarity2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown_U_HeaterSet_ValueChanged(object sender, EventArgs e)
        {
            //Changed from GUI
            if (numericUpDown_U_HeaterSet.Focused)
            {
                Console.WriteLine(("Value changed to " + numericUpDown_U_HeaterSet.Value.ToString()));
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
    }

    public delegate void ErrorHandler(object source, MyErrorArgs e);
    public class MyErrorArgs : EventArgs
    {
        public string ErrorSource { get; set; }
        public string ErrorInfo { get; set; }
        public MyErrorArgs(string errorSource, string errorInfo)
        {
            ErrorSource = errorSource;
            ErrorInfo = errorInfo;
        }
    }

    
}
