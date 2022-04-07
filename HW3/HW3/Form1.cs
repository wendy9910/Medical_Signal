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

namespace HW3
{
    public partial class Form1 : Form
    {
        bool bLED = false; //判定LED燈是否開
        int interval, iNow, len, i;
        List<byte> raw;
        byte[] buf;
        StringBuilder sb;
        bool stop = false;
                
        public Form1()
        {
            //初始化
            InitializeComponent(); 
        }

        private void getAllPorts() 
        {
            cmbBxCOMPort.Items.Clear(); 
            string[] ports = SerialPort.GetPortNames(); //get serialport的名字 COM3、COM4、COM6
            Array.Sort(ports);
            foreach (string port in ports)
                cmbBxCOMPort.Items.Add(port);
            cmbBxCOMPort.SelectedIndex = cmbBxCOMPort.Items.Count - 1;//找最後一個COM6
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getAllPorts();
            Size = new Size(800, 85);
            raw = new List<byte>();
            sb = new StringBuilder();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = (string)cmbBxCOMPort.SelectedItem;
            Size = new Size(800, 427);
            iNow = 0;
            buf = new byte[serialPort1.ReadBufferSize];
            serialPort1.Open();
            timer1.Start();
        }

        private void btnSetIntrval_Click(object sender, EventArgs e)
        {

        }
        private void getPortsToolStripMenuItem_Click(object sender, EventArgs e) //取得COM6
        {
            getAllPorts();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            Close();
        }
        //結束程式

        private void clearMessageToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            txtBxRxInfo.Text = "";
        }
        //清除訊息

        private void stopRxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            sb.Clear();
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            interval = (trackBar1.Value / trackBar1.TickFrequency) * trackBar1.TickFrequency;
            // 1250/100 *100
            lblInterval.Text = interval.ToString();
        }

        private void rdBtnOn_Click(object sender, EventArgs e)
        {
            bLED = true;
            if (serialPort1.IsOpen)
                serialPort1.Write("1");
            rdBtnOn.ForeColor = Color.Blue;
            rdBtnOn.BackColor = Color.Yellow;
            rdBtnOFF.ForeColor = Color.Black;
            rdBtnOFF.BackColor = Color.White;

        }

        private void rdBtnOFF_Click(object sender, EventArgs e)
        {
            bLED = false;
            if (serialPort1.IsOpen)
                serialPort1.Write("0");
            rdBtnOn.ForeColor = Color.Yellow;
            rdBtnOn.BackColor = Color.Green;
            rdBtnOFF.ForeColor = Color.Green;
            rdBtnOFF.BackColor = Color.LightGray;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                len = serialPort1.Read(buf, 0, buf.Length);
                i = 0;
                while (i < len)
                    raw.Add(buf[i++]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (raw.Count > 0 && iNow < raw.Count)
            {
                sb.Clear();
                while (iNow < raw.Count)
                    sb.Append((char)raw[iNow++]);
                txtBxRxInfo.AppendText(sb.ToString());
            }
        }

        

    }
}
