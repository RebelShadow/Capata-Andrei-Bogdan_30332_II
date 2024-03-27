using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise_1
{
    public partial class Form1 : Form
    {
        private Database1Entities1 db = new Database1Entities1();

        public Form1()
        {
            InitializeComponent();
            LoadUniversities();
        }

        private void LoadUniversities()
        {
            var universities = db.Universities.ToList();
            listBoxUniversities.DisplayMember = "NameUniv";
            listBoxUniversities.ValueMember = "Id";
            listBoxUniversities.DataSource = universities;
        }

        private void listBoxUniversities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUniversities.SelectedIndex != -1)
            {
                University selectedUniversity = (University)listBoxUniversities.SelectedItem;
                textBoxId.Text = selectedUniversity.Id.ToString();
                textBoxName.Text = selectedUniversity.NameUniv;
                textBoxCity.Text = selectedUniversity.City;
                textBoxCode.Text = selectedUniversity.Code.ToString();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                string name = textBoxName.Text;
                string city = textBoxCity.Text;
                int code = int.Parse(textBoxCode.Text);

                University university = new University
                {
                    Id = id,
                    NameUniv = name,
                    City = city,
                    Code = code
                };

                db.Universities.Add(university);
                db.SaveChanges();
                MessageBox.Show("University inserted successfully.");
                LoadUniversities(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting university: " + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(textBoxCode.Text);
                University university = db.Universities.FirstOrDefault(u => u.Code == code);
                if (university != null)
                {
                    university.NameUniv = textBoxName.Text;
                    university.City = textBoxCity.Text;
                    university.Code = int.Parse(textBoxCode.Text);

                    db.Entry(university).State = EntityState.Modified; 

                    db.SaveChanges();
                    MessageBox.Show("University updated successfully.");
                    LoadUniversities(); 
                }
                else
                {
                    MessageBox.Show("University not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating university: " + ex.Message);
                
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(textBoxCode.Text);
                University university = db.Universities.FirstOrDefault(u => u.Code == code);
                if (university != null)
                {
                    db.Universities.Remove(university);
                    db.SaveChanges();
                    MessageBox.Show("University deleted successfully.");
                    LoadUniversities(); 
                }
                else
                {
                    MessageBox.Show("University not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting university: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}