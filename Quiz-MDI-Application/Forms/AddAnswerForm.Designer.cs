namespace Quiz_MDI_Application.Forms
{
    partial class AddAnswerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAnswerForm));
            this.answerTextBox = new System.Windows.Forms.RichTextBox();
            this.correctRadioButton = new System.Windows.Forms.RadioButton();
            this.notCorrectRadioButton = new System.Windows.Forms.RadioButton();
            this.addAnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(60, 75);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(976, 96);
            this.answerTextBox.TabIndex = 0;
            this.answerTextBox.Text = "";
            // 
            // correctRadioButton
            // 
            this.correctRadioButton.AutoSize = true;
            this.correctRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.correctRadioButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctRadioButton.Location = new System.Drawing.Point(60, 209);
            this.correctRadioButton.Name = "correctRadioButton";
            this.correctRadioButton.Size = new System.Drawing.Size(129, 33);
            this.correctRadioButton.TabIndex = 1;
            this.correctRadioButton.TabStop = true;
            this.correctRadioButton.Text = "Is Correct";
            this.correctRadioButton.UseVisualStyleBackColor = false;
            // 
            // notCorrectRadioButton
            // 
            this.notCorrectRadioButton.AutoSize = true;
            this.notCorrectRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.notCorrectRadioButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notCorrectRadioButton.Location = new System.Drawing.Point(60, 271);
            this.notCorrectRadioButton.Name = "notCorrectRadioButton";
            this.notCorrectRadioButton.Size = new System.Drawing.Size(177, 33);
            this.notCorrectRadioButton.TabIndex = 2;
            this.notCorrectRadioButton.TabStop = true;
            this.notCorrectRadioButton.Text = "Is NOT Correct";
            this.notCorrectRadioButton.UseVisualStyleBackColor = false;
            // 
            // addAnswerButton
            // 
            this.addAnswerButton.BackgroundImage = global::Quiz_MDI_Application.Properties.Resources.btn_bg;
            this.addAnswerButton.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnswerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addAnswerButton.Location = new System.Drawing.Point(60, 342);
            this.addAnswerButton.Name = "addAnswerButton";
            this.addAnswerButton.Size = new System.Drawing.Size(205, 72);
            this.addAnswerButton.TabIndex = 3;
            this.addAnswerButton.Text = "ADD ANSWER";
            this.addAnswerButton.UseVisualStyleBackColor = true;
            this.addAnswerButton.Click += new System.EventHandler(this.addAnswerButton_Click);
            // 
            // AddAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_MDI_Application.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1104, 664);
            this.Controls.Add(this.addAnswerButton);
            this.Controls.Add(this.notCorrectRadioButton);
            this.Controls.Add(this.correctRadioButton);
            this.Controls.Add(this.answerTextBox);
            this.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddAnswerForm";
            this.Text = "Add Answer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox answerTextBox;
        private System.Windows.Forms.RadioButton correctRadioButton;
        private System.Windows.Forms.RadioButton notCorrectRadioButton;
        private System.Windows.Forms.Button addAnswerButton;
    }
}