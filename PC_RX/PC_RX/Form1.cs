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
        SaveFileDialog saveFileDialog1;
        ///ComPortConfigForm setupComPort;

        public Form1()
        {
            InitializeComponent();
            ///setupComPort = new ComPortConfigForm();
        }
        private void getAllPorts()
        {
            comboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            foreach (string port in ports)
                comboBox.Items.Add(port);
            comboBox.SelectedIndex = comboBox.Items.Count - 1;//找最後一個COM6
            StartRxbtn.Enabled = true;
            serialPort1.PortName = comboBox.SelectedItem.ToString();
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
                s0 = string.Format("{0:X2}", val);
                resH.Append(s0);
                if(iStart % 20 == 0) 
                {
                    resH.AppendLine();
                }
                res.AppendFormat("{0}", (char)val);            
            }
            ShowText1.Text = resH.ToString();
            ShowText2.Text = res.ToString();
            Application.DoEvents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            res = new StringBuilder();
            resH = new StringBuilder();

            getAllPorts();
            Size = new Size(800, 500);
            raw = new List<byte>();
            buf = new byte[serialPort1.ReadBufferSize];
            
        }

        private void GetPortbtn_Click(object sender, EventArgs e)
        {
            getAllPorts();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartRxbtn_Click(object sender, EventArgs e)
        {

            iStart = 0;
            iEnd = -1;
            ii = 0;

            StartRxbtn.Enabled = true;
            Savebtn.Enabled = false;
            
            raw.Clear();
            if (serialPort1.IsOpen) 
            {
                serialPort1.Close();
            }              
            serialPort1.PortName = comboBox.SelectedItem.ToString();
            serialPort1.Open();
            StartRxbtn.Enabled = false;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (StopRxbtn.Enabled==false) 
            {
                displayRx();
            }
        }

        private void StopRxbtn_Click(object sender, EventArgs e)
        {
            StartRxbtn.Enabled = true;
            StopRxbtn.Enabled = false;
            if(raw.Count > 0)
                Savebtn.Enabled = true;
            serialPort1.Close();
            timer1.Stop();

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            saveFileDialog1.FileName = string.Format("Ardunio_{0:D4}{1:D2}{2:D2}_{3:D2}{4:D2}{5:D2}.txt",
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < raw.Count; i++)
                sb.Append((char)raw[i]);
            File.AppendAllText(saveFileDialog1.FileName, sb.ToString());

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            ShowText1.Text = "";
            ShowText2.Text = "";
            raw.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!StartRxbtn.Enabled && serialPort1.BytesToRead > 0) 
            {
                len = serialPort1.Read(buf, 0, buf.Length);
                i = 0;
                while (i < len)
                    raw.Add(buf[i++]);        
            }

        }
    }
}
