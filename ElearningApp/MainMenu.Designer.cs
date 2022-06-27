namespace ElearningApp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.courseDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previewCourseButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.addCourseButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.deleteCourseButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.editCourseButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.28426F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.courseDGV, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.95491F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.04509F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(788, 377);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.editCourseButton);
            this.panel3.Controls.Add(this.deleteCourseButton);
            this.panel3.Controls.Add(this.addCourseButton);
            this.panel3.Controls.Add(this.previewCourseButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 72);
            this.panel3.TabIndex = 0;
            // 
            // courseDGV
            // 
            this.courseDGV.AllowUserToAddRows = false;
            this.courseDGV.AllowUserToDeleteRows = false;
            this.courseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CourseName,
            this.Teacher});
            this.courseDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseDGV.Location = new System.Drawing.Point(3, 81);
            this.courseDGV.Name = "courseDGV";
            this.courseDGV.ReadOnly = true;
            this.courseDGV.RowTemplate.Height = 25;
            this.courseDGV.Size = new System.Drawing.Size(782, 293);
            this.courseDGV.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CourseName
            // 
            this.CourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CourseName.DataPropertyName = "Name";
            this.CourseName.HeaderText = "Όνομα";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Teacher
            // 
            this.Teacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Teacher.DataPropertyName = "TeachersString";
            this.Teacher.HeaderText = "Καθηγητής/ες";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            // 
            // previewCourseButton
            // 
            this.previewCourseButton.Depth = 0;
            this.previewCourseButton.Icon = global::ElearningApp.Properties.Resources.icons8_view_48;
            this.previewCourseButton.Location = new System.Drawing.Point(714, 3);
            this.previewCourseButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.previewCourseButton.Name = "previewCourseButton";
            this.previewCourseButton.Size = new System.Drawing.Size(56, 56);
            this.previewCourseButton.TabIndex = 0;
            this.previewCourseButton.Text = "materialFloatingActionButton1";
            this.previewCourseButton.UseVisualStyleBackColor = true;
            this.previewCourseButton.Click += new System.EventHandler(this.previewCourseButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Depth = 0;
            this.addCourseButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_24;
            this.addCourseButton.Location = new System.Drawing.Point(528, 3);
            this.addCourseButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(56, 56);
            this.addCourseButton.TabIndex = 1;
            this.addCourseButton.Text = "materialFloatingActionButton2";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Depth = 0;
            this.deleteCourseButton.Icon = global::ElearningApp.Properties.Resources.icons8_delete_48;
            this.deleteCourseButton.Location = new System.Drawing.Point(652, 3);
            this.deleteCourseButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(56, 56);
            this.deleteCourseButton.TabIndex = 2;
            this.deleteCourseButton.Text = "materialFloatingActionButton3";
            this.deleteCourseButton.UseVisualStyleBackColor = true;
            this.deleteCourseButton.Click += new System.EventHandler(this.deleteCourseButton_Click);
            // 
            // editCourseButton
            // 
            this.editCourseButton.Depth = 0;
            this.editCourseButton.Icon = global::ElearningApp.Properties.Resources.icons8_edit_24;
            this.editCourseButton.Location = new System.Drawing.Point(590, 3);
            this.editCourseButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.editCourseButton.Name = "editCourseButton";
            this.editCourseButton.Size = new System.Drawing.Size(56, 56);
            this.editCourseButton.TabIndex = 3;
            this.editCourseButton.Text = "materialFloatingActionButton4";
            this.editCourseButton.UseVisualStyleBackColor = true;
            this.editCourseButton.Click += new System.EventHandler(this.editCourseButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MainMenu";
            this.Text = "Dashboard";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton editCourseButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton deleteCourseButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addCourseButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton previewCourseButton;
        private DataGridView courseDGV;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Teacher;
    }
}