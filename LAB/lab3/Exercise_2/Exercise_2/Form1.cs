using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercise_2
{
    public partial class Form1 : Form
    {
        private Database1Entities db = new Database1Entities();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
           
            dataGridViewFaculties.DataSource = db.Faculties.ToList();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                int code = int.Parse(textBoxCode.Text);
                string name = textBoxName.Text;

                Faculty faculty = new Faculty
                {
                    Id = id,
                    Code = code,
                    NameFac = name
                };

                db.Faculties.Add(faculty);
                db.SaveChanges();
                MessageBox.Show("Faculty inserted successfully.");
                InitializeDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting faculty: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFaculties.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewFaculties.SelectedRows[0];

                int facultyId = (int)selectedRow.Cells["Id"].Value;
                Faculty facultyToDelete = db.Faculties.Find(facultyId);

                if (facultyToDelete != null)
                {
                    db.Faculties.Remove(facultyToDelete);
                    db.SaveChanges();

                    InitializeDataGridView();
                }
            }
        }
    }
}
