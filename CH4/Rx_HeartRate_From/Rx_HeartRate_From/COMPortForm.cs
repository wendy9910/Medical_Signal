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


namespace Rx_HeartRate_From
{
    public partial class COMPortForm : Form
    {
        public COMPortForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void COMPortForm_Load(object sender, EventArgs e)
        {

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
    }
}
