namespace Samples.CoursesApp
{
    partial class CategoriesFrm
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
            this.pnDown = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgCategories = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDown
            // 
            this.pnDown.BackColor = System.Drawing.Color.LightGray;
            this.pnDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDown.Controls.Add(this.btnClose);
            this.pnDown.Controls.Add(this.btnDelete);
            this.pnDown.Controls.Add(this.dgCategories);
            this.pnDown.Controls.Add(this.statusStrip1);
            this.pnDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDown.Location = new System.Drawing.Point(0, 96);
            this.pnDown.Name = "pnDown";
            this.pnDown.Size = new System.Drawing.Size(323, 207);
            this.pnDown.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(239, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgCategories
            // 
            this.dgCategories.AllowUserToAddRows = false;
            this.dgCategories.AllowUserToDeleteRows = false;
            this.dgCategories.AllowUserToResizeColumns = false;
            this.dgCategories.AllowUserToResizeRows = false;
            this.dgCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgCategories.Location = new System.Drawing.Point(0, 0);
            this.dgCategories.MultiSelect = false;
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.Size = new System.Drawing.Size(321, 150);
            this.dgCategories.TabIndex = 1;
            this.dgCategories.SelectionChanged += new System.EventHandler(this.dgCategories_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 182);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(321, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(62, 18);
            this.lblMsg.Text = "Running";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnfile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 26);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnfile
            // 
            this.mnfile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnClose});
            this.mnfile.Name = "mnfile";
            this.mnfile.Size = new System.Drawing.Size(43, 22);
            this.mnfile.Text = "&File";
            // 
            // mnClose
            // 
            this.mnClose.Name = "mnClose";
            this.mnClose.Size = new System.Drawing.Size(119, 22);
            this.mnClose.Text = "&Close";
            this.mnClose.Click += new System.EventHandler(this.mnClose_Click);
            // 
            // tbMain
            // 
            this.tbMain.ColumnCount = 2;
            this.tbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tbMain.Controls.Add(this.label1, 0, 0);
            this.tbMain.Controls.Add(this.txtDescription, 1, 0);
            this.tbMain.Controls.Add(this.btnAccept, 1, 1);
            this.tbMain.Controls.Add(this.btnNew, 0, 1);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMain.Location = new System.Drawing.Point(0, 26);
            this.tbMain.Name = "tbMain";
            this.tbMain.RowCount = 2;
            this.tbMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbMain.Size = new System.Drawing.Size(323, 64);
            this.tbMain.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // txtDescription
            // 
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(99, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(221, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(99, 31);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "&Save";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // CategoriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(323, 303);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.pnDown);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CategoriesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courses App - Categories";
            this.pnDown.ResumeLayout(false);
            this.pnDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbMain.ResumeLayout(false);
            this.tbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDown;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnfile;
        private System.Windows.Forms.ToolStripMenuItem mnClose;
        private System.Windows.Forms.DataGridView dgCategories;
        private System.Windows.Forms.TableLayoutPanel tbMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
    }
}