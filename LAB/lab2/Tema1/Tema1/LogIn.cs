using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "admin" && PasswordTextBox.Text == "admin")
            {
                MessageBox.Show("Autentificare reusita!");
                this.Hide();
                Main Main = new Main();
                Main.Show();

            }
            else
            {
                MessageBox.Show("Autentificare esuata!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
