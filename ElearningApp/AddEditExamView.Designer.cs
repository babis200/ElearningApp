namespace ElearningApp
{
    partial class AddEditExamView
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
            this.maxGradeTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.descriptionLabel = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.minGradeTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.nameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.descriptionTextBox = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.88235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.11765F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 401);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 51);
            this.panel2.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(207, 6);
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
            this.panel1.Controls.Add(this.maxGradeTextBox);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.minGradeTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 338);
            this.panel1.TabIndex = 0;
            // 
            // maxGradeTextBox
            // 
            this.maxGradeTextBox.AnimateReadOnly = false;
            this.maxGradeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxGradeTextBox.Depth = 0;
            this.maxGradeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maxGradeTextBox.Hint = "Μεγ. Βαθμός";
            this.maxGradeTextBox.LeadingIcon = null;
            this.maxGradeTextBox.Location = new System.Drawing.Point(296, 256);
            this.maxGradeTextBox.MaxLength = 50;
            this.maxGradeTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.maxGradeTextBox.Multiline = false;
            this.maxGradeTextBox.Name = "maxGradeTextBox";
            this.maxGradeTextBox.Size = new System.Drawing.Size(195, 50);
            this.maxGradeTextBox.TabIndex = 4;
            this.maxGradeTextBox.Text = "";
            this.maxGradeTextBox.TrailingIcon = null;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Depth = 0;
            this.descriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionLabel.Location = new System.Drawing.Point(21, 90);
            this.descriptionLabel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(195, 19);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Περιγραφή διαγωνίσματος";
            // 
            // minGradeTextBox
            // 
            this.minGradeTextBox.AnimateReadOnly = false;
            this.minGradeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minGradeTextBox.Depth = 0;
            this.minGradeTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.minGradeTextBox.Hint = "Ελάχ. Βαθμός";
            this.minGradeTextBox.LeadingIcon = null;
            this.minGradeTextBox.Location = new System.Drawing.Point(21, 256);
            this.minGradeTextBox.MaxLength = 50;
            this.minGradeTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.minGradeTextBox.Multiline = false;
            this.minGradeTextBox.Name = "minGradeTextBox";
            this.minGradeTextBox.Size = new System.Drawing.Size(195, 50);
            this.minGradeTextBox.TabIndex = 2;
            this.minGradeTextBox.Text = "";
            this.minGradeTextBox.TrailingIcon = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.AnimateReadOnly = false;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.Hint = "Όνομα";
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(21, 26);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 50);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Depth = 0;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(21, 123);
            this.descriptionTextBox.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(470, 99);
            this.descriptionTextBox.TabIndex = 0;
            this.descriptionTextBox.Text = "";
            // 
            // AddEditExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditExamView";
            this.Text = "AddEditExamView";
            this.Load += new System.EventHandler(this.AddEditExamViewLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialButton saveButton;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox minGradeTextBox;
        private MaterialSkin2DotNet.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox descriptionTextBox;
        private MaterialSkin2DotNet.Controls.MaterialLabel descriptionLabel;
        private MaterialSkin2DotNet.Controls.MaterialTextBox maxGradeTextBox;
    }
}