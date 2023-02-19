using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierceStat
{
    public class RsExchange
    {
        public delegate void MessageHandler(object source, MyMessageArgs e);
         private System.IO.Ports.SerialPort _rs_port;
        private PierceStat_Class.MessageHandler _messageHandler;
        private readonly int _readTimeout = 200; //ms
        private readonly int _writeTimeout = 200; //ms
        private readonly string _symbolEOL = "\n";
        private readonly int _baudRate = 115200;

        public RsExchange(int readTimeout, int writeTimeout, string symbolEOL, int baudRate, PierceStat_Class.MessageHandler messageHandler)
        {
            this._readTimeout = readTimeout;
            this._writeTimeout = writeTimeout;
            this._symbolEOL = symbolEOL;
            this._baudRate = baudRate;
            this._messageHandler = messageHandler;
        }

        public RsExchange(int baudRate, PierceStat_Class.MessageHandler messageHandler)
        {
            this._baudRate = baudRate;
            this._messageHandler = messageHandler;
        }

        public RsExchange(PierceStat_Class.MessageHandler messageHandler)
        {
            this._messageHandler = messageHandler;
        }

        //public void AddNewEventHandler 

        public bool WriteRs(string data)
        {
            try
            {
                _rs_port.WriteLine(data);
            }
            catch (System.Exception exc)
            {
                _messageHandler(this, new MyMessageArgs($"WriteRs(): {exc.Source}", exc.Message));
                return false;
            }
            return true;
        }

        public string ReadRs()
        {
            string data;
            try
            {
                data = _rs_port.ReadLine();
            }
            catch (System.Exception exc)
            {
                _messageHandler(this, new MyMessageArgs($"ReadRs(): {exc.Source}", exc.Message));
                return "";
            }
            return data;
        }

        public bool InitRs(string port, string key, string keyAnswer)
        {
            try
            {
                _rs_port = new System.IO.Ports.SerialPort(port, _baudRate, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One)
                {
                    ReadTimeout = _readTimeout,
                    WriteTimeout = _writeTimeout,
                    NewLine = _symbolEOL
                };
                _rs_port.Open();
                _rs_port.DiscardInBuffer();
                _rs_port.DiscardOutBuffer();
            }
            catch (System.Exception exc)
            {
                _messageHandler(this, new MyMessageArgs($"InitRs(): {exc.Source}", exc.Message));
                _rs_port = null;
                return false;
            }
            WriteRs(key);
            string answer = ReadRs();
            if (!answer.Contains(keyAnswer))
            {
                DisRs();
                _messageHandler(this, new MyMessageArgs($"InitRs()", "Проверьте правильность подключения устройства"));
                _rs_port = null;
                return false;
            }
            else
            {
                _messageHandler(this, new MyMessageArgs($"Connection", "Successfully connected to: " + answer));
                return true;
            }

        }
        public bool DisRs()
        {
            try
            {
                _rs_port.Close();
            }
            catch (System.Exception exc)
            {
                _messageHandler(this, new MyMessageArgs($"DisRs: {exc.Source}", exc.Message));
                return false;
            }
            _messageHandler(this, new MyMessageArgs($"Disconnection", "Successfully disconnected"));
            return true;
        }
    }
}
