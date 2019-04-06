using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STM32LoadCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] allSerialComs = SerialPort.GetPortNames();
            comboBox1.DataSource = allSerialComs;

            comboBox1.SelectedItem = allSerialComs[0];
        }

        private void buttonLoadCode_Click(object sender, EventArgs e)
        {

            if(!File.Exists(textBoxHexPath.Text))
            {
                MessageBox.Show("Path not existed: " + textBoxHexPath.Text);
                return;
            }

            if (!textBoxHexPath.Text.ToUpper().Contains(".HEX"))
            {
                MessageBox.Show("Not a hex file!");
                return;
            }

            if (!serialPort1.IsOpen)
            {
                //serialPort1.Close();
                MessageBox.Show("Serial Port is not open!");
                return;
            }

            byte[] hexBin = File.ReadAllBytes(textBoxHexPath.Text);
            serialPort1.Write(hexBin, 0, hexBin.Length);
        }

        private void buttonConnectCOM_Click(object sender, EventArgs e)
        {
            if(!textBoxBaudrate.Enabled)
            {
                if(serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                textBoxBaudrate.Enabled = true;
                comboBox1.Enabled = true;
                buttonConnectCOM.Text = "Connect";
            }
            else
            {
                int baudRate;
                bool parse = int.TryParse(textBoxBaudrate.Text, out baudRate);
                if (!parse)
                {
                    MessageBox.Show("Baudrate error!");
                    return;
                }

                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = baudRate;

                serialPort1.Open();

                textBoxBaudrate.Enabled = false;
                comboBox1.Enabled = false;

                buttonConnectCOM.Text = "Cancel";
            }
        
        }
    }
}
