using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IndependentTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<int> FormValues
        {
            get
            {
                int number1 = Convert.ToInt32(numericUpDownNumber1.Value);
                int number2 = Convert.ToInt32(numericUpDownNumber2.Value);
                int number3 = Convert.ToInt32(numericUpDownNumber3.Value);

                return new List<int> { number1, number2, number3 };
            }
        }

        public int SmallestValue => FormValues.Min();
        public int LargestValue => FormValues.Max();
        public double AverageValue => FormValues.Average();
        public int Range => LargestValue - SmallestValue;

        private void buttonCalculateLargestValue_Click(object sender, EventArgs e)
        {
          
            labelLargestValue.Text = LargestValue.ToString();

        }

        private void buttonCalculateSmallest_Click(object sender, EventArgs e)
        {
            labelSmallestValue.Text = SmallestValue.ToString();
        }

        private void buttonCalculateAverage_Click(object sender, EventArgs e)
        {
            labelAverageValue.Text = AverageValue.ToString("F1");
        }

        private void buttonCalculateRange_Click(object sender, EventArgs e)
        {
            labelRangeValue.Text = Range.ToString();
        }
    }
}
