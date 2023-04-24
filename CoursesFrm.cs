using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Samples.CoursesApp
{
    public partial class CoursesFrm : Form
    {
        DataSet coursesDataset;
        DataRow currentRow;
        string courseId;

        public CoursesFrm(DataSet ds)
        {
            InitializeComponent();
            this.coursesDataset = ds;
            this.currentRow = null;
            BindCategories(ds);
            
        }

        public CoursesFrm(DataSet ds, DataRow row)
        {
            InitializeComponent();
            this.coursesDataset = ds;
            BindCategories(ds);
            this.currentRow = row;
            courseId = currentRow["CourseId"].ToString();
            txtTitle.Text = currentRow["Title"].ToString();
            txtYear.Text = currentRow["CourseYear"].ToString();
            cbCategories.SelectedValue = currentRow["CategoryId"];
            cbCategories.Text = currentRow["Category"].ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable table = coursesDataset.Tables["Courses"];
            if (string.IsNullOrEmpty(txtTitle.Text))
                MessageBox.Show("Title cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (!IsANumber(txtYear.Text))
                    MessageBox.Show("Year must be a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    try
                    {
                        if (this.currentRow == null)
                        {
                            currentRow = table.NewRow();
                            currentRow["Title"] = txtTitle.Text;
                            table.Rows.Add(currentRow);
                        }
                        currentRow.BeginEdit();
                        //currentRow["CourseId"] = int.Parse(courseId);
                        currentRow["Title"] = txtTitle.Text;
                        if (!string.IsNullOrEmpty(txtYear.Text))
                            currentRow["CourseYear"] = txtYear.Text;
                        currentRow["CategoryId"] = cbCategories.SelectedValue;
                        currentRow["Category"] = cbCategories.Text;
                        currentRow.EndEdit();
                        this.Close();
                    }
                    catch (ApplicationException)
                    {
                        MessageBox.Show("An exception occurred.", "Courses App - Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
        }

        void BindCategories(DataSet ds)
        {
            DataTable categoriesTable = ds.Tables["Categories"];
            cbCategories.DataSource = categoriesTable;
            cbCategories.DisplayMember = "Category";
            cbCategories.ValueMember = "Id";
        }

        bool IsANumber(string s)
        {
            string pattern = @"^\d+$";
            if (Regex.Match(s, pattern).Success)
                return true;
            return false;
        }
    }
}
