namespace ElearningApp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courseButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // courseButton
            // 
            this.courseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.courseButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.courseButton.Depth = 0;
            this.courseButton.HighEmphasis = true;
            this.courseButton.Icon = null;
            this.courseButton.Location = new System.Drawing.Point(118, 202);
            this.courseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.courseButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.courseButton.Name = "courseButton";
            this.courseButton.Size = new System.Drawing.Size(158, 36);
            this.courseButton.TabIndex = 0;
            this.courseButton.Text = "Courses";
            this.courseButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.courseButton.UseAccentColor = false;
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.courseButton);
            this.Name = "MainMenu";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialButton courseButton;
    }
}