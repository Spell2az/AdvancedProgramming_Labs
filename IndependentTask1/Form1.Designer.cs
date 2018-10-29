namespace IndependentTask1
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
            this.numericUpDownNumber1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumber2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumber3 = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculateLargestValue = new System.Windows.Forms.Button();
            this.labelLargestValue = new System.Windows.Forms.Label();
            this.buttonCalculateSmallest = new System.Windows.Forms.Button();
            this.buttonCalculateAverage = new System.Windows.Forms.Button();
            this.buttonCalculateRange = new System.Windows.Forms.Button();
            this.Values = new System.Windows.Forms.Label();
            this.labelSmallestValue = new System.Windows.Forms.Label();
            this.labelAverageValue = new System.Windows.Forms.Label();
            this.labelRangeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber3)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumber1
            // 
            this.numericUpDownNumber1.Location = new System.Drawing.Point(84, 37);
            this.numericUpDownNumber1.Name = "numericUpDownNumber1";
            this.numericUpDownNumber1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumber1.TabIndex = 0;
            // 
            // numericUpDownNumber2
            // 
            this.numericUpDownNumber2.Location = new System.Drawing.Point(229, 37);
            this.numericUpDownNumber2.Name = "numericUpDownNumber2";
            this.numericUpDownNumber2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumber2.TabIndex = 1;
            // 
            // numericUpDownNumber3
            // 
            this.numericUpDownNumber3.Location = new System.Drawing.Point(377, 37);
            this.numericUpDownNumber3.Name = "numericUpDownNumber3";
            this.numericUpDownNumber3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumber3.TabIndex = 2;
            // 
            // buttonCalculateLargestValue
            // 
            this.buttonCalculateLargestValue.Location = new System.Drawing.Point(84, 115);
            this.buttonCalculateLargestValue.Name = "buttonCalculateLargestValue";
            this.buttonCalculateLargestValue.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateLargestValue.TabIndex = 3;
            this.buttonCalculateLargestValue.Text = "Largest";
            this.buttonCalculateLargestValue.UseVisualStyleBackColor = true;
            this.buttonCalculateLargestValue.Click += new System.EventHandler(this.buttonCalculateLargestValue_Click);
            // 
            // labelLargestValue
            // 
            this.labelLargestValue.AutoSize = true;
            this.labelLargestValue.Location = new System.Drawing.Point(194, 120);
            this.labelLargestValue.Name = "labelLargestValue";
            this.labelLargestValue.Size = new System.Drawing.Size(94, 13);
            this.labelLargestValue.TabIndex = 4;
            this.labelLargestValue.Text = "Not yet Calculated";
            // 
            // buttonCalculateSmallest
            // 
            this.buttonCalculateSmallest.Location = new System.Drawing.Point(84, 144);
            this.buttonCalculateSmallest.Name = "buttonCalculateSmallest";
            this.buttonCalculateSmallest.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateSmallest.TabIndex = 5;
            this.buttonCalculateSmallest.Text = "Smallest";
            this.buttonCalculateSmallest.UseVisualStyleBackColor = true;
            this.buttonCalculateSmallest.Click += new System.EventHandler(this.buttonCalculateSmallest_Click);
            // 
            // buttonCalculateAverage
            // 
            this.buttonCalculateAverage.Location = new System.Drawing.Point(84, 173);
            this.buttonCalculateAverage.Name = "buttonCalculateAverage";
            this.buttonCalculateAverage.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateAverage.TabIndex = 6;
            this.buttonCalculateAverage.Text = "Average";
            this.buttonCalculateAverage.UseVisualStyleBackColor = true;
            this.buttonCalculateAverage.Click += new System.EventHandler(this.buttonCalculateAverage_Click);
            // 
            // buttonCalculateRange
            // 
            this.buttonCalculateRange.Location = new System.Drawing.Point(84, 202);
            this.buttonCalculateRange.Name = "buttonCalculateRange";
            this.buttonCalculateRange.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateRange.TabIndex = 7;
            this.buttonCalculateRange.Text = "Range";
            this.buttonCalculateRange.UseVisualStyleBackColor = true;
            this.buttonCalculateRange.Click += new System.EventHandler(this.buttonCalculateRange_Click);
            // 
            // Values
            // 
            this.Values.AutoSize = true;
            this.Values.Location = new System.Drawing.Point(81, 9);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(39, 13);
            this.Values.TabIndex = 8;
            this.Values.Text = "Values";
            // 
            // labelSmallestValue
            // 
            this.labelSmallestValue.AutoSize = true;
            this.labelSmallestValue.Location = new System.Drawing.Point(194, 149);
            this.labelSmallestValue.Name = "labelSmallestValue";
            this.labelSmallestValue.Size = new System.Drawing.Size(94, 13);
            this.labelSmallestValue.TabIndex = 9;
            this.labelSmallestValue.Text = "Not yet Calculated";
            // 
            // labelAverageValue
            // 
            this.labelAverageValue.AutoSize = true;
            this.labelAverageValue.Location = new System.Drawing.Point(194, 178);
            this.labelAverageValue.Name = "labelAverageValue";
            this.labelAverageValue.Size = new System.Drawing.Size(94, 13);
            this.labelAverageValue.TabIndex = 10;
            this.labelAverageValue.Text = "Not yet Calculated";
            // 
            // labelRangeValue
            // 
            this.labelRangeValue.AutoSize = true;
            this.labelRangeValue.Location = new System.Drawing.Point(194, 207);
            this.labelRangeValue.Name = "labelRangeValue";
            this.labelRangeValue.Size = new System.Drawing.Size(94, 13);
            this.labelRangeValue.TabIndex = 11;
            this.labelRangeValue.Text = "Not yet Calculated";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 257);
            this.Controls.Add(this.labelRangeValue);
            this.Controls.Add(this.labelAverageValue);
            this.Controls.Add(this.labelSmallestValue);
            this.Controls.Add(this.Values);
            this.Controls.Add(this.buttonCalculateRange);
            this.Controls.Add(this.buttonCalculateAverage);
            this.Controls.Add(this.buttonCalculateSmallest);
            this.Controls.Add(this.labelLargestValue);
            this.Controls.Add(this.buttonCalculateLargestValue);
            this.Controls.Add(this.numericUpDownNumber3);
            this.Controls.Add(this.numericUpDownNumber2);
            this.Controls.Add(this.numericUpDownNumber1);
            this.Name = "Form1";
            this.Text = "Independent Task1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNumber1;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber2;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber3;
        private System.Windows.Forms.Button buttonCalculateLargestValue;
        private System.Windows.Forms.Label labelLargestValue;
        private System.Windows.Forms.Button buttonCalculateSmallest;
        private System.Windows.Forms.Button buttonCalculateAverage;
        private System.Windows.Forms.Button buttonCalculateRange;
        private System.Windows.Forms.Label Values;
        private System.Windows.Forms.Label labelSmallestValue;
        private System.Windows.Forms.Label labelAverageValue;
        private System.Windows.Forms.Label labelRangeValue;
    }
}

