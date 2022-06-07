using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using mySerialPort;
using COMPortForm;

namespace Rx_HeartRate_From
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        StringBuilder res;
        List<byte> raw;
        byte[] buf;
        int len,i;
        byte val;
        string s0;

        ComPortConfigForm setupComPort;
        GetComPort ComPort;

        public Form1()
        {
            InitializeComponent();
            ComPort = new GetComPort();
            setupComPort = new ComPortConfigForm();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {
            
        }

        private void HRvalue_Click(object sender, EventArgs e)
        {

        }
            
        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString();

            if (serialPort1.IsOpen)
            {
                display();
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

            serialPort1.PortName = (String)ComPort.getAllPorts(ref serialPort1);
            Debug.Print(serialPort1.PortName);
            raw = new List<byte>();
            res = new StringBuilder();
            buf = new Byte[serialPort1.ReadBufferSize];
            serialPort1.Open();
            if (serialPort1.IsOpen) 
            {
                Debug.Print("Open");
            }
            //COMPortForm set = new COMPortForm();
            //set.Show();
        }

        private void assignCOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setupComPort.ComPortConfig(ref serialPort1);
            setupComPort.ShowDialog();
            buf = null;
            buf = new Byte[serialPort1.ReadBufferSize];
            
        }

        private void configureCOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComPort.ShowDialog();
        }

        private void startRxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            serialPort1.Open();
        }

        private void stopRxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            raw.Clear();
            timer1.Stop();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            raw.Clear();
            if (serialPort1.BytesToRead > 0)
            {
                len = serialPort1.Read(buf, 0, buf.Length);
                i = 0;
                while (i < len)
                    raw.Add(buf[i++]);
            }
           
        }

     

        private void display()
        {
            res.Clear();
            for (int k = 0; k < raw.Count; k++) 
            {
                val = buf[k];
                s0 = string.Format("{0:X2}", val);
                res.AppendFormat("{0}", (char)val);
            }           
            HRvalue.Text = res.ToString();
            Application.DoEvents();
        }
    }
}
