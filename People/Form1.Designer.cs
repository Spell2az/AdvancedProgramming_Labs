namespace People
{
    partial class Form1
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
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxDaysToBirthday = new System.Windows.Forms.TextBox();
            this.textBoxAgeInYears = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(17, 281);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(100, 28);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "Back";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(261, 281);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 28);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Forwards";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(17, 43);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(344, 22);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(17, 76);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(344, 22);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(17, 106);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(344, 22);
            this.textBoxDateOfBirth.TabIndex = 4;
            // 
            // textBoxDaysToBirthday
            // 
            this.textBoxDaysToBirthday.Location = new System.Drawing.Point(17, 173);
            this.textBoxDaysToBirthday.Name = "textBoxDaysToBirthday";
            this.textBoxDaysToBirthday.Size = new System.Drawing.Size(344, 22);
            this.textBoxDaysToBirthday.TabIndex = 5;
            // 
            // textBoxAgeInYears
            // 
            this.textBoxAgeInYears.Location = new System.Drawing.Point(17, 202);
            this.textBoxAgeInYears.Name = "textBoxAgeInYears";
            this.textBoxAgeInYears.Size = new System.Drawing.Size(344, 22);
            this.textBoxAgeInYears.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.textBoxAgeInYears);
            this.Controls.Add(this.textBoxDaysToBirthday);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxDaysToBirthday;
        private System.Windows.Forms.TextBox textBoxAgeInYears;
    }
}

