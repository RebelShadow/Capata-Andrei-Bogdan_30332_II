using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string path = "C:/facultate/an 3/sem 2/II/LAB/lab2/ex2/lab2_ex2/list.txt";
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string content = sr.ReadToEnd();
                    string[] lines = content.Split(';');
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            listBox1.Items.Add(line.Trim());
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found: " + path);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();

                listBox2.Items.Add(selectedItem);
            }
            else
            {
                MessageBox.Show("No item selected in listBox1.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected in listBox2.");
            }
        }
    }
}
