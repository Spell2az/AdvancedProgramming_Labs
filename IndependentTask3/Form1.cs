using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// use GDI
using System.Drawing;


namespace IndependentTask3
{
    public partial class Form1 : Form
    {

        double width = 5.0;
        double height = 2.5;

        double doorWidth = 1.5;
        double doorHeight = 2;

        double coveragePerTinOfPaint = 5.0;

        double costOfPaintPerTin = 10.50;

        bool formLoaded = false;
        
        public Form1()
        {
            InitializeComponent();

            numericUpDownWidth.Value = (decimal)width;
            numericUpDownHeight.Value = (decimal)height;
            numericUpDownDoorWidth.Value = (decimal)doorWidth;
            numericUpDownDoorHeight.Value = (decimal)doorHeight;
            CaclulateAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formLoaded = true;

            labelCoveragePerTin.Text = string.Format("Coverage per tin: {0} sq m", coveragePerTinOfPaint);

            labelCostPerTin.Text = string.Format("Cost per tin £{0:0.00}", costOfPaintPerTin);
        }


        private void pictureBoxDisplay_Paint(object sender, PaintEventArgs e)
        {
            // this code scales to wall picture to fit
            // there is no need to modify this code and
            // you are welcome to look at it but you
            // do not need to follow it...

            double border = 32;

            // calculate usable area
            double pictureBoxWidth = pictureBoxDisplay.Width - border;
            double pictureBoxHeight = pictureBoxDisplay.Height - border;

            try
            {
                double scaleFactorX = pictureBoxWidth / width;
                double scaleFactorY = pictureBoxHeight / height;

                // choose the smaller scale
                double scale = scaleFactorX > scaleFactorY ? scaleFactorY : scaleFactorX;

                double offsetX = border / 2 + (pictureBoxWidth - scale * width) / 2;
                double offsetY = border / 2 + (pictureBoxHeight - scale * height) / 2;

                PointF[] wallPoints = new PointF[8];
                // PointF constructor needs to floats so we must convert.
                wallPoints[0] = new PointF(Convert.ToSingle(offsetX), Convert.ToSingle(offsetY));
                wallPoints[1] = new PointF(Convert.ToSingle(offsetX), Convert.ToSingle(offsetY + height * scale));
                wallPoints[2] = new PointF(Convert.ToSingle(offsetX + (width / 2 - doorWidth / 2) * scale), Convert.ToSingle(offsetY + height * scale));
                wallPoints[3] = new PointF(Convert.ToSingle(offsetX + (width / 2 - doorWidth / 2) * scale), Convert.ToSingle(offsetY + (height - doorHeight) * scale));
                wallPoints[4] = new PointF(Convert.ToSingle(offsetX + (width / 2 + doorWidth / 2) * scale), Convert.ToSingle(offsetY + (height - doorHeight) * scale));
                wallPoints[5] = new PointF(Convert.ToSingle(offsetX + (width / 2 + doorWidth / 2) * scale), Convert.ToSingle(offsetY + height * scale));
                wallPoints[6] = new PointF(Convert.ToSingle(offsetX + width * scale), Convert.ToSingle(offsetY + height * scale));
                wallPoints[7] = new PointF(Convert.ToSingle(offsetX + width * scale), Convert.ToSingle(offsetY));

                // draw a scale...
                PointF[] scalePoints = new PointF[7];
                scalePoints[0] = new PointF(Convert.ToSingle(offsetX), Convert.ToSingle(pictureBoxDisplay.Height - 8));
                scalePoints[1] = new PointF(Convert.ToSingle(offsetX), Convert.ToSingle(pictureBoxDisplay.Height - 4));
                scalePoints[2] = new PointF(Convert.ToSingle(offsetX + scale), Convert.ToSingle(pictureBoxDisplay.Height - 4));
                scalePoints[3] = new PointF(Convert.ToSingle(offsetX + scale), Convert.ToSingle(pictureBoxDisplay.Height - 8));
                scalePoints[4] = new PointF(Convert.ToSingle(offsetX + scale), Convert.ToSingle(pictureBoxDisplay.Height - 4));
                scalePoints[5] = new PointF(Convert.ToSingle(offsetX + 2 * scale), Convert.ToSingle(pictureBoxDisplay.Height - 4));
                scalePoints[6] = new PointF(Convert.ToSingle(offsetX + 2 * scale), Convert.ToSingle(pictureBoxDisplay.Height - 8));

                Graphics g = e.Graphics;

                Brush brush = new SolidBrush(Color.Red);
                Pen pen = new Pen(Color.Black, 2);

                g.DrawLines(pen, scalePoints);

                g.FillPolygon(brush, wallPoints);
                g.DrawPolygon(pen, wallPoints);
                


            }
            catch (Exception ex)
            {
            }

        }

        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                ReadUserData();
                CaclulateAll();
                // force a redraw
                pictureBoxDisplay.Invalidate();
            }
        }

        private void numericUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                ReadUserData();
                CaclulateAll();
                // force a redraw
                pictureBoxDisplay.Invalidate();
            }
        }

        private void numericUpDownDoorWidth_ValueChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                ReadUserData();
                CaclulateAll();
                // force a redraw
                pictureBoxDisplay.Invalidate();
            }
        }

        private void numericUpDownDoorHeight_ValueChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                ReadUserData();
                CaclulateAll();
                // force a redraw
                pictureBoxDisplay.Invalidate();
            }
        }

        private void ReadUserData()
        {
            // we validate the data in the controls
            // before we read into variables, so the
            // user can see the validated values..


            // the door cannot be wider than the wall
            if (numericUpDownDoorWidth.Value > numericUpDownWidth.Value)
            {
                numericUpDownDoorWidth.Value = numericUpDownWidth.Value;
            }

            // and it cannot be higher
            if (numericUpDownDoorHeight.Value > numericUpDownHeight.Value)
            {
                numericUpDownDoorHeight.Value = numericUpDownHeight.Value;
            }


            width = (float)numericUpDownWidth.Value;
            height = (float)numericUpDownHeight.Value;
            doorWidth = (float)numericUpDownDoorWidth.Value;
            doorHeight = (float)numericUpDownDoorHeight.Value;
        }

        public void CaclulateAll()
        {
            double wallArea = width * height;
            double doorArea = doorHeight * doorWidth;
            double paintArea = wallArea - doorArea;

            textBoxArea.Text = paintArea.ToString("F");


            // using the variable coveragePerTinOfPaint
            int tins = (int)Math.Ceiling(paintArea / coveragePerTinOfPaint);

            textBoxNumberOfTins.Text = tins.ToString("####");

            textBoxCost.Text = (tins * costOfPaintPerTin).ToString("F");
        }
        
    }
}
