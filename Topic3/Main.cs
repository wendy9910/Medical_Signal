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
            res = new StringBuilder();
            resH = new 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAllPorts();
            Size = new Size(800, 85);
            raw = new List<byte>();
            sb = new StringBuilder();
        }

        private void btnGetPorts_Click(object sender, EventArgs e)
        {
        
        }
        pravite void timert_Tick(object sender, EventArgs e)
        {
            
        }
        pravite void serialPortR_DataReceived(object sender, SerialDataReceivedEventHandler e)
        {
           
        }
        pravite void btnStop_Click(object sender, EventArgs e)
        {
            
        }

        pravite void btnSave_Click(object sender, EventArgs e)
        {

        }

        pravite void btnClear_Click(object sender, EventArgs e)
        {

        }
        pravite void btnUpdateComR_Click(object sender, EventArgs e)
        {
            
        }
        
}