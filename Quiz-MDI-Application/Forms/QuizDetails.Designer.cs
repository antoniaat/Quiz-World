namespace Quiz_MDI_Application.Forms
{
    partial class QuizDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizDetails));
            this.SuspendLayout();
            // 
            // QuizDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_MDI_Application.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuizDetails";
            this.Text = "Quiz Details";
            this.Load += new System.EventHandler(this.QuestionDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}