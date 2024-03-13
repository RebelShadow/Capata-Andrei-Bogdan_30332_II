using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string imagePath = "C:/facultate/an 3/sem 2/II/LAB/lab2/ex4/lab2_ex4/lab2_ex4/data/BMW.jpg";
            if (File.Exists(imagePath))
            {
                panel1.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image not found: " + imagePath);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string imagePath = "C:/facultate/an 3/sem 2/II/LAB/lab2/ex4/lab2_ex4/lab2_ex4/data/AUDI.jpg";
            if (File.Exists(imagePath))
            {
                panel1.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image not found: " + imagePath);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string imagePath = "C:/facultate/an 3/sem 2/II/LAB/lab2/ex4/lab2_ex4/lab2_ex4/data/Mercedes.jpg";
            if (File.Exists(imagePath))
            {
                panel1.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image not found: " + imagePath);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string imagePath = "C:/facultate/an 3/sem 2/II/LAB/lab2/ex4/lab2_ex4/lab2_ex4/data/Lancia.jpg";
            if (File.Exists(imagePath))
            {
                panel1.BackgroundImage = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image not found: " + imagePath);
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (Alba.Checked)
            {
                textBox1.Text = Alba.Text + " "+ textBox1.Text ;
            }
            if(Alba.Checked == false)
            {
                textBox1.Text = textBox1.Text.Replace("Alba", "").Trim();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bistrita_CheckedChanged(object sender, EventArgs e)
        {
            if (Bistrita.Checked)
            {
                textBox1.Text = Bistrita.Text+ " "+ textBox1.Text ;

            }
            if (Bistrita.Checked == false)
            {
                textBox1.Text = textBox1.Text.Replace("Bistrița", "").Trim();
            }
        }

        private void Targu_CheckedChanged(object sender, EventArgs e)
        {
            if (Targu.Checked)
            {
                textBox1.Text = Targu.Text + " " + textBox1.Text;

            }
            if (Targu.Checked == false)
            {
                textBox1.Text = textBox1.Text.Replace("Târgu", "").Trim();
            }
        }

        private void Nasaud_CheckedChanged(object sender, EventArgs e)
        {
            if (Nasaud.Checked)
            {
                textBox1.Text = textBox1.Text +" "+ Nasaud.Text;
            }
            if(Nasaud.Checked == false)
            {
                textBox1.Text = textBox1.Text.Replace("Năsăud", "").Trim();
            }
        }

        private void Mures_CheckedChanged(object sender, EventArgs e)
        {
            if (Mures.Checked)
            {
                textBox1.Text = textBox1.Text + " " + Mures.Text;
            }
            if (Mures.Checked == false)
            {
                textBox1.Text = textBox1.Text.Replace("Mureș", "").Trim();
            }

        }

        private void Iulia_CheckedChanged(object sender, EventArgs e)
        {
            if (Iulia.Checked)
            {
                textBox1.Text = textBox1.Text + " " + Iulia.Text;
            }
            if (Iulia.Checked == false)
            {
                textBox1.Text = textBox1.Text.Replace("Iulia", "").Trim();
            }

        }
    }
}
