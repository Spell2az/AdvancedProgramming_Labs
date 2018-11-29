using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analog_Clock
{
    public partial class Form1 : Form
    {
        private Clock clock;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxClock.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clock = new Clock( pictureBoxClock.Width, pictureBoxClock.Height, 0);

            timer1.Interval = 500;
            timer1.Start();
        }

        private void pictureBoxClock_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            clock.Draw(g);
        }
    }
}
