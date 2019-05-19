namespace Quiz_MDI_Application.Forms
{
    partial class CreateQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuizForm));
            this.loginFormTitle = new System.Windows.Forms.Label();
            this.quizNameLabel = new System.Windows.Forms.Label();
            this.quizNameTextBox = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginFormTitle
            // 
            this.loginFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginFormTitle.AutoSize = true;
            this.loginFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginFormTitle.CausesValidation = false;
            this.loginFormTitle.Font = new System.Drawing.Font("Calibri", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormTitle.Location = new System.Drawing.Point(35, 42);
            this.loginFormTitle.Name = "loginFormTitle";
            this.loginFormTitle.Size = new System.Drawing.Size(401, 83);
            this.loginFormTitle.TabIndex = 7;
            this.loginFormTitle.Text = "CREATE QUIZ";
            // 
            // quizNameLabel
            // 
            this.quizNameLabel.AutoSize = true;
            this.quizNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.quizNameLabel.Font = new System.Drawing.Font("Calibri", 15.8F);
            this.quizNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quizNameLabel.Location = new System.Drawing.Point(43, 150);
            this.quizNameLabel.Name = "quizNameLabel";
            this.quizNameLabel.Size = new System.Drawing.Size(142, 33);
            this.quizNameLabel.TabIndex = 9;
            this.quizNameLabel.Text = "Quiz Name:";
            // 
            // quizNameTextBox
            // 
            this.quizNameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizNameTextBox.Location = new System.Drawing.Point(49, 200);
            this.quizNameTextBox.Multiline = true;
            this.quizNameTextBox.Name = "quizNameTextBox";
            this.quizNameTextBox.Size = new System.Drawing.Size(350, 89);
            this.quizNameTextBox.TabIndex = 8;
            this.quizNameTextBox.TextChanged += new System.EventHandler(this.QuizNameTextBox);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.BackColor = System.Drawing.Color.Transparent;
            this.hoursLabel.Font = new System.Drawing.Font("Calibri", 15.8F);
            this.hoursLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hoursLabel.Location = new System.Drawing.Point(43, 321);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(87, 33);
            this.hoursLabel.TabIndex = 10;
            this.hoursLabel.Text = "Hours:";
            this.hoursLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 89);
            this.textBox1.TabIndex = 11;
            // 
            // CreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(35F, 82F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_MDI_Application.Properties.Resources._17580;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 664);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.quizNameLabel);
            this.Controls.Add(this.quizNameTextBox);
            this.Controls.Add(this.loginFormTitle);
            this.Font = new System.Drawing.Font("Calibri", 40.2F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.Name = "CreateQuizForm";
            this.Text = "Create Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginFormTitle;
        private System.Windows.Forms.Label quizNameLabel;
        private System.Windows.Forms.TextBox quizNameTextBox;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}