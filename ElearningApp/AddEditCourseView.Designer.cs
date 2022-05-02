namespace ElearningApp
{
    partial class AddEditCourseView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addSubjectButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.subjectsLabel = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.subjectsListBox = new MaterialSkin2DotNet.Controls.MaterialListBox();
            this.teachersDGV = new System.Windows.Forms.DataGridView();
            this.TeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionLabel = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.descriptionMultiLineTextBox = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox();
            this.nameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.74756F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.252441F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 717);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 46);
            this.panel2.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(170, 6);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(118, 36);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Αποθήκευση";
            this.saveButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addSubjectButton);
            this.panel1.Controls.Add(this.subjectsLabel);
            this.panel1.Controls.Add(this.subjectsListBox);
            this.panel1.Controls.Add(this.teachersDGV);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.descriptionMultiLineTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 659);
            this.panel1.TabIndex = 0;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Depth = 0;
            this.addSubjectButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_24;
            this.addSubjectButton.Location = new System.Drawing.Point(336, 460);
            this.addSubjectButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(56, 56);
            this.addSubjectButton.TabIndex = 6;
            this.addSubjectButton.Text = "materialFloatingActionButton1";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // subjectsLabel
            // 
            this.subjectsLabel.AutoSize = true;
            this.subjectsLabel.Depth = 0;
            this.subjectsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subjectsLabel.Location = new System.Drawing.Point(56, 438);
            this.subjectsLabel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.subjectsLabel.Name = "subjectsLabel";
            this.subjectsLabel.Size = new System.Drawing.Size(72, 19);
            this.subjectsLabel.TabIndex = 5;
            this.subjectsLabel.Text = "Καφάλαια";
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.BackColor = System.Drawing.Color.White;
            this.subjectsListBox.BorderColor = System.Drawing.Color.LightGray;
            this.subjectsListBox.Depth = 0;
            this.subjectsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subjectsListBox.Location = new System.Drawing.Point(56, 460);
            this.subjectsListBox.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.SelectedIndex = -1;
            this.subjectsListBox.SelectedItem = null;
            this.subjectsListBox.Size = new System.Drawing.Size(255, 155);
            this.subjectsListBox.TabIndex = 4;
            // 
            // teachersDGV
            // 
            this.teachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherName});
            this.teachersDGV.Location = new System.Drawing.Point(56, 109);
            this.teachersDGV.Name = "teachersDGV";
            this.teachersDGV.RowHeadersVisible = false;
            this.teachersDGV.RowTemplate.Height = 25;
            this.teachersDGV.Size = new System.Drawing.Size(336, 150);
            this.teachersDGV.TabIndex = 3;
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherName.HeaderText = "Όνομα Καθηγητή";
            this.TeacherName.Name = "TeacherName";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Depth = 0;
            this.descriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionLabel.Location = new System.Drawing.Point(56, 277);
            this.descriptionLabel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(165, 19);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Περιγραφή μαθήματος";
            // 
            // descriptionMultiLineTextBox
            // 
            this.descriptionMultiLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descriptionMultiLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionMultiLineTextBox.Depth = 0;
            this.descriptionMultiLineTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionMultiLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionMultiLineTextBox.Location = new System.Drawing.Point(56, 299);
            this.descriptionMultiLineTextBox.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.descriptionMultiLineTextBox.Name = "descriptionMultiLineTextBox";
            this.descriptionMultiLineTextBox.Size = new System.Drawing.Size(336, 96);
            this.descriptionMultiLineTextBox.TabIndex = 1;
            this.descriptionMultiLineTextBox.Text = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.Hint = "Τίτλος μαθήματος";
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(56, 40);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(336, 50);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // AddEditCourseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 784);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditCourseView";
            this.Text = "CreateCourseView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialButton saveButton;
        private MaterialSkin2DotNet.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin2DotNet.Controls.MaterialLabel descriptionLabel;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox descriptionMultiLineTextBox;
        private DataGridView teachersDGV;
        private DataGridViewTextBoxColumn TeacherName;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addSubjectButton;
        private MaterialSkin2DotNet.Controls.MaterialLabel subjectsLabel;
        private MaterialSkin2DotNet.Controls.MaterialListBox subjectsListBox;
    }
}