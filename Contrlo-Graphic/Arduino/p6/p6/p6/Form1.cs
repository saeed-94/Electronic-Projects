using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p6
{
    public partial class Form1 : Form
    {
        public double a;
        public double b;
        public double c;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gaugeControl2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("1");
            textBox1.Text = serialPort1.ReadLine();
            a = Convert.ToDouble(textBox1.Text);
            gaugeControl1.SetPointerValue("Scale1", "Pointer1", a);
            serialPort1.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("2");
            textBox3.Text = serialPort1.ReadLine();
            b = Convert.ToDouble(textBox3.Text);
            gaugeControl2.SetPointerValue("Scale1", "Pointer1", b);
            serialPort1.Close();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("3");
            textBox2.Text = serialPort1.ReadLine();
            c = Convert.ToDouble(textBox2.Text);
            gaugeControl3.SetPointerValue("Scale1", "Pointer1", c);
            serialPort1.Close();
        }
    }
}
