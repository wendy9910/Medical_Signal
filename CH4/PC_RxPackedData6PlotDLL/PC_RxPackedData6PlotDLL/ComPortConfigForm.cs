 
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

namespace mySerialPort
{
    public partial class ComPortConfigForm : Form
    {

        SerialPort serialPort1;
        public ComPortConfigForm()
        {
            InitializeComponent();
        }

        public ComPortConfigForm(ref SerialPort sp)
        {
            InitializeComponent();

            ComPortConfig(ref sp);
        }

        public void ComPortConfig(ref SerialPort sp)
        {
            serialPort1 = sp;
            string str;
            int i;
            for (i = 0; i < comboBox1.Items.Count; i++)
            {
                str = comboBox1.Items[i].ToString();
                if (sp.BaudRate == int.Parse(str))
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
            }
            for (i = 0; i < comboBox2.Items.Count; i++)
            {
                str = comboBox2.Items[i].ToString();
                if (sp.DataBits == int.Parse(str))
                {
                    comboBox2.SelectedIndex = i;
                    break;
                }
            }
            for (i = 0; i < comboBox3.Items.Count; i++)
            {
                str = comboBox3.Items[i].ToString();
                if (sp.Parity.ToString().Contains(str))
                {
                    comboBox3.SelectedIndex = i;
                    break;
                }
            }
            for (i = 0; i < comboBox4.Items.Count; i++)
            {
                str = comboBox4.Items[i].ToString();
                if (sp.StopBits.ToString().Contains(str))
                {
                    comboBox4.SelectedIndex = i;
                    break;
                }
            }
            if (sp.DtrEnable)
            {
                dtrOn.Checked = true;
            }
            else
            {
                dtrOn.Checked = true;
            }
            if (sp.RtsEnable)
            {
                rtsOn.Checked = true;
            }
            else
            {
                rtsOff.Checked = true;
            }
            textBox1.Text = sp.ReadBufferSize.ToString();

        }
        private void ComPortConfigForm_Load(object sender, EventArgs e)
        {
            if (serialPort1 == null)
            {
                MessageBox.Show("Bug in app");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.BaudRate = int.Parse(comboBox1.SelectedItem.ToString());
            serialPort1.DataBits = int.Parse(comboBox2.SelectedItem.ToString());
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox3.SelectedItem.ToString(), true);
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox4.SelectedItem.ToString(), true);
            serialPort1.ReadBufferSize = int.Parse(textBox1.Text);
            serialPort1.WriteBufferSize = int.Parse(textBox1.Text);
            serialPort1.DtrEnable = bool.Parse(dtrOn.Checked.ToString());
            serialPort1.RtsEnable = bool.Parse(rtsOn.Checked.ToString());
            serialPort1.Open();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
