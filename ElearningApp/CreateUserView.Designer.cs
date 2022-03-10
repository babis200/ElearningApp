namespace ElearningApp
{
    partial class CreateUserView
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
            this.materialCard1 = new MaterialSkin2DotNet.Controls.MaterialCard();
            this.roleComboBox = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            this.emailTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.passwordTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.usernameTextBox = new MaterialSkin2DotNet.Controls.MaterialTextBox();
            this.createButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.roleComboBox);
            this.materialCard1.Controls.Add(this.emailTextBox);
            this.materialCard1.Controls.Add(this.passwordTextBox);
            this.materialCard1.Controls.Add(this.usernameTextBox);
            this.materialCard1.Controls.Add(this.createButton);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 64);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(326, 401);
            this.materialCard1.TabIndex = 0;
            // 
            // roleComboBox
            // 
            this.roleComboBox.AutoResize = false;
            this.roleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roleComboBox.Depth = 0;
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.roleComboBox.DropDownHeight = 174;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.DropDownWidth = 121;
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.roleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Hint = "Role";
            this.roleComboBox.IntegralHeight = false;
            this.roleComboBox.ItemHeight = 43;
            this.roleComboBox.Location = new System.Drawing.Point(43, 228);
            this.roleComboBox.MaxDropDownItems = 4;
            this.roleComboBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(224, 49);
            this.roleComboBox.StartIndex = 0;
            this.roleComboBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Depth = 0;
            this.emailTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.emailTextBox.Hint = "Email";
            this.emailTextBox.LeadingIcon = null;
            this.emailTextBox.Location = new System.Drawing.Point(43, 163);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(224, 50);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Text = "";
            this.emailTextBox.TrailingIcon = null;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Depth = 0;
            this.passwordTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTextBox.Hint = "Password";
            this.passwordTextBox.LeadingIcon = null;
            this.passwordTextBox.Location = new System.Drawing.Point(43, 98);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(224, 50);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.TrailingIcon = null;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Depth = 0;
            this.usernameTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameTextBox.Hint = "Username";
            this.usernameTextBox.LeadingIcon = null;
            this.usernameTextBox.Location = new System.Drawing.Point(43, 33);
            this.usernameTextBox.MaxLength = 50;
            this.usernameTextBox.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(224, 50);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "";
            this.usernameTextBox.TrailingIcon = null;
            // 
            // createButton
            // 
            this.createButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.createButton.Depth = 0;
            this.createButton.HighEmphasis = true;
            this.createButton.Icon = null;
            this.createButton.Location = new System.Drawing.Point(118, 317);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.createButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(76, 36);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            this.createButton.UseAccentColor = false;
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 468);
            this.Controls.Add(this.materialCard1);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialCard materialCard1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox passwordTextBox;
        private MaterialSkin2DotNet.Controls.MaterialTextBox usernameTextBox;
        private MaterialSkin2DotNet.Controls.MaterialButton createButton;
        private MaterialSkin2DotNet.Controls.MaterialTextBox emailTextBox;
        private MaterialSkin2DotNet.Controls.MaterialComboBox roleComboBox;
    }
}