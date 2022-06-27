namespace ElearningApp
{
    partial class SubjectView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.subjectsDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectNameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.addSubjectButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.deleteSubjectButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.editSubjectButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 56);
            this.panel2.TabIndex = 3;
            // 
            // selectButton
            // 
            this.selectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.selectButton.Depth = 0;
            this.selectButton.HighEmphasis = true;
            this.selectButton.Icon = null;
            this.selectButton.Location = new System.Drawing.Point(691, 14);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.selectButton.Name = "selectButton";
            this.selectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.selectButton.Size = new System.Drawing.Size(83, 36);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Επιλογή";
            this.selectButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.selectButton.UseAccentColor = false;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // subjectsDGV
            // 
            this.subjectsDGV.AllowUserToAddRows = false;
            this.subjectsDGV.AllowUserToDeleteRows = false;
            this.subjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Description});
            this.subjectsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectsDGV.Location = new System.Drawing.Point(3, 74);
            this.subjectsDGV.Name = "subjectsDGV";
            this.subjectsDGV.ReadOnly = true;
            this.subjectsDGV.RowHeadersVisible = false;
            this.subjectsDGV.RowTemplate.Height = 25;
            this.subjectsDGV.Size = new System.Drawing.Size(788, 244);
            this.subjectsDGV.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Κωδικός";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Name";
            this.Title.HeaderText = "Όνομα";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Περιγραφή";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subjectNameTextBox);
            this.panel1.Controls.Add(this.addSubjectButton);
            this.panel1.Controls.Add(this.deleteSubjectButton);
            this.panel1.Controls.Add(this.editSubjectButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 65);
            this.panel1.TabIndex = 1;
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.AnimateReadOnly = false;
            this.subjectNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectNameTextBox.Depth = 0;
            this.subjectNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subjectNameTextBox.Hint = "Τίτλος κεφαλαίου";
            this.subjectNameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.subjectNameTextBox.LeadingIcon = null;
            this.subjectNameTextBox.Location = new System.Drawing.Point(14, 9);
            this.subjectNameTextBox.MaxLength = 50;
            this.subjectNameTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.subjectNameTextBox.Multiline = false;
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(203, 50);
            this.subjectNameTextBox.TabIndex = 3;
            this.subjectNameTextBox.Text = "";
            this.subjectNameTextBox.TrailingIcon = global::ElearningApp.Properties.Resources.icons8_search_24;
            this.subjectNameTextBox.TrailingIconClick += new System.EventHandler(this.subjectNameTextBox_TrailingIconClick_1);
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Depth = 0;
            this.addSubjectButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_481;
            this.addSubjectButton.Location = new System.Drawing.Point(569, 9);
            this.addSubjectButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(56, 56);
            this.addSubjectButton.TabIndex = 2;
            this.addSubjectButton.Text = "materialFloatingActionButton3";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.addSubjectButton_Click);
            // 
            // deleteSubjectButton
            // 
            this.deleteSubjectButton.Depth = 0;
            this.deleteSubjectButton.Icon = global::ElearningApp.Properties.Resources.icons8_delete_48;
            this.deleteSubjectButton.Location = new System.Drawing.Point(643, 9);
            this.deleteSubjectButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.deleteSubjectButton.Name = "deleteSubjectButton";
            this.deleteSubjectButton.Size = new System.Drawing.Size(56, 56);
            this.deleteSubjectButton.TabIndex = 1;
            this.deleteSubjectButton.Text = "materialFloatingActionButton2";
            this.deleteSubjectButton.UseVisualStyleBackColor = true;
            this.deleteSubjectButton.Click += new System.EventHandler(this.deleteSubjectButton_Click);
            // 
            // editSubjectButton
            // 
            this.editSubjectButton.Depth = 0;
            this.editSubjectButton.Icon = global::ElearningApp.Properties.Resources.icons8_edit_24;
            this.editSubjectButton.Location = new System.Drawing.Point(718, 9);
            this.editSubjectButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.editSubjectButton.Name = "editSubjectButton";
            this.editSubjectButton.Size = new System.Drawing.Size(56, 56);
            this.editSubjectButton.TabIndex = 0;
            this.editSubjectButton.Text = "materialFloatingActionButton1";
            this.editSubjectButton.UseVisualStyleBackColor = true;
            this.editSubjectButton.Click += new System.EventHandler(this.editSubjectButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.subjectsDGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.34957F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.65043F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // SubjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SubjectView";
            this.Text = "Κεφάλαια";
            this.Load += new System.EventHandler(this.SubjectView_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialButton selectButton;
        private DataGridView subjectsDGV;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Description;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox subjectNameTextBox;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addSubjectButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton deleteSubjectButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton editSubjectButton;
        private TableLayoutPanel tableLayoutPanel1;
    }
}