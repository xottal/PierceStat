using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierceStat
{
    public class RsExchange
    {
        public event ErrorHandler RsMessage;
        private System.IO.Ports.SerialPort rs_port;
        private readonly int readTimeout = 200; //ms
        private readonly int writeTimeout = 200; //ms
        private readonly string symbolEOL = "\n";
        private readonly int baudRate = 115200;

        public bool WriteRs(string data)
        {
            try
            {
                rs_port.WriteLine(data);
            }
            catch (System.Exception exc)
            {
                RsMessage?.Invoke(this, new MyErrorArgs($"{ DateTime.Now.ToString("hh:mm:ss") } Write Rs", exc.Message));
                return false;
            }
            return true;
        }

        public string ReadRs()
        {
            string data;
            try
            {
                data = rs_port.ReadLine();
            }
            catch (System.Exception exc)
            {
                RsMessage?.Invoke(this, new MyErrorArgs($"{ DateTime.Now.ToString("hh:mm:ss") } Read Rs", exc.Message));
                return "";
            }
            return data;
        }

        public bool InitRs(string port, string key, string keyAnswer)
        {
            try
            {
                rs_port = new System.IO.Ports.SerialPort(port, baudRate, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One)
                {
                    ReadTimeout = readTimeout,
                    WriteTimeout = writeTimeout,
                    NewLine = symbolEOL
                };
                rs_port.Open();
                rs_port.DiscardInBuffer();
                rs_port.DiscardOutBuffer();
            }
            catch (System.Exception exc)
            {
                RsMessage?.Invoke(this, new MyErrorArgs($"{ DateTime.Now.ToString("hh:mm:ss") } Connection", exc.Message));
                rs_port = null;
                return false;
            }
            WriteRs(key);
            string answer = ReadRs();
            if (!answer.Contains(keyAnswer))
            {
                DisRs();
                RsMessage?.Invoke(this, new MyErrorArgs($"{DateTime.Now.ToString("hh:mm:ss")} Connection", "Проверьте правильность подключения устройства"));
                rs_port = null;
                return false;
            }
            else
            {
                RsMessage?.Invoke(this, new MyErrorArgs($"{DateTime.Now.ToString("hh:mm:ss")} Connection", "Successfully connected to: " + answer));
                return true;
            }

        }
        public bool DisRs()
        {
            try
            {
                rs_port.Close();
            }
            catch (System.Exception exc)
            {
                RsMessage?.Invoke(this, new MyErrorArgs($"{ DateTime.Now.ToString("hh:mm:ss") } Disconnection", exc.Message));
                return false;
            }
            RsMessage?.Invoke(this, new MyErrorArgs($"{DateTime.Now.ToString("hh:mm:ss")} Disconnection", "Successfully disconnected"));
            return true;
        }
    }
}
