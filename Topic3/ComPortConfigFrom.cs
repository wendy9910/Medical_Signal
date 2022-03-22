using System.Windows.Forms;
using System.IO.Ports;
namespace mySerialPort
{
    public partial class ComPortConfigFrom : Form
    {
        SerialPort SerialPort1;

        public ComPortConfigFrom()
        {
            InitializeComponent();
        }

        public ComPortConfigFrom(ref SerialPort sp)
        {
            InitializeComponent();
            ComPortConfig(ref sp);
        }

        public void ComPortConfig(ref SerialPort sp)
        {
            SerialPort1 = sp;
            String str;
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
            for (i = 0; i < combox2.Items.Count; i++)
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
                if (sp.Parity.ToString().Contains(str))
                {
                    comboBox4.SelectedIndex = i;
                    break;
                }
            }
            if (sp.DtrEnable)
                DTROn.Checked = true;
            else
                DTROff.Checked = true;

            if (sp.RtsEnable)
                RTSOff.Checked = true;
            else
                RTSOff.Checked = true;

            txtBx_ReadBufferSize.Text = sp.ReadBufferSize.ToString();

        }

        private void ComPortConfigFrom_Load(object snder, EventArgs e)
        {
            if (SerialPort1 == null)
            {
                MessageBox.Show("Bug in app!!");
            }
        }

        private void btnUpdateCom_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            SerialPort1.BaudRate = int.Parse(comboBox1.SelectedItem.ToString());
            SerialPort1.DataBits = int.Parse(comboBox2.SelectedItem.ToString());
            SerialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox3.SelectedItem.ToString(), true);
            SerialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox4.SelectedItem.ToString(), true);
            SerialPort1.ReadBufferSize = int.Parse(txtBx_ReadBufferSize.Text);
            SerialPort1.WriteBufferSize = int.Parse(txtBx_ReadBufferSize.Text);
            SerialPort1.DtrEnable = bool.Parse(DTROn.Checked.ToString());
            SerialPort1.RtsEnable = bool.Parse(RTSOn.Checked.ToString());
            Close();
        }

    }

}