using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mySerialPort;
using myTools;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace PC_RxPackedData6PlotDLL
{
    public partial class Form1 : Form
    {
        delegate void dispg();
        dispg DispG;
        int iStart, iEnd, len, len2, i, iR0, iR1;
        byte[] buf;
        List<byte> raw;
        List<int> iRaw;
        ComPortConfigForm setupComPort;
        double sigma = 1.0;
        int val,val2;
        myWaveBMP myWave, myWave2;
        Image img,img2;


        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!StartRx.Enabled && serialPort1.BytesToRead > 0)//if (!StartRx.Enabled && serialPort1.BytesToRead > 0)
            {
                len = serialPort1.Read(buf, 0, buf.Length);
                for (i = 0; i < len; i++) 
                {
                    raw.Add(buf[i]);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAllPorts();
            setupComPort = new ComPortConfigForm(ref serialPort1);
            raw = new List<byte>();
            iRaw = new List<int>();
            buf = new byte[serialPort1.ReadBufferSize];
            //DispG = new dispg(displayG);
 
        }

        private void UpdateComPort_Click(object sender, EventArgs e)
        {
            setupComPort.ComPortConfig(ref serialPort1);
            setupComPort.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToString();
            displayG();
            Application.DoEvents();
            showFiltering();
            Application.DoEvents();
        }

        private void GetPort_Click(object sender, EventArgs e)
        {
            getAllPorts();
        }

        private void StartRx_Click(object sender, EventArgs e)
        {
            iStart = 0;
            iEnd = -1;
            sigma = double.Parse(textBox1.Text);
            myTools.Filtering.initGaussian(sigma);
            len2 = Filtering.GaussianFilter.Length / 2;
            iR0 = 0;
            iR1 = -1;
            
            StopRx.Enabled = true;
            Save.Enabled = false;
            raw.Clear();
            myWave = new myTools.myWaveBMP(750);
            myWave2 = new myTools.myWaveBMP(750);
            if (img != null) 
            {
                img.Dispose();
                img = null;
            }
            //img = myWave.getBMP();
            //pictureBox1.Image = img;
            if (serialPort1.IsOpen)
                serialPort1.Close();
            serialPort1.PortName = cmbBxCOMPort.SelectedItem.ToString();
            serialPort1.Open();
            StartRx.Enabled = false;
            timer1.Start();
        }

        private void StopRx_Click(object sender, EventArgs e)
        {
            StartRx.Enabled = true;
            StopRx.Enabled = false;
            Save.Enabled = true;
            serialPort1.Close();
            timer1.Stop();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            SaveFileDialog1.FileName = string.Format("ECG_{0:D4}{1:D2}{2:D2}_{3:D2}{4:D2}{5:D2}.txt",
                DateTime.Now.Year, DateTime.Now.Month , DateTime.Now.Day,
                DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if (SaveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < raw.Count; i++) 
            {
                sb.AppendLine(raw[i].ToString());
            }
            File.AppendAllText(SaveFileDialog1.FileName, sb.ToString());

        }

        private void getAllPorts()
        {
            cmbBxCOMPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames(); //get serialport的名字 COM3、COM4、COM6
            Array.Sort(ports);
            foreach (string port in ports)
                cmbBxCOMPort.Items.Add(port);
            cmbBxCOMPort.SelectedIndex = cmbBxCOMPort.Items.Count - 1;//找最後一個COM6
            StartRx.Enabled = true;
            serialPort1.PortName = cmbBxCOMPort.SelectedItem.ToString();
        }

        private void displayG() 
        {
            iEnd = raw.Count - 1;
            while (iStart <= iEnd-5) 
            {
                if (raw[iStart] == 255 && raw[iStart + 1] == 255 && raw[iStart + 4] == 254 && raw[iStart + 5] == 254) 
                {
                    val = raw[iStart + 3] * 256 + raw[iStart + 2];
                    iRaw.Add(val);
                    myWave.update(val);
                    iStart += 5;
                }
                iStart++;
            }
            if (img != null) 
            {
                img.Dispose();
                img = null;
            }
            img = myWave.getBMP();
            pictureBox1.Image = img;

        }

        private void showFiltering() 
        {
            if (iRaw.Count < 1)
                return;
            iR1 = iRaw.Count - 1;
            if (iR0 < len2 + 1)
            {
                while (iR0 < len2 + 1)
                {
                    myWave2.update(iRaw[iR0]);
                    iR0++;
                }
            }
            else 
            {
                while (iR0 > len2 && iR1 - iR0 > 2 * len2) 
                {
                    val2 = (int)Filtering.doGaussian(iRaw, iR0);
                    myWave2.update(val2);
                    iR0++;
                }
            
            }
            if (img2 != null) 
            {
                img2.Dispose();
                img2 = null;
            }
            img2 = myWave2.getBMP();
            pictureBox2.Image = img2;
            Application.DoEvents();
        
        }
    }
}
