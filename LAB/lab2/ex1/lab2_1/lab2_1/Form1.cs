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

namespace lab2_1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            String User = UserBox.Text;
            String Password = PasswordBox.Text;

            StreamReader sr = new StreamReader(path: "C:/facultate/an 3/sem 2/II/LAB/lab2/ex1/lab2_1/lab2_1/users.txt");
            if(User == sr.ReadLine() && Password == sr.ReadLine())
            {
                Welcomecs welcome = new Welcomecs();
                welcome.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

        }
    }
}
