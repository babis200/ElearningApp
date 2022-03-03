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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDataTable1 = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.updateButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.viewButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.addButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTable1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.50882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.49118F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialDataTable1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 377);
            this.panel1.TabIndex = 0;
            // 
            // materialDataTable1
            // 
            this.materialDataTable1.AllowUserToAddRows = false;
            this.materialDataTable1.AllowUserToDeleteRows = false;
            this.materialDataTable1.AllowUserToOrderColumns = true;
            this.materialDataTable1.AllowUserToResizeRows = false;
            this.materialDataTable1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.materialDataTable1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialDataTable1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialDataTable1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.materialDataTable1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTable1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.materialDataTable1.ColumnHeadersHeight = 56;
            this.materialDataTable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.materialDataTable1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CourseName,
            this.Teacher});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.materialDataTable1.DefaultCellStyle = dataGridViewCellStyle6;
            this.materialDataTable1.Depth = 0;
            this.materialDataTable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialDataTable1.EnableHeadersVisualStyles = false;
            this.materialDataTable1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialDataTable1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.materialDataTable1.Location = new System.Drawing.Point(0, 0);
            this.materialDataTable1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialDataTable1.Name = "materialDataTable1";
            this.materialDataTable1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataTable1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.materialDataTable1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDataTable1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.materialDataTable1.RowTemplate.Height = 52;
            this.materialDataTable1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialDataTable1.ShowVerticalScroll = false;
            this.materialDataTable1.Size = new System.Drawing.Size(665, 377);
            this.materialDataTable1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Κωδικός";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Όνομα";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Καθηγητής";
            this.Teacher.Name = "Teacher";
            this.Teacher.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.viewButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(674, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 377);
            this.panel2.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Depth = 0;
            this.deleteButton.Icon = global::ElearningApp.Properties.Resources.icons8_delete_48;
            this.deleteButton.Location = new System.Drawing.Point(33, 205);
            this.deleteButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(56, 56);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "materialFloatingActionButton4";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Depth = 0;
            this.updateButton.Icon = global::ElearningApp.Properties.Resources.icons8_edit_48;
            this.updateButton.Location = new System.Drawing.Point(33, 143);
            this.updateButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(56, 56);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "materialFloatingActionButton3";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Depth = 0;
            this.viewButton.Icon = global::ElearningApp.Properties.Resources.icons8_view_48;
            this.viewButton.Location = new System.Drawing.Point(33, 81);
            this.viewButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(56, 56);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "materialFloatingActionButton2";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Depth = 0;
            this.addButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_481;
            this.addButton.Location = new System.Drawing.Point(33, 19);
            this.addButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 56);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "materialFloatingActionButton1";
            this.addButton.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.materialDataTable1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton deleteButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton updateButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton viewButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addButton;
        private MaterialSkin2DotNet.Controls.MaterialDataTable materialDataTable1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Teacher;
    }
}