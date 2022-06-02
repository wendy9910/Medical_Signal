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

namespace Rx_HeartRate_From
{
    public partial class Form1 : Form
    {

        StringBuilder res;
        List<byte> raw;
        byte[] buf;
        int len,i, iEnd, iStart;
        byte val;
        string s0;
        public Form1()
        {
            InitializeComponent();
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
            Debug.Print(DateTime.Now.ToString());
            display();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            getAllPorts();
            raw = new List<byte>();
            res = new StringBuilder();
            buf = new Byte[serialPort1.ReadBufferSize];
            if (serialPort1.IsOpen) 
            {
            
            }
            //COMPortForm set = new COMPortForm();
            //set.Show();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
            if (serialPort1.BytesToRead > 0)
            {
                len = serialPort1.Read(buf, 0, buf.Length);
                raw.Clear();
                i = 0;
                while (i < len)
                    raw.Add(buf[i++]);
            }
           
        }

        private void getAllPorts() 
        {
            string[] ports = SerialPort.GetPortNames();
            serialPort1.PortName = ports[ports.Length-1];
        }

        private void display()
        {
            
            //iEnd = raw.Count - 1;
            //Text = string.Format("iStart({0})->iEnd({1})", iStart, iEnd);
            //while (iStart <= iEnd)
            //{
            //    val = raw[iStart++];                
            //    res.AppendFormat("{0}", (char)val);
            //}

            HRvalue.Text = serialPort1.ReadLine();
            //Debug.Print(res.ToString());
            //Application.DoEvents();
        }
    }
}
