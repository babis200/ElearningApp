namespace ElearningApp
{
    partial class AddEditSubjectView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox2();
            this.nameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addResourcesButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.addExamButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.examsLabel = new System.Windows.Forms.Label();
            this.resourcesLabel = new System.Windows.Forms.Label();
            this.examsDGV = new System.Windows.Forms.DataGridView();
            this.resourcesDGV = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.saveButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.resourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDGV)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 511);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.97608F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.02392F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 511);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(this.nameTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 193);
            this.panel2.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AnimateReadOnly = false;
            this.descriptionTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.descriptionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.descriptionTextBox.Depth = 0;
            this.descriptionTextBox.HideSelection = true;
            this.descriptionTextBox.Hint = "Περιγραφή κεφαλαίου";
            this.descriptionTextBox.Location = new System.Drawing.Point(16, 80);
            this.descriptionTextBox.MaxLength = 32767;
            this.descriptionTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.ReadOnly = false;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.SelectionLength = 0;
            this.descriptionTextBox.SelectionStart = 0;
            this.descriptionTextBox.ShortcutsEnabled = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(690, 88);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.TabStop = false;
            this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descriptionTextBox.UseSystemPasswordChar = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.HideSelection = true;
            this.nameTextBox.Hint = "Όνομα";
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(16, 16);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PrefixSuffixText = null;
            this.nameTextBox.ReadOnly = false;
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(690, 48);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TabStop = false;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameTextBox.TrailingIcon = null;
            this.nameTextBox.UseSystemPasswordChar = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addResourcesButton);
            this.panel3.Controls.Add(this.addExamButton);
            this.panel3.Controls.Add(this.examsLabel);
            this.panel3.Controls.Add(this.resourcesLabel);
            this.panel3.Controls.Add(this.examsDGV);
            this.panel3.Controls.Add(this.resourcesDGV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 238);
            this.panel3.TabIndex = 1;
            // 
            // addResourcesButton
            // 
            this.addResourcesButton.Depth = 0;
            this.addResourcesButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_24;
            this.addResourcesButton.Location = new System.Drawing.Point(284, 47);
            this.addResourcesButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addResourcesButton.Name = "addResourcesButton";
            this.addResourcesButton.Size = new System.Drawing.Size(56, 56);
            this.addResourcesButton.TabIndex = 7;
            this.addResourcesButton.Text = "materialFloatingActionButton1";
            this.addResourcesButton.UseVisualStyleBackColor = true;
            this.addResourcesButton.Click += new System.EventHandler(this.addResourcesButton_Click);
            // 
            // addExamButton
            // 
            this.addExamButton.Depth = 0;
            this.addExamButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_24;
            this.addExamButton.Location = new System.Drawing.Point(650, 47);
            this.addExamButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addExamButton.Name = "addExamButton";
            this.addExamButton.Size = new System.Drawing.Size(56, 56);
            this.addExamButton.TabIndex = 6;
            this.addExamButton.Text = "materialFloatingActionButton1";
            this.addExamButton.UseVisualStyleBackColor = true;
            this.addExamButton.Click += new System.EventHandler(this.addExamButton_Click);
            // 
            // examsLabel
            // 
            this.examsLabel.AutoSize = true;
            this.examsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.examsLabel.Location = new System.Drawing.Point(380, 14);
            this.examsLabel.Name = "examsLabel";
            this.examsLabel.Size = new System.Drawing.Size(151, 30);
            this.examsLabel.TabIndex = 5;
            this.examsLabel.Text = "Διαγώνισματα";
            // 
            // resourcesLabel
            // 
            this.resourcesLabel.AutoSize = true;
            this.resourcesLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resourcesLabel.Location = new System.Drawing.Point(16, 14);
            this.resourcesLabel.Name = "resourcesLabel";
            this.resourcesLabel.Size = new System.Drawing.Size(238, 30);
            this.resourcesLabel.TabIndex = 4;
            this.resourcesLabel.Text = "Περιεχόμενο κεφαλαίου";
            // 
            // examsDGV
            // 
            this.examsDGV.AllowUserToOrderColumns = true;
            this.examsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ExamName});
            this.examsDGV.Location = new System.Drawing.Point(380, 47);
            this.examsDGV.Name = "examsDGV";
            this.examsDGV.RowHeadersVisible = false;
            this.examsDGV.RowTemplate.Height = 25;
            this.examsDGV.Size = new System.Drawing.Size(250, 168);
            this.examsDGV.TabIndex = 2;
            // 
            // resourcesDGV
            // 
            this.resourcesDGV.AllowUserToOrderColumns = true;
            this.resourcesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourcesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path});
            this.resourcesDGV.Location = new System.Drawing.Point(16, 47);
            this.resourcesDGV.Name = "resourcesDGV";
            this.resourcesDGV.RowHeadersVisible = false;
            this.resourcesDGV.RowTemplate.Height = 25;
            this.resourcesDGV.Size = new System.Drawing.Size(250, 168);
            this.resourcesDGV.TabIndex = 3;
            this.resourcesDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resourcesDGV_CellDoubleClick);
            this.resourcesDGV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resourcesDGV_KeyDown);
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path.HeaderText = "θέση αρχείου";
            this.Path.Name = "Path";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.saveButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 446);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 62);
            this.panel4.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(305, 20);
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Κωδικός";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ExamName
            // 
            this.ExamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ExamName.DataPropertyName = "Name";
            this.ExamName.HeaderText = "Όνομα διαγωνίσματος";
            this.ExamName.Name = "ExamName";
            this.ExamName.ReadOnly = true;
            // 
            // AddEditSubjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 578);
            this.Controls.Add(this.panel1);
            this.Name = "AddEditSubjectView";
            this.Text = "AddEditSubjectView";
            this.Load += new System.EventHandler(this.AddEditSubjectView_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDGV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView resourcesDGV;
        private DataGridView examsDGV;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox2 descriptionTextBox;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 nameTextBox;
        private Panel panel3;
        private Panel panel4;
        private MaterialSkin2DotNet.Controls.MaterialButton saveButton;
        private Label examsLabel;
        private Label resourcesLabel;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addExamButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addResourcesButton;
        private DataGridViewTextBoxColumn Path;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ExamName;
        private OpenFileDialog resourceFileDialog;
    }
}