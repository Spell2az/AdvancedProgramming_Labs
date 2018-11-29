using System;

using System.Drawing;
using System.Drawing.Text;

namespace Analog_Clock
{
    public class Clock
    {
        private int timeDifference;

        private bool minuteHandMovesWithSeconds = false;
        private int ySign = 1;

        private float width;
        private float height;

        private float centerX;
        private float centerY;

        private float halfWidth;
        private float halfHeight;

        private float widthHourX;
        private float heightHourY;

        private float dialWidth;
        private float dialHeight;

        private float innerCircleWidth;
        private float redInnerCircleWidth;

        private float penThickness;

        private Pen blackPen;
        private Pen redPen;

        private Brush blackBrush;
        private Brush redBrush;

        public Clock(int width, int height, int timezone)
        {
            this.timeDifference = timezone;
            SetClockSize(width, height);
            CreatePensAndBrushes();
        }

        private void CreatePensAndBrushes()
        {
            blackPen = new Pen(Color.Black, penThickness);
            redPen = new Pen(Color.Red, 3);

            blackBrush = new SolidBrush(Color.Black);
            redBrush = new SolidBrush(Color.Red);
        }

        private void SetClockSize(int width, int height)
        {
            this.width = width;
            this.height = height;


            centerX = halfWidth = width / 2;
            centerY = halfHeight = height / 2;

            dialWidth = width * 0.45f;
            dialHeight = height * 0.45f;

            widthHourX = dialWidth * 0.7f;
            heightHourY = dialHeight * 0.7f;

            innerCircleWidth = width * 0.04f;
            redInnerCircleWidth = width * 0.02f;

            penThickness = width * 0.015f;
            penThickness = penThickness > 1 ? penThickness : 1;

        }


        public void Draw(Graphics g)
        {
            DateTime currenTime = DateTime.Now;

            int hour = currenTime.Hour + timeDifference;
            int minute = currenTime.Minute;
            int second = currenTime.Second;

            double hourModTwelve = Convert.ToDouble(hour % 12);
            double hourExtraForMinutes = Convert.ToDouble(minute) / 60.0;
            double minuteExtraForSeconds = minuteHandMovesWithSeconds ? Convert.ToDouble(second) / 60.0 : 0;

            const double hourHandSteps = 12.0;
            const double minuteAndSecondSteps = 60.0;

            double hourAngle = 2 * Math.PI * ((hourModTwelve + hourExtraForMinutes) / hourHandSteps);
            double minuteAngle = 2 * Math.PI * ((minute + minuteExtraForSeconds) / minuteAndSecondSteps);
            double secondAngle = 2 * Math.PI * (second / minuteAndSecondSteps);

            DrawClockMarkings(g);

            DrawHourHand(g, hourAngle);
            DrawMinuteHand(g, minuteAngle);
            DrawSecondHand(g, secondAngle);
        }

        private void DrawSecondHand(Graphics g, double secondAngle)
        {
            g.DrawLine(redPen,
                centerX,
                centerY,
                centerX + ySign * (dialWidth * Convert.ToSingle(Math.Sin(secondAngle))),
                centerY - dialHeight * Convert.ToSingle(Math.Cos(secondAngle)));

            // draw a red blob at the centre
            g.FillEllipse(redBrush, centerX - (redInnerCircleWidth / 2), centerY - (redInnerCircleWidth / 2), redInnerCircleWidth, redInnerCircleWidth);

        }

        private void DrawMinuteHand(Graphics g, double minuteAngle)
        {
            g.DrawLine(blackPen,
                centerX,
                centerY,
                centerX + ySign * (dialWidth * Convert.ToSingle(Math.Sin(minuteAngle))),
                centerY - dialHeight * Convert.ToSingle(Math.Cos(minuteAngle)));

            // draw a blob in the centre
            g.FillEllipse(blackBrush, centerX - (innerCircleWidth / 2), centerY - (innerCircleWidth / 2), innerCircleWidth, innerCircleWidth);

        }

        private void DrawHourHand(Graphics g, double hourAngle)
        {
            g.DrawLine(blackPen,
                centerX,
                centerY,
                centerX + ySign * (widthHourX * Convert.ToSingle(Math.Sin(hourAngle))),
                centerY - heightHourY * Convert.ToSingle(Math.Cos(hourAngle)));

        }

        private void DrawClockMarkings(Graphics g)
        {
            for (int minuteTick = 0; minuteTick < 60; minuteTick++)
            {
                double theta = 2 * Math.PI * minuteTick / 60.0;
                float thickness = 0.05f;

                if (minuteTick % 5 == 0)
                {
                    thickness = 0.15f;
                }

                g.DrawLine(blackPen,
                    centerX + (1.0f - thickness) * dialWidth * Convert.ToSingle(Math.Sin(theta)),
                    centerY + (1.0f - thickness) * dialHeight * Convert.ToSingle(Math.Cos(theta)),
                    centerX + 1.0f * dialWidth * Convert.ToSingle(Math.Sin(theta)),
                    centerY + 1.0f * dialHeight * Convert.ToSingle(Math.Cos(theta)));
            }
        }
    }
}