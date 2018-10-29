namespace ColorMatch
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuess = new System.Windows.Forms.PictureBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(703, 739);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Location = new System.Drawing.Point(27, 12);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(1425, 262);
            this.pictureBoxColor.TabIndex = 1;
            this.pictureBoxColor.TabStop = false;
            // 
            // pictureBoxGuess
            // 
            this.pictureBoxGuess.Location = new System.Drawing.Point(27, 292);
            this.pictureBoxGuess.Name = "pictureBoxGuess";
            this.pictureBoxGuess.Size = new System.Drawing.Size(1425, 260);
            this.pictureBoxGuess.TabIndex = 2;
            this.pictureBoxGuess.TabStop = false;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(298, 586);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(955, 45);
            this.trackBarRed.TabIndex = 3;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(298, 688);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(955, 45);
            this.trackBarBlue.TabIndex = 4;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(298, 637);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(955, 45);
            this.trackBarGreen.TabIndex = 5;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(222, 586);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(30, 13);
            this.labelRed.TabIndex = 6;
            this.labelRed.Text = "RED";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(222, 647);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(45, 13);
            this.labelGreen.TabIndex = 7;
            this.labelGreen.Text = "GREEN";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(222, 699);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(35, 13);
            this.labelBlue.TabIndex = 8;
            this.labelBlue.Text = "BLUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 887);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.pictureBoxGuess);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.buttonOK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.PictureBox pictureBoxGuess;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
    }
}

