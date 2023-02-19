using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PierceStat
{
    public partial class Form_Settings : Form
    {
        public Form_Settings(PierceStat_Class instance)
        {
            InitializeComponent();
            this._instance = instance;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
            {
                return;
            }
            e.Cancel = true;
            Hide();
        }

        public void PullParamaters()
        {
            List<IParameter> parametersToPull = new List<IParameter> {
                _instance.ICoeff[0],
                _instance.ICoeff[1],
                _instance.ICoeff[2],
                _instance.ICoeff[3],
                _instance.U_HeaterCoeff,
                _instance.U_PowerCoeff,
                _instance.TempCoeff[0],
                _instance.TempCoeff[1],
                _instance.TempCoeff[2],
                _instance.TempCoeff[3],
                _instance.gateH[0],
                _instance.gateH[1],
                _instance.gateH[2],
                _instance.gateH[3],
                _instance.PWM[0],
                _instance.PWM[1]
                };
            StringBuilder command = new StringBuilder();
            foreach (var param in parametersToPull)
            {
                command.Append(param.CommandGet);
            }
            _instance.WriteRs(command.ToString());
            command.Clear();

            decimal tempD;
            for (int i = 0; i < 4; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_I1ACoeff;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_I1ACoeff;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_I1BCoeff;
                        break;
                    case 2:
                        numericUpDown = numericUpDown_I2ACoeff;
                        break;
                    case 3:
                        numericUpDown = numericUpDown_I2BCoeff;
                        break;
                }
                tempD = _instance.ICoeff[i].ReadFromCOM();
                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }

            tempD = _instance.U_HeaterCoeff.ReadFromCOM();
            if (!numericUpDown_U_HeaterCoeff.Focused)
                numericUpDown_U_HeaterCoeff.Value = tempD;

            tempD = _instance.U_PowerCoeff.ReadFromCOM();
            if (!numericUpDown_U_PowerCoeff.Focused)
                numericUpDown_U_PowerCoeff.Value = tempD;

            for (int i = 0; i < 4; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_Temp1Coeff;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_Temp1Coeff;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_Temp2Coeff;
                        break;
                    case 2:
                        numericUpDown = numericUpDown_Temp3Coeff;
                        break;
                    case 3:
                        numericUpDown = numericUpDown_Temp4Coeff;
                        break;
                }
                tempD = _instance.TempCoeff[i].ReadFromCOM();
                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }

            for (int i = 0; i < 4; i++)
            {
                CheckBox checkBox = checkBox_Gate1A;
                switch (i)
                {
                    case 0:
                        checkBox = checkBox_Gate1A;
                        break;
                    case 1:
                        checkBox = checkBox_Gate1B;
                        break;
                    case 2:
                        checkBox = checkBox_Gate2A;
                        break;
                    case 3:
                        checkBox = checkBox_Gate2B;
                        break;
                }
                bool tempB = _instance.gateOn[i].ReadFromCOM();
                if (!checkBox.Focused)
                    checkBox.Checked = tempB;
            }

            for (int i = 0; i < 2; i++)
            {
                NumericUpDown numericUpDown = numericUpDown_PWM1;
                switch (i)
                {
                    case 0:
                        numericUpDown = numericUpDown_PWM1;
                        break;
                    case 1:
                        numericUpDown = numericUpDown_PWM2;
                        break;
                }
                tempD = _instance.PWM[i].ReadFromCOM();
                if (!numericUpDown.Focused)
                    numericUpDown.Value = tempD;
            }
        }

        private PierceStat_Class _instance;

        private void numericUpDown_I1ACoeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_I1ACoeff.Focused)
            {
                _instance.ICoeff[0].Value = numericUpDown_I1ACoeff.Value;
            }
        }

        private void numericUpDown_I1BCoeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_I1BCoeff.Focused)
            {
                _instance.ICoeff[1].Value = numericUpDown_I1BCoeff.Value;
            }
        }

        private void numericUpDown_I2ACoeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_I2ACoeff.Focused)
            {
                _instance.ICoeff[2].Value = numericUpDown_I2ACoeff.Value;
            }
        }

        private void numericUpDown_I2BCoeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_I2BCoeff.Focused)
            {
                _instance.ICoeff[3].Value = numericUpDown_I2BCoeff.Value;
            }
        }

        private void numericUpDown_U_HeaterCoeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_U_HeaterCoeff.Focused)
            {
                _instance.U_HeaterCoeff.Value = numericUpDown_U_HeaterCoeff.Value;
            }
        }

        private void numericUpDown_U_PowerCoeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_U_PowerCoeff.Focused)
            {
                _instance.U_PowerCoeff.Value = numericUpDown_U_PowerCoeff.Value;
            }
        }

        private void numericUpDown_Temp1Coeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_Temp1Coeff.Focused)
            {
                _instance.TempCoeff[0].Value = numericUpDown_Temp1Coeff.Value;
            }
        }

        private void numericUpDown_Temp2Coeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_Temp2Coeff.Focused)
            {
                _instance.TempCoeff[1].Value = numericUpDown_Temp2Coeff.Value;
            }
        }

        private void numericUpDown_Temp3Coeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_Temp3Coeff.Focused)
            {
                _instance.TempCoeff[2].Value = numericUpDown_Temp3Coeff.Value;
            }
        }

        private void numericUpDown_Temp4Coeff_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown_Temp4Coeff.Focused)
            {
                _instance.TempCoeff[3].Value = numericUpDown_Temp4Coeff.Value;
            }
        }
    }
}
