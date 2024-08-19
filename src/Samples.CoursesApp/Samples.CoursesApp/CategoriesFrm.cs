using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Samples.CoursesApp
{
    public partial class CategoriesFrm : Form
    {
        DataTable categoriesTable = null;
        string categoryId = null;
        DataRow currentRow = null;
        public CategoriesFrm(DataSet ds)
        {
            InitializeComponent();
            this.categoriesTable = ds.Tables["Categories"];
            dgCategories.DataSource = categoriesTable;
        }

        private void mnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (currentRow == null)
            {
                try
                {
                    currentRow = categoriesTable.NewRow();
                    currentRow["Category"] = txtDescription.Text;
                    categoriesTable.Rows.Add(currentRow);
                    txtDescription.Text = string.Empty;
                    lblMsg.Text = "Row added!";
                    currentRow = null;
                }
                catch (ConstraintException)
                {
                    MessageBox.Show(txtDescription.Text + " Already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                currentRow.BeginEdit();
                currentRow["Category"] = txtDescription.Text;
                currentRow.EndEdit();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?","Delete current row",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                object id = dgCategories.CurrentRow.Cells["Id"].Value;
                DataRow dr = categoriesTable.Rows.Find(id);
                if (!dr.IsNull("Id") == true)
                {
                    dr.Delete();
                    lblMsg.Text = "Row delete";
                }
                else
                    MessageBox.Show("Cannot delete this record", "Deleted rows", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            object id = dgCategories.CurrentRow.Cells["Id"].Value;
            this.currentRow = categoriesTable.Rows.Find(id);
            if (!this.currentRow.IsNull("Id") == true)
            {
                txtDescription.Text = currentRow["Category"].ToString();
            }
        }

        private void dgCategories_SelectionChanged(object sender, EventArgs e)
        {
            object id = dgCategories.CurrentRow.Cells["Id"].Value;
            this.currentRow = categoriesTable.Rows.Find(id);
            if (!this.currentRow.IsNull("Id") == true)
            {
                txtDescription.Text = currentRow["Category"].ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDescription.Text = string.Empty;
            currentRow = null;
        }
    }
}
