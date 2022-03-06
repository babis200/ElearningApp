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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.materialMultiLineTextBox1 = new MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox();
            this.nameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.gradingScaleTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.descriptionLabel = new MaterialSkin2DotNet.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.gradingScaleTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.materialMultiLineTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 338);
            this.panel1.TabIndex = 0;
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
            this.saveButton.Location = new System.Drawing.Point(236, 6);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 36);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(21, 123);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(470, 99);
            this.materialMultiLineTextBox1.TabIndex = 0;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Depth = 0;
            this.nameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameTextBox.Hint = "Name";
            this.nameTextBox.LeadingIcon = null;
            this.nameTextBox.Location = new System.Drawing.Point(21, 26);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 50);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "";
            this.nameTextBox.TrailingIcon = null;
            // 
            // gradingScaleTextBox
            // 
            this.gradingScaleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradingScaleTextBox.Depth = 0;
            this.gradingScaleTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gradingScaleTextBox.Hint = "Grading scale";
            this.gradingScaleTextBox.LeadingIcon = null;
            this.gradingScaleTextBox.Location = new System.Drawing.Point(21, 236);
            this.gradingScaleTextBox.MaxLength = 50;
            this.gradingScaleTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.gradingScaleTextBox.Multiline = false;
            this.gradingScaleTextBox.Name = "gradingScaleTextBox";
            this.gradingScaleTextBox.Size = new System.Drawing.Size(141, 50);
            this.gradingScaleTextBox.TabIndex = 2;
            this.gradingScaleTextBox.Text = "";
            this.gradingScaleTextBox.TrailingIcon = null;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Depth = 0;
            this.descriptionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.descriptionLabel.Location = new System.Drawing.Point(21, 90);
            this.descriptionLabel.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(81, 19);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // AddEditExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditExamView";
            this.Text = "AddEditExamView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialButton saveButton;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox gradingScaleTextBox;
        private MaterialSkin2DotNet.Controls.MaterialTextBox nameTextBox;
        private MaterialSkin2DotNet.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin2DotNet.Controls.MaterialLabel descriptionLabel;
    }
}