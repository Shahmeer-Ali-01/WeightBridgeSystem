using System.IO.Ports;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightBridgeSystem.Forms
{
    public partial class MachineCommunication : Form
    {
        public MachineCommunication()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MachineCommunication_Load(object sender, EventArgs e)
        {
            timerWeight.Enabled = false;
            cmbComPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();

            foreach(string PORT in ports)
            {
                cmbComPort.Items.Add(PORT);
            }
            if (cmbComPort.Items.Count > 0)
                cmbComPort.SelectedIndex = 0;
            cmbBaudRate.SelectedItem = "2400";
            cmbDataBits.SelectedItem = "8";
            cmbParity.SelectedItem = "None";
            cmbStopBits.SelectedItem = "1";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                serialPort1.PortName = cmbComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cmbDataBits.Text);
                switch(cmbParity.Text)
                {
                    case "Even":
                        serialPort1.Parity = Parity.Even;
                        break;
                    case "Odd":
                        serialPort1.Parity = Parity.Odd;
                        break;
                    case "Mark":
                        serialPort1.Parity = Parity.Mark;
                        break;
                    case "Space":
                        serialPort1.Parity = Parity.Space;
                        break;
                    default:
                        serialPort1.Parity = Parity.None;
                        break;
                }
                switch(cmbStopBits.Text)
                {
                    case "2":
                        serialPort1.StopBits = StopBits.Two;
                        break;
                    case "1.5":
                        serialPort1.StopBits = StopBits.OnePointFive;
                        break;
                    default:
                        serialPort1.StopBits = StopBits.One;
                        break;
                }
                serialPort1.Open();
                timerWeight.Start();
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = false;
                MessageBox.Show("Machine Connected Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timerWeight.Stop();
                serialPort1.Close();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                MessageBox.Show("Machine Disconnected");
            }
        }

        private void timerWeight_Tick(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    string data = serialPort1.ReadExisting();
                
                if (! string .IsNullOrWhiteSpace(data))
                
                    LiveWeight.CurrentWeight = data.Trim();
                }
            }
            catch
            {
            }
        }
        
    }
}
