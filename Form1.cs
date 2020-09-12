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

namespace DigitalBenchPowerInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                portBox.Items.AddRange(SerialPort.GetPortNames());
                serialPort1.BaudRate = (9600);
                serialPort1.ReadTimeout = (2000);
                serialPort1.WriteTimeout = (2000);
                portBox.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CntBtn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = portBox.Text;
            serialPort1.Open();
            timer1.Start();
            
        }

        public void Readings()
        {
            try
            {
                textBox1.Text = serialPort1.ReadLine();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LiveReadings()
        {
            string in_data = textBox1.Text;
            string[] sensorData = in_data.Split(new char[] { '+' });
            List<string> tokens = new List<string>();
            foreach (string s in sensorData)
            {
                if (s.Length != 0)
                {
                    tokens.Add(s);
                }

            }

            votL.Text = tokens[0];
            curL.Text = tokens[1];
            freL.Text = tokens[2];

            circularPro.Value = Convert.ToInt32(tokens[0]);
            circularPro.Text = tokens[0];

            circularPro2.Value = Convert.ToInt32(tokens[1]);
            circularPro2.Text = tokens[1];

            circularPro3.Value = Convert.ToInt32(tokens[2]);
            circularPro3.Text = tokens[2];

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Stop();
            timer2.Stop();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Readings();
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            LiveReadings();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void VotL_Click(object sender, EventArgs e)
        {

        }
    }
}
