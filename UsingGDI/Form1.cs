using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingGDI
{
    public partial class Form1 : Form
    {
        Drawing drawing;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawing = new Drawing(new PointF(10, 10), Color.Blue);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            drawing.Draw(g);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            drawing.ShapeColor = Color.Red;
            pictureBox.Invalidate();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            drawing.ShapeColor = Color.Green;
            pictureBox.Invalidate();
            pictureBox.Refresh();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            drawing.Move(-10, 0);
            pictureBox.Invalidate();
        }
    }
}
