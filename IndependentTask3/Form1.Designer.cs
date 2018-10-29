namespace IndependentTask3
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDoorWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDoorHeight = new System.Windows.Forms.NumericUpDown();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelDoorWidth = new System.Windows.Forms.Label();
            this.labelDoorHeight = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.labelCoveragePerTin = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelNumberOfTins = new System.Windows.Forms.Label();
            this.textBoxNumberOfTins = new System.Windows.Forms.TextBox();
            this.labelCostPerTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoorWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoorHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(10, 11);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(405, 226);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDisplay_Paint);
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.DecimalPlaces = 1;
            this.numericUpDownWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWidth.Location = new System.Drawing.Point(93, 246);
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownWidth.TabIndex = 1;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.DecimalPlaces = 1;
            this.numericUpDownHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHeight.Location = new System.Drawing.Point(93, 274);
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownHeight.TabIndex = 2;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownHeight.ValueChanged += new System.EventHandler(this.numericUpDownHeight_ValueChanged);
            // 
            // numericUpDownDoorWidth
            // 
            this.numericUpDownDoorWidth.DecimalPlaces = 1;
            this.numericUpDownDoorWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDoorWidth.Location = new System.Drawing.Point(93, 300);
            this.numericUpDownDoorWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDoorWidth.Name = "numericUpDownDoorWidth";
            this.numericUpDownDoorWidth.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownDoorWidth.TabIndex = 3;
            this.numericUpDownDoorWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDoorWidth.ValueChanged += new System.EventHandler(this.numericUpDownDoorWidth_ValueChanged);
            // 
            // numericUpDownDoorHeight
            // 
            this.numericUpDownDoorHeight.DecimalPlaces = 1;
            this.numericUpDownDoorHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDoorHeight.Location = new System.Drawing.Point(93, 327);
            this.numericUpDownDoorHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDoorHeight.Name = "numericUpDownDoorHeight";
            this.numericUpDownDoorHeight.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownDoorHeight.TabIndex = 4;
            this.numericUpDownDoorHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownDoorHeight.ValueChanged += new System.EventHandler(this.numericUpDownDoorHeight_ValueChanged);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(35, 248);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(52, 13);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "Width (m)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(35, 276);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(55, 13);
            this.labelHeight.TabIndex = 6;
            this.labelHeight.Text = "Height (m)";
            // 
            // labelDoorWidth
            // 
            this.labelDoorWidth.AutoSize = true;
            this.labelDoorWidth.Location = new System.Drawing.Point(12, 302);
            this.labelDoorWidth.Name = "labelDoorWidth";
            this.labelDoorWidth.Size = new System.Drawing.Size(75, 13);
            this.labelDoorWidth.TabIndex = 7;
            this.labelDoorWidth.Text = "Door width (m)";
            // 
            // labelDoorHeight
            // 
            this.labelDoorHeight.AutoSize = true;
            this.labelDoorHeight.Location = new System.Drawing.Point(8, 329);
            this.labelDoorHeight.Name = "labelDoorHeight";
            this.labelDoorHeight.Size = new System.Drawing.Size(79, 13);
            this.labelDoorHeight.TabIndex = 8;
            this.labelDoorHeight.Text = "Door height (m)";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(218, 254);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(96, 13);
            this.labelArea.TabIndex = 9;
            this.labelArea.Text = "Area of Wall (sq m)";
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(320, 251);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(79, 20);
            this.textBoxArea.TabIndex = 11;
            // 
            // labelCoveragePerTin
            // 
            this.labelCoveragePerTin.AutoSize = true;
            this.labelCoveragePerTin.Location = new System.Drawing.Point(248, 276);
            this.labelCoveragePerTin.Name = "labelCoveragePerTin";
            this.labelCoveragePerTin.Size = new System.Drawing.Size(62, 13);
            this.labelCoveragePerTin.TabIndex = 12;
            this.labelCoveragePerTin.Text = "Coverage...";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(271, 350);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(43, 13);
            this.labelCost.TabIndex = 13;
            this.labelCost.Text = "Cost (£)";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(320, 347);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(79, 20);
            this.textBoxCost.TabIndex = 14;
            // 
            // labelNumberOfTins
            // 
            this.labelNumberOfTins.AutoSize = true;
            this.labelNumberOfTins.Location = new System.Drawing.Point(200, 298);
            this.labelNumberOfTins.Name = "labelNumberOfTins";
            this.labelNumberOfTins.Size = new System.Drawing.Size(114, 13);
            this.labelNumberOfTins.TabIndex = 15;
            this.labelNumberOfTins.Text = "Number of tins needed";
            // 
            // textBoxNumberOfTins
            // 
            this.textBoxNumberOfTins.Location = new System.Drawing.Point(320, 295);
            this.textBoxNumberOfTins.Name = "textBoxNumberOfTins";
            this.textBoxNumberOfTins.Size = new System.Drawing.Size(79, 20);
            this.textBoxNumberOfTins.TabIndex = 16;
            // 
            // labelCostPerTin
            // 
            this.labelCostPerTin.AutoSize = true;
            this.labelCostPerTin.Location = new System.Drawing.Point(248, 324);
            this.labelCostPerTin.Name = "labelCostPerTin";
            this.labelCostPerTin.Size = new System.Drawing.Size(61, 13);
            this.labelCostPerTin.TabIndex = 17;
            this.labelCostPerTin.Text = "Cost Per tin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 428);
            this.Controls.Add(this.labelCostPerTin);
            this.Controls.Add(this.textBoxNumberOfTins);
            this.Controls.Add(this.labelNumberOfTins);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelCoveragePerTin);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelDoorHeight);
            this.Controls.Add(this.labelDoorWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.numericUpDownDoorHeight);
            this.Controls.Add(this.numericUpDownDoorWidth);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoorWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDoorHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownDoorWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownDoorHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelDoorWidth;
        private System.Windows.Forms.Label labelDoorHeight;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.Label labelCoveragePerTin;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelNumberOfTins;
        private System.Windows.Forms.TextBox textBoxNumberOfTins;
        private System.Windows.Forms.Label labelCostPerTin;
    }
}

