using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using mySerialPort;
namespace PC_Rx
{
    public partial class Form1 : Form
    {

        StringBuilder res, resH;
        int iStarct, iEnd, len, ii;
        byte[] buf;
        List<byte> raw;
        int i;
        ComPortConfigForm setupComPort;
        byte val;
        string s0;

        private void getAllPorts()
        {
            cmbBxCOMPortR.Item.Clear();
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            foreach (string port in ports)
                cmbBxCOMPort.Items.Add(port);
            cmbBxCOMPort.SelectedIndex = cmbBxCOMPort.Items.Count - 1;
            btnStart.Enable = true;
            serialPortR_DataReceived.PortName = cmboBxPortR.SelectedItem.ToString();
        }

        private void displayRx()
        {
            res.Clear();
            resH.Clear();
            iEnd = raw.Count - 1;
            TextReader = string.Format("iStart({0})->iEnd({1})", iStart, iEnd);
            while (iStart <= iEnd) 
            {
                val = raw[iStart++];
                s0 = string.Format("{0:X2} ", val);
                resH.Append(s0);
                if (iStart % 20 == 0)
                    resH.AppendLine();
                res.AppendFormat("{0}", (char)val);

            }
            textBoxR.Text = resH.ToString();
            textBoxChar.Text = res.ToString();
            Application.DoEvents();

        }

        public Form1()
        {
            InitializeComponent();
            setupComPort = new ComPortConfigForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            res = new StringBuilder();
            resH = new StringBuilder();
            getAllPorts();
            raw = new List<byte>();
            buf = new byte[serialPortR_DataReceived.ReadBufferSize];
        }

        private void btnGetPorts_Click(object sender, EventArgs e)
        {
            getAllPorts();
        }
        pravite void timert_Tick(object sender, EventArgs e)
        {
            iStart = 0;
            iEnd = -1;
            ii = 0;
            btnStop.Enable = true;
            btnSave.Enable = false;
            raw.Clear();
            if (serialPortR.IsOpen)
                serialPortR.Close();
            serialPortR.PortName = cmboBxPortR.SelectedItem.ToString();
            serialPortR.Open();
            btnStart.Enabled = false;
            timer1.Start();
        }
        pravite void serialPortR_DataReceived(object sender, SerialDataReceivedEventHandler e)
        {
            if (!btnStart.Enabled && serialPortR_DataReceived.BytesToRead > 0) 
            {
                len = serialPortR_DataReceived.Read(buf, 0, buf.Length);
                i = 0;
                while (i < len)
                    raw.Add(buf[i++]);
            
            }
                
        }
        pravite void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            if (raw.Count > 0)
                btnSave.Enabled = true;
            serialPortR.Close();
            timer1.Stop();
        }

        pravite void btnSave_Click(object sender, EventArgs e)
        {
            serialPortR.Close();
            saveFileDialog1.FileName = string.Format("Arduino_{0:D4}{1:D2}{2:D2}_{3:D2}{4:D2}{5:D2}.txt",
                DataTime.Now.Year, DataTime.Now.Month, DataTime.Now.Day,
                DateTime.Now.Hour, DataTime.Now.Minute, DataTime.Now.Second);
            if (saveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            StringBuilder sb = new StringBuilder();
            for(int i = 0;i < raw.Count; i++) 
            {
                sb.Append((char)raaw[i]);
            }
            File.AppendAllText(saveFileDialog1.FileName, sb.ToString());
        }

        pravite void btnClear_Click(object sender, EventArgs e)
        {
            textBoxR.Text = "";
            textBoxChar.Text = "";
            raw.Clear();
        }
        pravite void btnUpdateComR_Click(object sender, EventArgs e)
        {
            setupComPort.ComPortConfig(ref serialPortR);
            setupComPort.ShowDialog();
            buf = null;
            buf = new byte[serialPortR.ReadBufferSize];
        }
        
}