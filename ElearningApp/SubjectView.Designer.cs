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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subjectNameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.addResourceButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.deleteResourceButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.studyResourceButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.resourcesDGV = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resourcesDGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.34957F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.65043F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 383);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.panel1.Size = new System.Drawing.Size(788, 79);
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
            this.subjectNameTextBox.Size = new System.Drawing.Size(203, 50);
            this.subjectNameTextBox.TabIndex = 3;
            this.subjectNameTextBox.Text = "Τίτλος κεφαλαίου";
            this.subjectNameTextBox.TrailingIcon = global::ElearningApp.Properties.Resources.icons8_edit_24;
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
            // resourcesDGV
            // 
            this.resourcesDGV.AllowUserToAddRows = false;
            this.resourcesDGV.AllowUserToDeleteRows = false;
            this.resourcesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourcesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesDGV.Location = new System.Drawing.Point(3, 88);
            this.resourcesDGV.Name = "resourcesDGV";
            this.resourcesDGV.ReadOnly = true;
            this.resourcesDGV.RowTemplate.Height = 25;
            this.resourcesDGV.Size = new System.Drawing.Size(788, 292);
            this.resourcesDGV.TabIndex = 2;
            // 
            // SubjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SubjectView";
            this.Text = "SubjectView";
            this.Load += new System.EventHandler(this.SubjectView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox subjectNameTextBox;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton addResourceButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton deleteResourceButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton studyResourceButton;
        private DataGridView resourcesDGV;
    }
}