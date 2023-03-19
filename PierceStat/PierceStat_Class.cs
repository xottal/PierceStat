using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Net.Http;
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
        public PierceStat_Class(MessageHandler messageHandler)
        {
            _comPort = new RsExchange(messageHandler);
            _messageHandler = messageHandler;
            _initParams();
        }

        public bool Connect(string port)
        {
            return _comPort.InitRs(port, _getID, _IDanswer);
        }

        public bool Disconnect()
        {

            return _comPort.DisRs();
        }

        public bool WriteRs(string command)
        {
            return _comPort.WriteRs(command);
        }

        public string ReadRs()
        {
            return _comPort.ReadRs();
        }

        public void AddMessage(object source, MessageArgs e)
        {
            _messageHandler(source, e);
        }


        private RsExchange _comPort;
        public delegate void MessageHandler(object source, MessageArgs e);
        public event MessageHandler _messageHandler;

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
        public ParameterDecimal FreqMin;
        public ParameterDecimal FreqMax;

        //Alarms
        public ParameterInt Alarms;
        public ParameterInt AlarmMasks;

        public Command SaveFlash;

        private void _initParams()
        {
            SaveFlash = new Command(this, "Save Flash", 110);

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
            FreqMeas =          new ParameterDecimal(this,  "Pierce frequency",                 500,    0.0m,       true);
            FreqSet =           new ParameterDecimal(this,  "Set Pierce frequency",             501,    0.0m,       false);
            FreqMin =           new ParameterDecimal(this,  "Min frequency",                    502,    0.0m,       false);
            FreqMax =           new ParameterDecimal(this,  "Max frequency",                    503,    0.0m,       false);


            Alarms = new ParameterInt(this,                 "Alarm Vector",                     700,    0b0,        false);
            AlarmMasks = new ParameterInt(this,             "Alarm Masks Vector",               800,    0b0,        false);
        }
    }
    
    public interface ICommand
    {
        int Number { get; }
        string Description { get; }
    }
    
    public interface IParameter : ICommand
    {
        bool ReadOnly { get; }
        string CommandGet { get; }
        string CommandSet { get; }
        bool SetFromString(string value);
        string GetInString();
    }
    
    public interface IParameter<T> : IParameter where T : IComparable
    {
        T Value { get; set; }
        T ReadFromCOM();
        T GetFromCOM();

    }

    public class Command : ICommand
    {

        private PierceStat_Class _instance;
        public int Number { get; }
        public string Description { get; }

        public string CommandString { get; }

        public Command(PierceStat_Class instance, string description, int number)
        {
            this._instance = instance;
            this.Number = number;
            this.Description = description;
            this.CommandString = $"${this.Number}?";
        }

        public void DoCommand()
        {
            _instance.WriteRs(this.CommandString);
            string reply = _instance.ReadRs();
            Console.WriteLine(reply);
        }
    }


    public abstract class Parameter<T> : IParameter<T> where T : IComparable
    {
        private PierceStat_Class _instance;
        public int Number { get; }
        public string Description { get; }
        public string CommandGet { get; }
        public string CommandSet { get; }
        public bool ReadOnly { get; }

        public delegate void MessageHandler(object source, MessageArgs e);

        protected T _value;
        
        public Parameter(PierceStat_Class instance, string description, int number, T value, bool readOnly = false)
        {
            this._instance = instance;
            this.Description = description;
            this.Number = number;
            this._value = value;
            this.ReadOnly = readOnly;
            this.CommandGet = $"${this.Number}?;";
            this.CommandSet = $"${this.Number}:";
        }

        public T Value
        {
            get => _value;

            set
            {
                _value = value;
                _instance.WriteRs(CommandSet + GetInString());
                string reply = _instance.ReadRs();
                if (reply.Length < 5 || reply[5] == 'N')
                    _instance.AddMessage(this, new MessageArgs($"Parameter Value Set()", $"{this.Number}: Incorrect value"));
            }
        }

        public T ReadFromCOM()
        {
            string reply = _instance.ReadRs();
            if (reply.Length > 5)
                reply = reply.Substring(5);
            else
            {
                _instance.AddMessage(this, new MessageArgs($"ReadFromCom()", $"Too short reply {this.Number}: " + reply));
                reply = null;
                return _value;
            }
                
            if (!SetFromString(reply))
            {
                _instance.AddMessage(this, new MessageArgs($"ReadFromCom()", $"Can't parse {this.Number}: " + reply));
            }
            return _value;
        }

        public T GetFromCOM()
        {
            _instance.WriteRs(CommandGet);
            return ReadFromCOM();
        }

        public abstract bool SetFromString(string str);

        public string GetInString()
        {
            string str = _value.ToString();
            if (typeof(T) == typeof(bool))
                str = (str == "False") ? "false" : "true";
            return str;
        }

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
    public class MessageArgs : EventArgs
    {
        public string MessageTime
        {
            get
            {
                return _messageTime;
            }
        }
        public string MessageSource
        {
            get
            {
                return _messageSource;
            }

        }
        public string MessageInfo
        {
            get
            {
                return _messageInfo;
            }
        }
        public MessageArgs(string messageSource, string messageInfo)
        {
            _messageSource = messageSource;
            _messageInfo = messageInfo;
            _messageTime = $"{DateTime.Now.ToString("hh:mm:ss")}";
        }

        private string _messageTime;
        private string _messageSource;
        private string _messageInfo;
    }
}
