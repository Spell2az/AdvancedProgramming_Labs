using System.Collections.Generic;
using System.Drawing;

namespace UsingGDI
{
    public class Drawing
    {
        private List<PointF> _pointList = new List<PointF>();
        private PointF _startPosition;
        public Color ShapeColor { get; set; }

        public PointF StartPosition
        {
            get => _startPosition;
            set
            {
                _startPosition = value;
                CreatePointList(value);
            }
        }

        public Drawing(PointF startPosition,Color shapeColor)
        {
            StartPosition = startPosition;
            ShapeColor = shapeColor;


        }

        private void CreatePointList(PointF startPoint)
        {
            float x = startPoint.X;
            float y = startPoint.Y;

            _pointList.Add(new PointF(x + 100, y + 0));
            _pointList.Add(new PointF(x + 200, y + 100));
            _pointList.Add(new PointF(x + 200, y + 300));
            _pointList.Add(new PointF(x + 0, y + 300));
            _pointList.Add(new PointF(x + 0, y + 100));
        }
        public void Move(float moveX, float moveY)
        {
            StartPosition = new PointF(StartPosition.X + moveX, StartPosition.Y + moveY);
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);

            Brush brush = new SolidBrush(ShapeColor);
            PointF[] pointArray = _pointList.ToArray();
            g.FillPolygon(brush, pointArray);
            g.DrawPolygon(pen, pointArray);

        }
    }
}