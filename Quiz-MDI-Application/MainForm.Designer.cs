namespace Quiz_MDI_Application
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Login = new System.Windows.Forms.Button();
            this.registerForm = new System.Windows.Forms.Button();
            this.MainFormTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AllowDrop = true;
            this.Login.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Login.Font = new System.Drawing.Font("Calibri", 15F);
            this.Login.Location = new System.Drawing.Point(258, 249);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(129, 53);
            this.Login.TabIndex = 0;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // registerForm
            // 
            this.registerForm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.registerForm.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerForm.ForeColor = System.Drawing.Color.Black;
            this.registerForm.Location = new System.Drawing.Point(431, 249);
            this.registerForm.Name = "registerForm";
            this.registerForm.Size = new System.Drawing.Size(137, 53);
            this.registerForm.TabIndex = 1;
            this.registerForm.Text = "REGISTER";
            this.registerForm.UseVisualStyleBackColor = false;
            this.registerForm.Click += new System.EventHandler(this.registerForm_Click);
            // 
            // MainFormTitle
            // 
            this.MainFormTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MainFormTitle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MainFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainFormTitle.CausesValidation = false;
            this.MainFormTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.MainFormTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainFormTitle.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFormTitle.Location = new System.Drawing.Point(160, 116);
            this.MainFormTitle.Name = "MainFormTitle";
            this.MainFormTitle.Size = new System.Drawing.Size(514, 81);
            this.MainFormTitle.TabIndex = 2;
            this.MainFormTitle.Text = "QUIZ PLATFORM";
            this.MainFormTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::Quiz_MDI_Application.Properties.Resources.ranger_4df6c1b6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(823, 486);
            this.Controls.Add(this.MainFormTitle);
            this.Controls.Add(this.registerForm);
            this.Controls.Add(this.Login);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "MainForm";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button registerForm;
        private System.Windows.Forms.TextBox MainFormTitle;
    }
}

