using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColorMatch
{
    public partial class ColorHelper
    {
        public static int Distance(Color firstColor, Color secondColor)
        {
            int redDistance = Math.Abs(firstColor.R - secondColor.R);
            int greenDistance = Math.Abs(firstColor.G - secondColor.G);
            int blueDistance = Math.Abs(firstColor.B - secondColor.B);

            return (int) Math.Sqrt(Square(redDistance) + Square(greenDistance) + Square(blueDistance));
        }

        private static int Square(int toSquare)
        {
            return toSquare * toSquare;
        }
    }
}
