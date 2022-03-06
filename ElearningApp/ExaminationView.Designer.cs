namespace ElearningApp
{
    partial class ExaminationView
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
            this.saveAnsButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.exitButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.previousButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.nextButton = new MaterialSkin2DotNet.Controls.MaterialFloatingActionButton();
            this.completeButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.92271F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.07728F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 427);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.completeButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.saveAnsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 84);
            this.panel1.TabIndex = 1;
            // 
            // saveAnsButton
            // 
            this.saveAnsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveAnsButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveAnsButton.Depth = 0;
            this.saveAnsButton.HighEmphasis = true;
            this.saveAnsButton.Icon = null;
            this.saveAnsButton.Location = new System.Drawing.Point(516, 26);
            this.saveAnsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveAnsButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.saveAnsButton.Name = "saveAnsButton";
            this.saveAnsButton.Size = new System.Drawing.Size(158, 36);
            this.saveAnsButton.TabIndex = 1;
            this.saveAnsButton.Text = "save answer";
            this.saveAnsButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveAnsButton.UseAccentColor = false;
            this.saveAnsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(114, 26);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 36);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Abandon exam";
            this.exitButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Depth = 0;
            this.previousButton.Icon = global::ElearningApp.Properties.Resources.icons8_go_back_48;
            this.previousButton.Location = new System.Drawing.Point(15, 16);
            this.previousButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(56, 56);
            this.previousButton.TabIndex = 4;
            this.previousButton.Text = "materialFloatingActionButton1";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Depth = 0;
            this.nextButton.Icon = global::ElearningApp.Properties.Resources.icons8_forward_button_48;
            this.nextButton.Location = new System.Drawing.Point(717, 16);
            this.nextButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(56, 56);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "materialFloatingActionButton2";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // completeButton
            // 
            this.completeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.completeButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.completeButton.Depth = 0;
            this.completeButton.HighEmphasis = true;
            this.completeButton.Icon = null;
            this.completeButton.Location = new System.Drawing.Point(315, 26);
            this.completeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.completeButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(141, 36);
            this.completeButton.TabIndex = 6;
            this.completeButton.Text = "Complete Exam";
            this.completeButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.completeButton.UseAccentColor = false;
            this.completeButton.UseVisualStyleBackColor = true;
            // 
            // ExaminationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExaminationView";
            this.Text = "ExaminationView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton nextButton;
        private MaterialSkin2DotNet.Controls.MaterialFloatingActionButton previousButton;
        private MaterialSkin2DotNet.Controls.MaterialButton exitButton;
        private MaterialSkin2DotNet.Controls.MaterialButton saveAnsButton;
        private MaterialSkin2DotNet.Controls.MaterialButton completeButton;
    }
}