using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p3
{
    public partial class Form1 : Form
    {
        public Double a;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void gaugeControl1_Click(object sender, EventArgs e)
        {

        }

        private void gaugeControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("1");
            textBox1.Text = serialPort1.ReadLine();
           a= Convert.ToDouble(textBox1.Text);
            gaugeControl1.SetPointerValue("Scale1", "Pointer1",a );
            serialPort1.Close();

        }
    }
}
