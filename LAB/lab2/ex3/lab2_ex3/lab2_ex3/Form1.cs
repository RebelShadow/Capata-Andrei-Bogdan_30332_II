using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(double.Parse(textBox1.Text) * double.Parse(textBox2.Text));

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            textBox3.Text=Convert.ToString(double.Parse(textBox1.Text)+double.Parse(textBox2.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(double.Parse(textBox1.Text) - double.Parse(textBox2.Text));

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(double.Parse(textBox1.Text) / double.Parse(textBox2.Text));

        }
    }
}
