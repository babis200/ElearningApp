namespace ElearningApp
{
    partial class ExamView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectNameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.addExamButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.deleteExamButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.editExamButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.examsDGV = new System.Windows.Forms.DataGridView();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.selectButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsDGV)).BeginInit();
            this.selectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.examsDGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.selectPanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.34957F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.65043F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subjectNameTextBox);
            this.panel1.Controls.Add(this.addExamButton);
            this.panel1.Controls.Add(this.deleteExamButton);
            this.panel1.Controls.Add(this.editExamButton);
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
            this.subjectNameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.subjectNameTextBox.LeadingIcon = null;
            this.subjectNameTextBox.Location = new System.Drawing.Point(14, 9);
            this.subjectNameTextBox.MaxLength = 50;
            this.subjectNameTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.subjectNameTextBox.Multiline = false;
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(228, 50);
            this.subjectNameTextBox.TabIndex = 3;
            this.subjectNameTextBox.Text = "Τίτλος διαγωνίσματος";
            this.subjectNameTextBox.TrailingIcon = global::ElearningApp.Properties.Resources.icons8_search_24;
            this.subjectNameTextBox.TrailingIconClick += new System.EventHandler(this.subjectNameTextBox_TrailingIconClick);
            // 
            // addExamButton
            // 
            this.addExamButton.Depth = 0;
            this.addExamButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_481;
            this.addExamButton.Location = new System.Drawing.Point(569, 9);
            this.addExamButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addExamButton.Name = "addExamButton";
            this.addExamButton.Size = new System.Drawing.Size(56, 56);
            this.addExamButton.TabIndex = 2;
            this.addExamButton.Text = "materialFloatingActionButton3";
            this.addExamButton.UseVisualStyleBackColor = true;
            this.addExamButton.Click += new System.EventHandler(this.addExamButton_Click);
            // 
            // deleteExamButton
            // 
            this.deleteExamButton.Depth = 0;
            this.deleteExamButton.Icon = global::ElearningApp.Properties.Resources.icons8_delete_48;
            this.deleteExamButton.Location = new System.Drawing.Point(643, 9);
            this.deleteExamButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.deleteExamButton.Name = "deleteExamButton";
            this.deleteExamButton.Size = new System.Drawing.Size(56, 56);
            this.deleteExamButton.TabIndex = 1;
            this.deleteExamButton.Text = "materialFloatingActionButton2";
            this.deleteExamButton.UseVisualStyleBackColor = true;
            this.deleteExamButton.Click += new System.EventHandler(this.deleteExamButton_Click);
            // 
            // editExamButton
            // 
            this.editExamButton.Depth = 0;
            this.editExamButton.Icon = global::ElearningApp.Properties.Resources.icons8_edit_24;
            this.editExamButton.Location = new System.Drawing.Point(718, 9);
            this.editExamButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.editExamButton.Name = "editExamButton";
            this.editExamButton.Size = new System.Drawing.Size(56, 56);
            this.editExamButton.TabIndex = 0;
            this.editExamButton.Text = "materialFloatingActionButton1";
            this.editExamButton.UseVisualStyleBackColor = true;
            this.editExamButton.Click += new System.EventHandler(this.editExamButton_Click);
            // 
            // examsDGV
            // 
            this.examsDGV.AllowUserToAddRows = false;
            this.examsDGV.AllowUserToDeleteRows = false;
            this.examsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.MinGrade,
            this.MaxGrade});
            this.examsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.examsDGV.Location = new System.Drawing.Point(3, 74);
            this.examsDGV.Name = "examsDGV";
            this.examsDGV.ReadOnly = true;
            this.examsDGV.RowHeadersVisible = false;
            this.examsDGV.RowTemplate.Height = 25;
            this.examsDGV.Size = new System.Drawing.Size(788, 244);
            this.examsDGV.TabIndex = 2;
            // 
            // selectPanel
            // 
            this.selectPanel.Controls.Add(this.selectButton);
            this.selectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectPanel.Location = new System.Drawing.Point(3, 324);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(788, 56);
            this.selectPanel.TabIndex = 3;
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
            // MinGrade
            // 
            this.MinGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MinGrade.DataPropertyName = "MinGrade";
            this.MinGrade.HeaderText = "Ελάχιστος βαθμός";
            this.MinGrade.Name = "MinGrade";
            this.MinGrade.ReadOnly = true;
            // 
            // MaxGrade
            // 
            this.MaxGrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaxGrade.DataPropertyName = "MaxGrade";
            this.MaxGrade.HeaderText = "Μέγιστος βαθμός";
            this.MaxGrade.Name = "MaxGrade";
            this.MaxGrade.ReadOnly = true;
            // 
            // ExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExamView";
            this.Text = "ExamView";
            this.Load += new System.EventHandler(this.ExamView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examsDGV)).EndInit();
            this.selectPanel.ResumeLayout(false);
            this.selectPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox subjectNameTextBox;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addExamButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton deleteExamButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton editExamButton;
        private DataGridView examsDGV;
        private Panel selectPanel;
        private MaterialSkin2DotNet.Controls.MaterialButton selectButton;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn MinGrade;
        private DataGridViewTextBoxColumn MaxGrade;
    }
}