using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Samples.CoursesApp
{
    public partial class CoursesAppFrm : Form
    {
        DataSet coursesDataSet;

        public CoursesAppFrm()
        {
            InitializeComponent();
            this.coursesDataSet = CoursesDac.GetData();
            //Bind the tables
            DataTable coursesTable = this.coursesDataSet.Tables["Courses"];
            gridCourses.DataSource = coursesTable;
        }

        private void mnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete Current Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Get the value of Id
                object id = this.gridCourses.CurrentRow.Cells["CourseId"].Value;
                //Find the datarow in the table
                DataRow currentRow = this.coursesDataSet.Tables["Courses"].Rows.Find(id);
                currentRow.Delete();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Get the value of id
            object id = this.gridCourses.CurrentRow.Cells["CourseId"].Value;
            //Find the datarow in the datatable
            DataRow currentRow = this.coursesDataSet.Tables["Courses"].Rows.Find(id);
            CoursesFrm coursesFrm = new CoursesFrm(coursesDataSet,currentRow);
            coursesFrm.ShowDialog(this);
        }

        private void mnCategories_Click(object sender, EventArgs e)
        {
            var categoriesFrm = new CategoriesFrm(this.coursesDataSet);
            categoriesFrm.ShowDialog();
        }

        private void mnCourses_Click(object sender, EventArgs e)
        {
            var coursesFrm = new CoursesFrm(this.coursesDataSet);
            coursesFrm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void CoursesAppFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (coursesDataSet.HasChanges())
            {
                DialogResult result = MessageBox.Show("Save your changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveChanges();
                }
            }
        }

        void SaveChanges()
        {
            if (this.coursesDataSet.HasErrors)
            {
                string errormessage = string.Empty;
                foreach (DataRow row in coursesDataSet.Tables["Courses"].Rows)
                {
                    if (row.HasErrors)
                    {
                        errormessage += string.Format("Error for Course {0}: {1}{2}",
                            row["CourseId", DataRowVersion.Original],
                            row.RowError,
                            Environment.NewLine);
                        row.ClearErrors();
                        row.RejectChanges();
                    }
                }
                MessageBox.Show(errormessage, "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!this.coursesDataSet.HasChanges())
            {
                MessageBox.Show("There are no changes to save.", "Save Changes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    DataSet changeDataSet = this.coursesDataSet.GetChanges();
                    //Save changes to the database (and get back an up-to-date DataSet)
                    CoursesDac.SaveData(ref changeDataSet);
                    //Merge any data updates
                    coursesDataSet.Merge(CoursesDac.GetData());
                    //Accept all changes
                    coursesDataSet.AcceptChanges();
                    MessageBox.Show("Data saved", "Save changes");
                }
                 catch (SqlException)
                {
                    MessageBox.Show("Data not saved.", "Save changes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            var coursesFrm = new CoursesFrm(this.coursesDataSet);
            coursesFrm.ShowDialog();
        }
    }
}
