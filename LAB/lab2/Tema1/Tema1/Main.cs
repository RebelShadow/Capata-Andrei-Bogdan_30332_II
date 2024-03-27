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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tema1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void removeCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Read all lines from the file
            string[] lines = System.IO.File.ReadAllLines(@"cars.txt");

            // Clear the ListView
            listView1.Items.Clear();

            // Add each line from the file as an item in the ListView
            foreach (string line in lines)
            {
                listView1.Items.Add(line);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Get the selected radio button
            var selectedRadioButton = C.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);

            // Get the checked checkboxes
            var checkedCheckBoxes = groupBox2.Controls.OfType<System.Windows.Forms.CheckBox>().Where(c => c.Checked);

            // Create a string with the radio button text and the checkbox texts
            string carData = selectedRadioButton.Text + ", " + string.Join(", ", checkedCheckBoxes.Select(c => c.Text));

            // Append the string to the file
            System.IO.File.AppendAllText(@"cars.txt", carData + Environment.NewLine);

            // Update the ListView
            listView1.Items.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"cars.txt");
            foreach (string line in lines)
            {
                listView1.Items.Add(line);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected item
                var selectedItem = listView1.SelectedItems[0];

                // Remove the selected item from the ListView
                listView1.Items.Remove(selectedItem);

                // Remove the selected item from the file
                List<string> lines = new List<string>(System.IO.File.ReadAllLines(@"cars.txt"));
                lines.Remove(selectedItem.Text);
                System.IO.File.WriteAllLines(@"cars.txt", lines.ToArray());
            }
        }
        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel1.Visible = false;


        }

        private void removeCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
