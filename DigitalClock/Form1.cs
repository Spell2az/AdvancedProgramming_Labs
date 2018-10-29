using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            labelTime.Text = checkBox24hour.Checked ? DateTime.Now.ToString("HH:mm:ss") : DateTime.Now.ToString("h:mm:ss tt");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 200;

            timer1.Start();
        }
    }
}
