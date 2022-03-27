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
            this.tabControl = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            this.resourcesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectNameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.addResourceButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.deleteResourceButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.studyResourceButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.examsTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.takeExamButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.addExamButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.deleteExamButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.editExamButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.resourcesDGV = new System.Windows.Forms.DataGridView();
            this.examsDGV = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.resourcesTabPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.examsTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.resourcesTabPage);
            this.tabControl.Controls.Add(this.examsTabPage);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(794, 383);
            this.tabControl.TabIndex = 0;
            // 
            // resourcesTabPage
            // 
            this.resourcesTabPage.Controls.Add(this.tableLayoutPanel1);
            this.resourcesTabPage.Location = new System.Drawing.Point(4, 24);
            this.resourcesTabPage.Name = "resourcesTabPage";
            this.resourcesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resourcesTabPage.Size = new System.Drawing.Size(786, 355);
            this.resourcesTabPage.TabIndex = 0;
            this.resourcesTabPage.Text = "Resources";
            this.resourcesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resourcesDGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.34957F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.65043F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.subjectNameTextBox);
            this.panel1.Controls.Add(this.addResourceButton);
            this.panel1.Controls.Add(this.deleteResourceButton);
            this.panel1.Controls.Add(this.studyResourceButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 71);
            this.panel1.TabIndex = 1;
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectNameTextBox.Depth = 0;
            this.subjectNameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.subjectNameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.subjectNameTextBox.LeadingIcon = null;
            this.subjectNameTextBox.Location = new System.Drawing.Point(14, 9);
            this.subjectNameTextBox.MaxLength = 50;
            this.subjectNameTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.subjectNameTextBox.Multiline = false;
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(203, 50);
            this.subjectNameTextBox.TabIndex = 3;
            this.subjectNameTextBox.Text = "Τίτλος κεφαλαίου";
            this.subjectNameTextBox.TrailingIcon = global::ElearningApp.Properties.Resources.icons8_edit_24;
            this.subjectNameTextBox.TrailingIconClick += new System.EventHandler(this.subjectNameTextBox_TrailingIconClick);
            // 
            // addResourceButton
            // 
            this.addResourceButton.Depth = 0;
            this.addResourceButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_481;
            this.addResourceButton.Location = new System.Drawing.Point(553, 3);
            this.addResourceButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addResourceButton.Name = "addResourceButton";
            this.addResourceButton.Size = new System.Drawing.Size(56, 56);
            this.addResourceButton.TabIndex = 2;
            this.addResourceButton.Text = "materialFloatingActionButton3";
            this.addResourceButton.UseVisualStyleBackColor = true;
            this.addResourceButton.Click += new System.EventHandler(this.addResourceButton_Click);
            // 
            // deleteResourceButton
            // 
            this.deleteResourceButton.Depth = 0;
            this.deleteResourceButton.Icon = global::ElearningApp.Properties.Resources.icons8_delete_48;
            this.deleteResourceButton.Location = new System.Drawing.Point(627, 3);
            this.deleteResourceButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.deleteResourceButton.Name = "deleteResourceButton";
            this.deleteResourceButton.Size = new System.Drawing.Size(56, 56);
            this.deleteResourceButton.TabIndex = 1;
            this.deleteResourceButton.Text = "materialFloatingActionButton2";
            this.deleteResourceButton.UseVisualStyleBackColor = true;
            // 
            // studyResourceButton
            // 
            this.studyResourceButton.Depth = 0;
            this.studyResourceButton.Icon = global::ElearningApp.Properties.Resources.icons8_view_48;
            this.studyResourceButton.Location = new System.Drawing.Point(702, 3);
            this.studyResourceButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.studyResourceButton.Name = "studyResourceButton";
            this.studyResourceButton.Size = new System.Drawing.Size(56, 56);
            this.studyResourceButton.TabIndex = 0;
            this.studyResourceButton.Text = "materialFloatingActionButton1";
            this.studyResourceButton.UseVisualStyleBackColor = true;
            // 
            // examsTabPage
            // 
            this.examsTabPage.Controls.Add(this.tableLayoutPanel2);
            this.examsTabPage.Location = new System.Drawing.Point(4, 24);
            this.examsTabPage.Name = "examsTabPage";
            this.examsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.examsTabPage.Size = new System.Drawing.Size(786, 355);
            this.examsTabPage.TabIndex = 1;
            this.examsTabPage.Text = "Exams";
            this.examsTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.examsDGV, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.34957F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.65043F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(780, 349);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.takeExamButton);
            this.panel2.Controls.Add(this.addExamButton);
            this.panel2.Controls.Add(this.deleteExamButton);
            this.panel2.Controls.Add(this.editExamButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 71);
            this.panel2.TabIndex = 1;
            // 
            // takeExamButton
            // 
            this.takeExamButton.Depth = 0;
            this.takeExamButton.Icon = global::ElearningApp.Properties.Resources.icons8_quiz_50;
            this.takeExamButton.Location = new System.Drawing.Point(703, 3);
            this.takeExamButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.takeExamButton.Name = "takeExamButton";
            this.takeExamButton.Size = new System.Drawing.Size(56, 56);
            this.takeExamButton.TabIndex = 3;
            this.takeExamButton.Text = "materialFloatingActionButton1";
            this.takeExamButton.UseVisualStyleBackColor = true;
            this.takeExamButton.Click += new System.EventHandler(this.materialFloatingActionButton1_Click);
            // 
            // addExamButton
            // 
            this.addExamButton.Depth = 0;
            this.addExamButton.Icon = global::ElearningApp.Properties.Resources.icons8_add_481;
            this.addExamButton.Location = new System.Drawing.Point(481, 3);
            this.addExamButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.addExamButton.Name = "addExamButton";
            this.addExamButton.Size = new System.Drawing.Size(56, 56);
            this.addExamButton.TabIndex = 2;
            this.addExamButton.Text = "materialFloatingActionButton4";
            this.addExamButton.UseVisualStyleBackColor = true;
            this.addExamButton.Click += new System.EventHandler(this.addExamButton_Click);
            // 
            // deleteExamButton
            // 
            this.deleteExamButton.Depth = 0;
            this.deleteExamButton.Icon = global::ElearningApp.Properties.Resources.icons8_delete_48;
            this.deleteExamButton.Location = new System.Drawing.Point(555, 3);
            this.deleteExamButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.deleteExamButton.Name = "deleteExamButton";
            this.deleteExamButton.Size = new System.Drawing.Size(56, 56);
            this.deleteExamButton.TabIndex = 1;
            this.deleteExamButton.Text = "materialFloatingActionButton5";
            this.deleteExamButton.UseVisualStyleBackColor = true;
            this.deleteExamButton.Click += new System.EventHandler(this.deleteExamButton_Click);
            // 
            // editExamButton
            // 
            this.editExamButton.Depth = 0;
            this.editExamButton.Icon = global::ElearningApp.Properties.Resources.icons8_edit_24;
            this.editExamButton.Location = new System.Drawing.Point(630, 3);
            this.editExamButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.editExamButton.Name = "editExamButton";
            this.editExamButton.Size = new System.Drawing.Size(56, 56);
            this.editExamButton.TabIndex = 0;
            this.editExamButton.Text = "materialFloatingActionButton6";
            this.editExamButton.UseVisualStyleBackColor = true;
            // 
            // resourcesDGV
            // 
            this.resourcesDGV.AllowUserToAddRows = false;
            this.resourcesDGV.AllowUserToDeleteRows = false;
            this.resourcesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourcesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesDGV.Location = new System.Drawing.Point(3, 80);
            this.resourcesDGV.Name = "resourcesDGV";
            this.resourcesDGV.ReadOnly = true;
            this.resourcesDGV.RowTemplate.Height = 25;
            this.resourcesDGV.Size = new System.Drawing.Size(774, 266);
            this.resourcesDGV.TabIndex = 2;
            // 
            // examsDGV
            // 
            this.examsDGV.AllowUserToAddRows = false;
            this.examsDGV.AllowUserToDeleteRows = false;
            this.examsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.examsDGV.Location = new System.Drawing.Point(3, 80);
            this.examsDGV.Name = "examsDGV";
            this.examsDGV.ReadOnly = true;
            this.examsDGV.RowTemplate.Height = 25;
            this.examsDGV.Size = new System.Drawing.Size(774, 266);
            this.examsDGV.TabIndex = 3;
            // 
            // SubjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "SubjectView";
            this.Text = "SubjectView";
            this.Load += new System.EventHandler(this.SubjectView_Load);
            this.tabControl.ResumeLayout(false);
            this.resourcesTabPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.examsTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTabControl tabControl;
        private TabPage resourcesTabPage;
        private TabPage examsTabPage;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addResourceButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton deleteResourceButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton studyResourceButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addExamButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton deleteExamButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton editExamButton;
        private MaterialSkin2DotNet.Controls.MaterialTextBox subjectNameTextBox;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton takeExamButton;
        private DataGridView resourcesDGV;
        private DataGridView examsDGV;
    }
}