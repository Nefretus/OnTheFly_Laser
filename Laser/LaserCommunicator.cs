using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using Flight.Properties;
using System.Threading;

namespace Flight {
    public enum LaserCommand {
        None,
        SetPower,
        GetPower,
        SetLaserOn,
        SetLaserOff,
        SetPulseRepetition,
        GetPulseRepetition,
        SetBurstSize,
        GetBurstSize,
        GetFaultStatus,
        SetPoDOn,
        SetPoDOff,
        SetPoDDivider,
        GetPoDDivider,
        GetPoDStatus
    }

    public sealed class LaserCommunicator {
        private static LaserCommunicator instance = null;
        private static readonly object padlock = new object();
        private SerialPort port = null;
        private string portName = Settings.Default.LaserSerialPort;
        private Dictionary<string, string> codes;
        public Queue<string> messages { get; set; } = new Queue<string>();

        public static LaserCommunicator Instance {
            get {
                lock (padlock) {
                    if (instance == null)
                        instance = new LaserCommunicator();
                    return instance;
                }
            }
        }

        public string PortName { 
            get {
                return portName;
            }
            set {
                portName = value;
                OnPortChanged();
            }
        }

        private void OnPortChanged() {
            if (port.IsOpen)
                port.Close();
            if(port != null)
                port.Dispose();
            InitPort();
        }

        private LaserCommunicator() {
            InitPort();
            codes = new Dictionary<string, string>() {
                {  "SetBurstSize", "*S1!BT00000n#"},
                {  "GetBurstSize","*S1?BT#"},
                {  "SetLaserOn", "*S1!ON000001#" }, 
                {  "SetLaserOff", "*S1!ON000000#"},
                {  "SetPulseRepetition", "*S1!PFaabbbb#"},
                {  "GetPulseRepetition", "*S1?PF#"},
                {  "SetPower", "*S1!AO00nnnn#" },
                {  "GetPower", "*S1?AO00nnnn#"},
                {  "GetFaultStatus", "*S0?FS#"},
                {  "SetPoDOn", "*S1!PB1#" },
                {  "SetPoDOff", "*S1!PB100001#"},
                {  "SetPoDDivider", "*S1!DPnnnnnn#" },
                {  "GetPoDDivider", "*S1?DPxxxxxx#" },
                {  "GetPoDStatus", "*S1?PBxxxxxx#" }

            };
            port.Open();
        }

        private void InitPort() {
            port = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
            port.Handshake = Handshake.None;
            port.DataReceived += SerialDataRecived;
        }

        private void SerialDataRecived(object sender, SerialDataReceivedEventArgs e) => messages.Enqueue(((SerialPort)sender).ReadLine());

        public static void ClearMessageQueue() => Instance.messages.Clear();

        public static void SendRequest(LaserCommand command) => Instance.SendRequestImpl(command);

        public static string GetAllMessages() => Instance.GetAllMessagesImpl();

        public static string GetMessage() => Instance.messages.Dequeue();
        public static bool CommandsExecutedSuccesfully() {
            if (!Instance.messages.Contains("NAK")) {
                ClearMessageQueue();
                SendRequest(LaserCommand.GetFaultStatus);
                return false;
            }
            return true;
        }

        public string GetAllMessagesImpl() {
            StringBuilder output = new StringBuilder();
            foreach(string code in messages)
                output.AppendLine(code);
            return output.ToString();
        }

        private void SendRequestImpl(LaserCommand command) {
            string terminalOutput = codes[command.ToString()];
            switch (command) {
                case LaserCommand.SetBurstSize:
                    terminalOutput.Replace("n", Settings.Default.BurstSize.ToString());
                    break;
                case LaserCommand.SetPower:
                    terminalOutput = "*S1!AO00" + String.Format("{0:0000}" ,(Settings.Default.LaserPower * 10)) + "#";
                    break;
                case LaserCommand.SetPulseRepetition:
                    terminalOutput = "*S1!PF0" + String.Format("{0:0.0000}", ((double)Settings.Default.PRF) / 1000) + "#"; 
                    break;
                case LaserCommand.SetPoDDivider:
                    terminalOutput = "*S1!DP" + String.Format("{0:000000}", Settings.Default.PoD * 1000) + "#";
                    break;
                default:
                    break;
            }
            try {
                port.Write(terminalOutput);
            }
            catch (Exception ex) {
                MessageBox.Show("Error opening/writing to serial port: " + ex.Message);
            }
        }
    }
}
