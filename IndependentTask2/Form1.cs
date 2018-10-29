using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndependentTask2
{
    public partial class Form1 : Form
    {

        // we have a list of 8 student ages.

        List<int> StudentAgeList => new List<int> {23, 25, 18, 19, 31, 47, 20, 19};

        private int Youngest => StudentAgeList.Min();
        private int Oldest => StudentAgeList.Max();
        private int Average => (int) StudentAgeList.Average();
        private int Total => StudentAgeList.Sum();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CopyStudentAgesToTextBox();
        }

        private void CopyStudentAgesToTextBox()
        {
            textBoxStudentAges.Text = string.Join(", ", StudentAgeList);
        }

        private void buttonCalculateOldest_Click(object sender, EventArgs e)
        {
            labelOldest.Text = SelectionSort(StudentAgeList)[StudentAgeList.Count-1].ToString(); //getOldest(StudentAgeList).ToString();

        }

        private int getOldest(List<int> ages)
        {
            int oldest = 0;

            foreach (int age in ages)
            {
                oldest = age >= oldest ? age : oldest;
            }

            return oldest;
        }

        private int getYoungest(List<int> ages)
        {
            int youngest = ages[0];

            foreach (int age in ages)
            {
                youngest = age <= youngest ? age : youngest;
            }

            return youngest;
        }

        private void buttonYoungest_Click(object sender, EventArgs e)
        {
            labelYoungest.Text = getYoungest(StudentAgeList).ToString();
        }

        private int getTotal(List<int> ages)
        {
            int total = 0;
            foreach (int age in ages)
            {
                total += age;
            }

            return total;
        }

        private double getAverage(List<int> ages)
        {
            return (double)getTotal(ages) / ages.Count;
        }

        private int getRange(List<int> ages)
        {
            return getOldest(ages) - getYoungest(ages);
        }

        private void labelYoungest_Click(object sender, EventArgs e)
        {
            labelYoungest.Text = getYoungest(StudentAgeList).ToString();
        }
        private void buttonTotal_Click(object sender, EventArgs e)
        {

            labelTotal.Text = getTotal(StudentAgeList).ToString();
        }

        private void buttonRange_Click(object sender, EventArgs e)
        {
            labelRange.Text = getRange(StudentAgeList).ToString();
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            labelAverage.Text = getAverage(StudentAgeList).ToString("F1");
        }

        private List<int> SelectionSort(List<int> list)
        {
            List<Int32> copy = list.ToList();
            int i, j;
            int n = copy.Count;

            for (j = 0; j < n - 1; j++)
            {
                int iMin = j;

                for (i = j + 1; i < n; i++)
                {
                    if (copy[i] < copy[iMin])
                    {
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    int toSwap = copy[iMin];
                    copy[iMin] = copy[j];
                    copy[j] = toSwap;
                }

            }

           

            return copy;
        }
    }
}
