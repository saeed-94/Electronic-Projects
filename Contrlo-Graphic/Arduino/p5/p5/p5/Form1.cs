using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p5
{
    public partial class Form1 : Form
    {
         String red="0";
         String green="0";
         String blue="0";
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red=trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            green = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            blue = trackBar3.Value.ToString();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            textBox1.Text = red;
            textBox2.Text = green;
            textBox3.Text = blue;
            serialPort1.Write(red + "," + green + "," + blue);
            groupBox2.BackColor = Color.FromArgb(int.Parse(red), int.Parse(green), int.Parse(blue));
            serialPort1.Close();
        }
    }
}
