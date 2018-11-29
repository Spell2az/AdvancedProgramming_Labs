namespace DictionaryExample
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
            this.labelChooseCountry = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelFindMillion = new System.Windows.Forms.Label();
            this.labelFind = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.textBoxPopulation = new System.Windows.Forms.TextBox();
            this.numericUpDownFind = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseCountry
            // 
            this.labelChooseCountry.AutoSize = true;
            this.labelChooseCountry.Location = new System.Drawing.Point(42, 48);
            this.labelChooseCountry.Name = "labelChooseCountry";
            this.labelChooseCountry.Size = new System.Drawing.Size(76, 13);
            this.labelChooseCountry.TabIndex = 0;
            this.labelChooseCountry.Text = "Choose Coutry";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(396, 48);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(57, 13);
            this.labelPopulation.TabIndex = 1;
            this.labelPopulation.Text = "Population";
            // 
            // labelFindMillion
            // 
            this.labelFindMillion.AutoSize = true;
            this.labelFindMillion.Location = new System.Drawing.Point(308, 186);
            this.labelFindMillion.Name = "labelFindMillion";
            this.labelFindMillion.Size = new System.Drawing.Size(35, 13);
            this.labelFindMillion.TabIndex = 2;
            this.labelFindMillion.Text = "million";
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(42, 186);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(179, 13);
            this.labelFind.TabIndex = 3;
            this.labelFind.Text = "Countries with population grater than";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(45, 254);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(45, 77);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(261, 21);
            this.comboBoxCountry.TabIndex = 5;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // textBoxPopulation
            // 
            this.textBoxPopulation.Location = new System.Drawing.Point(399, 77);
            this.textBoxPopulation.Name = "textBoxPopulation";
            this.textBoxPopulation.Size = new System.Drawing.Size(200, 20);
            this.textBoxPopulation.TabIndex = 6;
            // 
            // numericUpDownFind
            // 
            this.numericUpDownFind.Location = new System.Drawing.Point(227, 184);
            this.numericUpDownFind.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownFind.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFind.Name = "numericUpDownFind";
            this.numericUpDownFind.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownFind.TabIndex = 7;
            this.numericUpDownFind.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownFind);
            this.Controls.Add(this.textBoxPopulation);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.labelFindMillion);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.labelChooseCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseCountry;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.Label labelFindMillion;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.TextBox textBoxPopulation;
        private System.Windows.Forms.NumericUpDown numericUpDownFind;
    }
}

