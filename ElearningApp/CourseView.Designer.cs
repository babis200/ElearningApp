namespace ElearningApp
{
    partial class CourseView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.courseNameLabel = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teachersLabel = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.courseSubjectsListView = new MaterialSkin2DotNet.Controls.MaterialListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionLabel = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.courseExamListView = new MaterialSkin2DotNet.Controls.MaterialListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.2376F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.76241F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Depth = 0;
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.courseNameLabel.Location = new System.Drawing.Point(23, 12);
            this.courseNameLabel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(96, 19);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teachersLabel);
            this.panel1.Controls.Add(this.courseNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 83);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 288);
            this.panel2.TabIndex = 2;
            // 
            // teachersLabel
            // 
            this.teachersLabel.AutoSize = true;
            this.teachersLabel.Depth = 0;
            this.teachersLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.teachersLabel.Location = new System.Drawing.Point(23, 55);
            this.teachersLabel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.teachersLabel.Name = "teachersLabel";
            this.teachersLabel.Size = new System.Drawing.Size(130, 19);
            this.teachersLabel.TabIndex = 1;
            this.teachersLabel.Text = "teacher1, teacher2";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.courseSubjectsListView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(788, 288);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // courseSubjectsListView
            // 
            this.courseSubjectsListView.AutoSizeTable = false;
            this.courseSubjectsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.courseSubjectsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseSubjectsListView.Depth = 0;
            this.courseSubjectsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseSubjectsListView.FullRowSelect = true;
            this.courseSubjectsListView.Location = new System.Drawing.Point(3, 3);
            this.courseSubjectsListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.courseSubjectsListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.courseSubjectsListView.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.courseSubjectsListView.Name = "courseSubjectsListView";
            this.courseSubjectsListView.OwnerDraw = true;
            this.courseSubjectsListView.Size = new System.Drawing.Size(388, 282);
            this.courseSubjectsListView.TabIndex = 0;
            this.courseSubjectsListView.UseCompatibleStateImageBehavior = false;
            this.courseSubjectsListView.View = System.Windows.Forms.View.List;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.courseExamListView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(397, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 282);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Depth = 0;
            this.descriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionLabel.Location = new System.Drawing.Point(25, 30);
            this.descriptionLabel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(79, 19);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "description";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.descriptionLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 135);
            this.panel3.TabIndex = 0;
            // 
            // courseExamListView
            // 
            this.courseExamListView.AutoSizeTable = false;
            this.courseExamListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.courseExamListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courseExamListView.Depth = 0;
            this.courseExamListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseExamListView.FullRowSelect = true;
            this.courseExamListView.Location = new System.Drawing.Point(3, 144);
            this.courseExamListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.courseExamListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.courseExamListView.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.courseExamListView.Name = "courseExamListView";
            this.courseExamListView.OwnerDraw = true;
            this.courseExamListView.Size = new System.Drawing.Size(382, 135);
            this.courseExamListView.TabIndex = 1;
            this.courseExamListView.UseCompatibleStateImageBehavior = false;
            this.courseExamListView.View = System.Windows.Forms.View.Details;
            // 
            // CourseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CourseView";
            this.Text = "CourseView";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel teachersLabel;
        private MaterialSkin2DotNet.Controls.MaterialLabel courseNameLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin2DotNet.Controls.MaterialListView courseSubjectsListView;
        private TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin2DotNet.Controls.MaterialListView courseExamListView;
        private Panel panel3;
        private MaterialSkin2DotNet.Controls.MaterialLabel descriptionLabel;
    }
}