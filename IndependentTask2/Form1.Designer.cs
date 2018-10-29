namespace IndependentTask2
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
            this.textBoxStudentAges = new System.Windows.Forms.TextBox();
            this.buttonCalculateOldest = new System.Windows.Forms.Button();
            this.labelOldest = new System.Windows.Forms.Label();
            this.labelAges = new System.Windows.Forms.Label();
            this.buttonRange = new System.Windows.Forms.Button();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.buttonYoungest = new System.Windows.Forms.Button();
            this.labelYoungest = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.labelAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStudentAges
            // 
            this.textBoxStudentAges.Location = new System.Drawing.Point(10, 28);
            this.textBoxStudentAges.Multiline = true;
            this.textBoxStudentAges.Name = "textBoxStudentAges";
            this.textBoxStudentAges.Size = new System.Drawing.Size(546, 97);
            this.textBoxStudentAges.TabIndex = 0;
            // 
            // buttonCalculateOldest
            // 
            this.buttonCalculateOldest.Location = new System.Drawing.Point(13, 139);
            this.buttonCalculateOldest.Name = "buttonCalculateOldest";
            this.buttonCalculateOldest.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateOldest.TabIndex = 1;
            this.buttonCalculateOldest.Text = "Oldest";
            this.buttonCalculateOldest.UseVisualStyleBackColor = true;
            this.buttonCalculateOldest.Click += new System.EventHandler(this.buttonCalculateOldest_Click);
            // 
            // labelOldest
            // 
            this.labelOldest.AutoSize = true;
            this.labelOldest.Location = new System.Drawing.Point(94, 144);
            this.labelOldest.Name = "labelOldest";
            this.labelOldest.Size = new System.Drawing.Size(67, 13);
            this.labelOldest.TabIndex = 2;
            this.labelOldest.Text = "No value yet";
            // 
            // labelAges
            // 
            this.labelAges.AutoSize = true;
            this.labelAges.Location = new System.Drawing.Point(13, 11);
            this.labelAges.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAges.Name = "labelAges";
            this.labelAges.Size = new System.Drawing.Size(71, 13);
            this.labelAges.TabIndex = 3;
            this.labelAges.Text = "Student Ages";
            // 
            // buttonRange
            // 
            this.buttonRange.Location = new System.Drawing.Point(10, 257);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(75, 23);
            this.buttonRange.TabIndex = 4;
            this.buttonRange.Text = "Range";
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(12, 218);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonTotal.TabIndex = 5;
            this.buttonTotal.Text = "Total";
            this.buttonTotal.UseVisualStyleBackColor = true;
            this.buttonTotal.Click += new System.EventHandler(this.buttonTotal_Click);
            // 
            // buttonYoungest
            // 
            this.buttonYoungest.Location = new System.Drawing.Point(13, 178);
            this.buttonYoungest.Name = "buttonYoungest";
            this.buttonYoungest.Size = new System.Drawing.Size(75, 23);
            this.buttonYoungest.TabIndex = 6;
            this.buttonYoungest.Text = "Youngest";
            this.buttonYoungest.UseVisualStyleBackColor = true;
            this.buttonYoungest.Click += new System.EventHandler(this.buttonYoungest_Click);
            // 
            // labelYoungest
            // 
            this.labelYoungest.AutoSize = true;
            this.labelYoungest.Location = new System.Drawing.Point(94, 183);
            this.labelYoungest.Name = "labelYoungest";
            this.labelYoungest.Size = new System.Drawing.Size(67, 13);
            this.labelYoungest.TabIndex = 7;
            this.labelYoungest.Text = "No value yet";
            this.labelYoungest.Click += new System.EventHandler(this.labelYoungest_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(94, 223);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(67, 13);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "No value yet";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(94, 262);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(67, 13);
            this.labelRange.TabIndex = 9;
            this.labelRange.Text = "No value yet";
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(9, 297);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(75, 23);
            this.buttonAverage.TabIndex = 10;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(94, 302);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(67, 13);
            this.labelAverage.TabIndex = 11;
            this.labelAverage.Text = "No value yet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 416);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelYoungest);
            this.Controls.Add(this.buttonYoungest);
            this.Controls.Add(this.buttonTotal);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.labelAges);
            this.Controls.Add(this.labelOldest);
            this.Controls.Add(this.buttonCalculateOldest);
            this.Controls.Add(this.textBoxStudentAges);
            this.Name = "Form1";
            this.Text = "Independent Task 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentAges;
        private System.Windows.Forms.Button buttonCalculateOldest;
        private System.Windows.Forms.Label labelOldest;
        private System.Windows.Forms.Label labelAges;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Button buttonYoungest;
        private System.Windows.Forms.Label labelYoungest;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Label labelAverage;
    }
}

