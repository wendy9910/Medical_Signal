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

namespace COMPortForm
{
    public partial class GetComPort : Form
    {

        SerialPort serialPort1;
        public GetComPort()
        {
            InitializeComponent();
        }

        public GetComPort(ref SerialPort sp)
        {
            InitializeComponent();

            getAllPorts(ref sp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string getAllPorts(ref SerialPort sp)
        {
            serialPort1 = sp;
            cmbBxCOMPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames(); //get serialport的名字 COM3、COM4、COM6
            Array.Sort(ports);
            foreach (string port in ports)
                cmbBxCOMPort.Items.Add(port);
            cmbBxCOMPort.SelectedIndex = cmbBxCOMPort.Items.Count - 1;//找最後一個COM6
            string name = (string)cmbBxCOMPort.SelectedItem;

            return name;
        }

    }
}
