using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("0");
            serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM1";
            serialPort1.BaudRate = 9600;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.Write("1");
            serialPort1.Close();
        }
    }
}
