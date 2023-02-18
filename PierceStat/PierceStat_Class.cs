﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PierceStat
{
    public class PierceStat_Class
    {
        public PierceStat_Class()
        {
            _comPort = new RsExchange();
            InitParams();       

        }

        public bool Connect(string port)
        {
            return _comPort.InitRs(port, _getID, _IDanswer);
        }

        public bool Disconnect()
        {
            return _comPort.DisRs();
        }

        public RsExchange _comPort;

        private static readonly string _getID = "*IDN?";
        private static readonly string _IDanswer = "PierceStat";

        public ParameterDecimal U_HeaterSet;
        public ParameterDecimal U_HeaterMeas;
        public ParameterDecimal U_HeaterMinAlarm;
        public ParameterDecimal U_HeaterMaxAlarm;
        public ParameterBool U_HeaterOn;
        public ParameterDecimal U_HeaterCoeff;
        //Input Voltage
        public ParameterDecimal U_PowerMeas;
        public ParameterDecimal U_PowerCoeff;
        public ParameterDecimal U_PowerMinAlarm;
        public ParameterDecimal U_PowerMaxAlarm;
        //Temperatures
        public List<ParameterDecimal> TempMeas;
        public List<ParameterDecimal> TempCoeff;
        public List<ParameterDecimal> TempMinAlarm;
        public List<ParameterDecimal> TempMaxAlarm;
        //Currents
        public List<ParameterDecimal> IMeas;
        public List<ParameterDecimal> ICoeff;
        public List<ParameterDecimal> IMaxAlarm;
        public List<ParameterBool> Load;
        public List<ParameterBool> Mode;
        public List<ParameterBool> ChannelOn;
        public List<ParameterInt> Source;
        public List<List<ParameterDecimal>> PIDTemp;
        public List<List<ParameterDecimal>> PIDFreq;
        public List<ParameterDecimal> TempSet;
        public List<ParameterDecimal> CurrentSet;

        public List<ParameterBool> gateOn;
        public List<ParameterBool> gateH;
        public List<ParameterDecimal> PWM;
        public List<ParameterBool> Polarity;
        public ParameterDecimal FreqMeas;
        public ParameterDecimal FreqSet;

        void InitParams()
        {
            //Heater Voltage
            U_HeaterSet =       new ParameterDecimal(this,  "Heater Set Voltage",               150,    12.0m,      false);
            U_HeaterMeas =      new ParameterDecimal(this,  "Heater Measured Voltage",          202,    0.0m,       true);
            U_HeaterMinAlarm =  new ParameterDecimal(this,  "Min. Heater Voltage",              151,    3.9m,       false);
            U_HeaterMaxAlarm =  new ParameterDecimal(this,  "Max. Heater Voltage",              152,    24.1m,      false);
            U_HeaterOn =        new ParameterBool(this,     "Heater DC/DC converter On/Off",    153,    false,      false);
            U_HeaterCoeff =     new ParameterDecimal(this,  "ADC Coeff for Heater Voltage",     203,    0.0116m,    false);
            //Input Voltage
            U_PowerMeas =       new ParameterDecimal(this,  "Measured Input Voltage",           200,    0m,         true);
            U_PowerCoeff =      new ParameterDecimal(this,  "ADC Coeff for Input Voltage",      201,    0.0116m,    false);
            U_PowerMinAlarm =   new ParameterDecimal(this,  "Min. Input Voltage",               204,    22,         false);
            U_PowerMaxAlarm =   new ParameterDecimal(this,  "Max. Input Voltage",               205,    26,         false);
            //Temperatures
            TempMeas = new List<ParameterDecimal> 
            {                                       
                                new ParameterDecimal(this,  "Temperature 1",                    230,    0.0m,       true),
                                new ParameterDecimal(this,  "Temperature 2",                    231,    0.0m,       true),
                                new ParameterDecimal(this,  "Temperature 3",                    232,    0.0m,       true),
                                new ParameterDecimal(this,  "Temperature 4",                    233,    0.0m,       true) 
            };
            TempCoeff = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "Temperature 1 ADC Coeff.",         234,    1.0m,       false),
                                new ParameterDecimal(this,  "Temperature 2 ADC Coeff.",         235,    1.0m,       false),
                                new ParameterDecimal(this,  "Temperature 3 ADC Coeff.",         236,    1.0m,       false),
                                new ParameterDecimal(this,  "Temperature 4 ADC Coeff.",         237,    1.0m,       false)
            };
            TempMinAlarm = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "Temperature 1 Min. Alarm",         238,    -10.0m,     false),
                                new ParameterDecimal(this,  "Temperature 2 Min. Alarm",         240,    -10.0m,     false),
                                new ParameterDecimal(this,  "Temperature 3 Min. Alarm",         242,    -10.0m,     false),
                                new ParameterDecimal(this,  "Temperature 4 Min. Alarm",         244,    -10.0m,     false)
            };
            TempMaxAlarm = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "Temperature 1 Max. Alarm",         239,    -10.0m,     false),
                                new ParameterDecimal(this,  "Temperature 2 Max. Alarm",         241,    -10.0m,     false),
                                new ParameterDecimal(this,  "Temperature 3 Max. Alarm",         243,    -10.0m,     false),
                                new ParameterDecimal(this,  "Temperature 4 Max. Alarm",         245,    -10.0m,     false)
            };
            //Currents
            IMeas = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "I_1A measure",                     210,    0.0m,       true),
                                new ParameterDecimal(this,  "I_1B measure",                     211,    0.0m,       true),
                                new ParameterDecimal(this,  "I_2A measure",                     212,    0.0m,       true),
                                new ParameterDecimal(this,  "I_2B measure",                     213,    0.0m,       true)
            };
            ICoeff = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "I_1A ADC Coeff.",                  214,    0.1m,       false),
                                new ParameterDecimal(this,  "I_1B ADC Coeff.",                  215,    0.1m,       false),
                                new ParameterDecimal(this,  "I_2A ADC Coeff.",                  216,    0.1m,       false),
                                new ParameterDecimal(this,  "I_2B ADC Coeff.",                  217,    0.1m,       false)
            };
            IMaxAlarm = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "I_1A Max. Alarm",                  218,    10.0m,      false),
                                new ParameterDecimal(this,  "I_1B Max. Alarm",                  219,    10.0m,      false),
                                new ParameterDecimal(this,  "I_2A Max. Alarm",                  220,    10.0m,      false),
                                new ParameterDecimal(this,  "I_2B Max. Alarm",                  221,    10.0m,      false)
            };
            Load = new List<ParameterBool>//false - resistor, true - Peltier
            {
                                new ParameterBool(this,     "Channel 1 Peltier Load",           301,    false,      false), 
                                new ParameterBool(this,     "Channel 2 Peltier Load",           302,    false,      false)
            };
            Mode = new List<ParameterBool>//false - PID, true - const I
            {
                                new ParameterBool(this,     "Channel 1 const I mode",           303,    false,      false),
                                new ParameterBool(this,     "Channel 2 const I mode",           304,    false,      false)
            };
            ChannelOn = new List<ParameterBool>
            {
                                new ParameterBool(this,     "Channel 1 ON",                     305,    false,      false),
                                new ParameterBool(this,     "Channel 2 ON",                     306,    false,      false)
            };
            Source = new List<ParameterInt>
            {
                                new ParameterInt(this,      "Channel 1 source",                 307,    4,          false),
                                new ParameterInt(this,      "Channel 2 source",                 308,    4,          false)
            };
            PIDTemp = new List<List<ParameterDecimal>>
            {
                new List<ParameterDecimal> 
                {
                                new ParameterDecimal(this,  "Channel 1 PID P Coeff. Temp",      309,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 1 PID I Coeff. Temp",      311,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 1 PID D Coeff. Temp",      313,    0.0m,       false)
                },
                new List<ParameterDecimal> 
                {
                                new ParameterDecimal(this,  "Channel 2 PID P Coeff. Temp",      310,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 2 PID I Coeff. Temp",      312,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 2 PID D Coeff. Temp",      314,    0.0m,       false)
                }
            };
            PIDFreq = new List<List<ParameterDecimal>>
            {
                new List<ParameterDecimal>
                {
                                new ParameterDecimal(this,  "Channel 1 PID P Coeff. Freq",      315,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 1 PID I Coeff. Freq",      317,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 1 PID D Coeff. Freq",      319,    0.0m,       false)
                },
                new List<ParameterDecimal>
                {
                                new ParameterDecimal(this,  "Channel 2 PID P Coeff. Freq",      316,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 2 PID I Coeff. Freq",      318,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 2 PID D Coeff. Freq",      320,    0.0m,       false)
                }
            };
            TempSet = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "Channel 1 Set Temperature",        321,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 2 Set Temperature",        322,    0.0m,       false)
            };
            CurrentSet = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "Channel 1 Set Current",            330,    0.0m,       false),
                                new ParameterDecimal(this,  "Channel 2 Set Current",            331,    0.0m,       false)
            };

            gateOn = new List<ParameterBool>
            {
                                new ParameterBool(this,     "gate1A On Off",                    401,    false,      true),
                                new ParameterBool(this,     "gate1B On Off",                    402,    false,      true),
                                new ParameterBool(this,     "gate2A On Off",                    403,    false,      true),
                                new ParameterBool(this,     "gate2B On Off",                    404,    false,      true)
            };
            gateH = new List<ParameterBool>
            {
                                new ParameterBool(this,     "Ch1A High Gate",                   405,    false,      true),
                                new ParameterBool(this,     "Ch1B High Gate",                   406,    false,      true),
                                new ParameterBool(this,     "Ch2A High Gate",                   407,    false,      true),
                                new ParameterBool(this,     "Ch2B High Gate",                   408,    false,      true)
            };
            PWM = new List<ParameterDecimal>
            {
                                new ParameterDecimal(this,  "Channel 1 PWM Duty Cycle (signed)", 409,   0.0m,       true),
                                new ParameterDecimal(this,  "Channel 2 PWM Duty Cycle (signed)", 410,   0.0m,       true)
            };
            Polarity = new List<ParameterBool>
            {
                                new ParameterBool(this,     "Channel 1 Polarity",               411,    true,       false),
                                new ParameterBool(this,     "Channel 2 Polarity",               412,    true,       false)
            };
            FreqMeas =          new ParameterDecimal(this,  "Pierce frequency",                 500,    0.0m,       false);
            FreqSet =           new ParameterDecimal(this,  "Set Pierce frequency",             501,    0.0m,       false);

         
            //Alarms
            //parametersTable["Alarms", new Parameter<int>("Alarms vector", 700, 0, true);
            //parametersTable["Alarms Masks", new Parameter<int>("Alarm masks vector", 800, 0, false);

        }
    }
    public abstract class AbstractParameter
    {
        public AbstractParameter(PierceStat_Class instance, string description, int number)
        {
            this._description = description;
            this._number = number;
            this._instance = instance;
        }

        public int Number { get { return _number; } }
        public string Description { get { return _description; } }

        protected readonly PierceStat_Class _instance;

        private readonly int _number;
        private readonly string _description;
    }

    public class Command : AbstractParameter
    {
        public Command(PierceStat_Class instance, string description, int number) : base(instance, description, number)
        {
        }

        public void DoCommand()
        {
            _instance._comPort.WriteRs("$" + Number.ToString() + "?");
            string reply = _instance._comPort.ReadRs();
            Console.WriteLine(reply);
        }
    }

    public abstract class Parameter<T> : AbstractParameter where T : IComparable
    {
        public Parameter(PierceStat_Class instance, string description, int number, T value, bool readOnly = false) : base(instance, description, number)
        {
            this._value = value;
            this._readOnly = readOnly;
        }

        public T Value
        {
            get
            {
                _instance._comPort.WriteRs("$" + Number.ToString() + "?");
                return ReadFromCOM();
            }
            set
            {
                _value = value;
                _instance._comPort.WriteRs("$" + Number.ToString() + ":" + GetInString());
                string reply = _instance._comPort.ReadRs();
                //Console.WriteLine(reply);
                
            }
        }

        public T ValueStored
        {
            get => _value;
            set => _value = value;
        }

        public bool ReadOnly => _readOnly;

        public string CommandGet()
        {
            return "$" + Number.ToString() + "?;";
        }

        public string CommandSet(T value)
        {
            return "$" + Number.ToString() + ":" + value.ToString();
        }

        public T ReadFromCOM()
        {
            string reply = _instance._comPort.ReadRs();
            if (reply.Length > 5)
                reply = reply.Substring(5);
            else
            {
                reply = null;
                Console.WriteLine("Too short reply");
                return _value;
            }
                
            if (!SetFromString(reply))
            {
                Console.WriteLine("Can't parse: " + reply);
            }
            return _value;
        }

        public abstract bool SetFromString(string str);

        public string GetInString()
        {
            return _value.ToString();
        }

        protected T _value;
        private readonly bool _readOnly;
    }

    public class ParameterDecimal : Parameter<decimal>
    {
        public ParameterDecimal(PierceStat_Class instance, string description, int number, decimal value, bool readOnly = false) : base(instance, description, number, value, readOnly)
        {
        }


        public override bool SetFromString(string str)
        {
            bool res = Decimal.TryParse(str, NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal value);
            _value = value;
            return res;
        }

    }

    public class ParameterInt : Parameter<int>
    {
        public ParameterInt(PierceStat_Class instance, string description, int number, int value, bool readOnly = false) : base(instance, description, number, value, readOnly)
        {
        }


        public override bool SetFromString(string str)
        {
            bool res = int.TryParse(str, NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out int value);
            _value = value;
            return res;
        }

    }

    public class ParameterBool : Parameter<bool>
    {
        public ParameterBool(PierceStat_Class instance, string description, int number, bool value, bool readOnly = false) : base(instance, description, number, value, readOnly)
        {
        }


        public override bool SetFromString(string str)
        {
            if (str == "true" || str == "1")
            {
                _value = true;
                return true;
            }
            else if (str == "false" || str == "0")
            {
                _value = false;
                return true;
            }
            return false;
        }

    }
}