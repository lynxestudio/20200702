namespace Samples.CoursesApp
{
    partial class CoursesAppFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.pnDown = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.gridCourses = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.pnDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.recordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(625, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnQuit
            // 
            this.mnQuit.Name = "mnQuit";
            this.mnQuit.Size = new System.Drawing.Size(107, 22);
            this.mnQuit.Text = "&Quit";
            this.mnQuit.Click += new System.EventHandler(this.mnQuit_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCategories,
            this.mnCourses});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.recordsToolStripMenuItem.Text = "&Catalogue";
            // 
            // mnCategories
            // 
            this.mnCategories.Name = "mnCategories";
            this.mnCategories.Size = new System.Drawing.Size(152, 22);
            this.mnCategories.Text = "C&ategories";
            this.mnCategories.Click += new System.EventHandler(this.mnCategories_Click);
            // 
            // mnCourses
            // 
            this.mnCourses.Name = "mnCourses";
            this.mnCourses.Size = new System.Drawing.Size(152, 22);
            this.mnCourses.Text = "Co&urses";
            this.mnCourses.Click += new System.EventHandler(this.mnCourses_Click);
            // 
            // pnDown
            // 
            this.pnDown.BackColor = System.Drawing.Color.White;
            this.pnDown.Controls.Add(this.btnAddCourse);
            this.pnDown.Controls.Add(this.btnSave);
            this.pnDown.Controls.Add(this.btnDelete);
            this.pnDown.Controls.Add(this.btnModify);
            this.pnDown.Controls.Add(this.gridCourses);
            this.pnDown.Controls.Add(this.statusStrip1);
            this.pnDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDown.Location = new System.Drawing.Point(0, 35);
            this.pnDown.Name = "pnDown";
            this.pnDown.Size = new System.Drawing.Size(625, 241);
            this.pnDown.TabIndex = 3;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(13, 187);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(359, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save changes to database";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(107, 187);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // gridCourses
            // 
            this.gridCourses.AllowUserToAddRows = false;
            this.gridCourses.AllowUserToDeleteRows = false;
            this.gridCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridCourses.Location = new System.Drawing.Point(0, 0);
            this.gridCourses.MultiSelect = false;
            this.gridCourses.Name = "gridCourses";
            this.gridCourses.ReadOnly = true;
            this.gridCourses.Size = new System.Drawing.Size(625, 173);
            this.gridCourses.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(625, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CoursesAppFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 276);
            this.Controls.Add(this.pnDown);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CoursesAppFrm";
            this.Text = "Courses App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoursesAppFrm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnDown.ResumeLayout(false);
            this.pnDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnQuit;
        private System.Windows.Forms.Panel pnDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView gridCourses;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnCategories;
        private System.Windows.Forms.ToolStripMenuItem mnCourses;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddCourse;
    }
}

