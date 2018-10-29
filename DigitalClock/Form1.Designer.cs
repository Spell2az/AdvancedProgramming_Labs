namespace DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.labelHours = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.checkBox24hour = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Fira Code iScript", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(-141, -4);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(0, 38);
            this.labelHours.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Fira Code iScript", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(279, 109);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 38);
            this.labelTime.TabIndex = 5;
            // 
            // checkBox24hour
            // 
            this.checkBox24hour.AutoSize = true;
            this.checkBox24hour.Checked = true;
            this.checkBox24hour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox24hour.Location = new System.Drawing.Point(276, 179);
            this.checkBox24hour.Name = "checkBox24hour";
            this.checkBox24hour.Size = new System.Drawing.Size(64, 17);
            this.checkBox24hour.TabIndex = 6;
            this.checkBox24hour.Text = "24 Hour";
            this.checkBox24hour.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 305);
            this.Controls.Add(this.checkBox24hour);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelHours);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.CheckBox checkBox24hour;
    }
}

