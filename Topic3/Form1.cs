using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
namespace SetArduinoLED
{
    public partial class Form1 : Form 
    {
        public Form1()
        {

        }
        bool bLED = false;
        int interval, iNow, len, i;
        List<byte> raw;
        byte[] buf;
        StringBuilder sb;

        private void getAllPorts() 
        {
            cmbBxCOMPort.Item.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            foreach (string port in ports)
                cmbBxCOMPort.Items.Add(port);
            cmbBxCOMPort.SelectedIndex = cmbBxCOMPort.Items.Count - 1;
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
            Size = new Size(800, 420);
            iNow = 0;
            buf = new byte[serialPort1_DataReceived.ReadBufferSize];
            serialPort1.Open();
            timer1_Tick.Start();
        }
        pravite void rdBtnon_Click(object sender,EventArgs e) 
        {
            getAllPorts();
        }
        pravite void rdBtnOFF_Click(object sender, EventArgs e)
        {
            if (!bLED) 
            {
                bLED = true;
                serialPort1.Write("1");
                rdBtnOn.ForeColor = Color.Blue;
                rdBtnOn.BackColor = Color.Yellow;
                rdBtnOFF.ForeColor = Color.Black;
                rdBtnOFF.BackColor = Color.White;
            }
        }
        pravite void rdBtnOFF_Click(object sender, EventArgs e)
        {
            if (bLED)
            {
                bLED = false;
                serialPort1.Write("0");
                rdBtnOn.ForeColor = Color.Yellow;
                rdBtnOn.BackColor = Color.Green;
                rdBtnOFF.ForeColor = Color.Green;
                rdBtnOFF.BackColor = Color.LightGray;
            }
        }

        pravite void btnSetIntrval_Click(object sender, EventArgs e)
        {
            serialPort1.Write(interval.ToString());
            bLED = true;
            rdBtnOn.Checked = true;
            rdBtnOn.ForeColor = Color.Blue;
            rdBtnOn.BackColor = Color.Yellow;
            rdBtnOFF.ForeColor = Color.Black;
            rdBtnOFF.BackColor = Color.White;
        }

        pravite void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.ISOpen)
                serialPort1.Close();
            Close();

        }
        pravite void clearMessageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtBxRxInfo.Text = "";
        }
        private void trackBar1_Scroll(object sender, EventArgs e) 
        {
            interval = (trackBar1.Value / trackBar1.TivkFrequency) * trackBar1.TickFrequency;
            IblInterval.Text = interval.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e) 
        {
            if(raw.Count > 0 && iNow < raw.Count)
            {
                sb.Clear();
                while (iNow < raw.Count)
                    sb.Append((char)raw[iNow++]);
                txtBxRxInfo.AppendText(sb.ToString());
            }
        }
        private void stopRxToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (serialPort1_DataReceived.IsOpen)
                serialPort1.Close();
            sb.Clear();
            timer1.Stop();
        
        }
        private void serialPort1_DataReceived(object sender, EventArgs e) 
        {
            if(serialPort1.BytesToRead > 0) 
            {
                len = serialPort1.Read(buf, 0, buf.Length);
                i = 0;
                while (i < len)
                    raw.Add(buf[i++]);
            }
        
        }
    }
   
}