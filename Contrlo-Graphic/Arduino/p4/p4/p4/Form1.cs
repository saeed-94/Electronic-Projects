using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p4
{
    public partial class Form1 : Form
    {
        public double a;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.Open();
            textBox1.Text=serialPort1.ReadLine();
            a= Convert.ToDouble(textBox1.Text);
            gaugeControl1.SetPointerValue("Scale1", "Pointer1",a);
            serialPort1.Close();
        }
    }
}
