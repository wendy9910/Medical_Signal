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
using System.IO;

namespace PC_RX
{
    public partial class Form1 : Form
    {
        StringBuilder res, resH;
        int iStart, iEnd, len, ii, i;
        byte[] buf;
        List<byte> raw;
        byte val;
        string s0;

        public Form1()
        {
            InitializeComponent();
        }
        private void getAllPorts()
        {
            comboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            foreach (string port in ports)
                comboBox.Items.Add(port);
            comboBox.SelectedIndex = comboBox.Items.Count - 1;//找最後一個COM6
        }

        private void displayRx() 
        {
            res.Clear();
            resH.Clear();
            iEnd = raw.Count-1;
            Text = string.Format("iStart({0})->iEnd({1})", iStart, iEnd); 
            while(iStart <= iEnd) 
            {
                val = raw[iStart++];
                s0 = string.Format("{0:x2}", val);
                resH.Append(s0);
                if(iStart % 20 == 0) 
                {
                    resH.AppendLine();
                }
                res.AppendFormat("{0}", (char)val);            
            }
            ShowText1.Text = res.ToString();
            ShowText2.Text = resH.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAllPorts();
            Size = new Size(800, 500);
        }

        private void GetPortbtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartRxbtn_Click(object sender, EventArgs e)
        {
            iStart = 0;
            iEnd = -1;
            ii = 0;
            StopRxbtn.Enabled = true;
            Savebtn.Enabled = false;
            raw.Clear();
            if (serialPort.IsOpen) 
            {
                serialPort.Close();
            }              
            serialPort.PortName = comboBox.SelectedItem.ToString();
            serialPort.Open();
            StartRxbtn.Enabled = false;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (StopRxbtn.Enabled) 
            {
                displayRx();
            }
        }

        private void StopRxbtn_Click(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }
}
