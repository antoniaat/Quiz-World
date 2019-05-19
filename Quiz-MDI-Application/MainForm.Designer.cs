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
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AllowDrop = true;
            this.Login.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Login.BackgroundImage = global::Quiz_MDI_Application.Properties.Resources._17580;
            this.Login.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Image = global::Quiz_MDI_Application.Properties.Resources.btn_bg;
            this.Login.Location = new System.Drawing.Point(272, 219);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(158, 77);
            this.Login.TabIndex = 0;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // registerForm
            // 
            this.registerForm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.registerForm.BackgroundImage = global::Quiz_MDI_Application.Properties.Resources.quiz_app_background;
            this.registerForm.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerForm.Image = global::Quiz_MDI_Application.Properties.Resources.btn_bg;
            this.registerForm.Location = new System.Drawing.Point(456, 219);
            this.registerForm.Name = "registerForm";
            this.registerForm.Size = new System.Drawing.Size(157, 77);
            this.registerForm.TabIndex = 1;
            this.registerForm.Text = "REGISTER";
            this.registerForm.UseVisualStyleBackColor = false;
            this.registerForm.Click += new System.EventHandler(this.registerForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::Quiz_MDI_Application.Properties.Resources.home_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(895, 574);
            this.Controls.Add(this.registerForm);
            this.Controls.Add(this.Login);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "MainForm";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button registerForm;
    }
}

