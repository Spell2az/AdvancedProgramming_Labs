using System;
using System.Drawing;

namespace ColorMatch
{
   
        public class Game
        {
            private int guessRed, guessBlue, guessGreen;
            private Color targetColor;

            public Game()
            {
                var random = new Random();

                int red = random.Next(0, 255);
                int green = random.Next(0, 255);
                int blue = random.Next(0, 255);

                targetColor = Color.FromArgb(255, red, green, blue);
            }

            public Color TargetColor { get => targetColor; }

            public Color Guess { get => Color.FromArgb(255, guessRed, guessGreen, guessBlue); }

            public int GuessRed {
                get => guessRed;
                set => guessRed = value;
            }

            public int GuessGreen
            {
                get => guessGreen;
                set => guessGreen = value;
            }

        public int GuessBlue
        {
            get => guessBlue;
            set => guessBlue = value;
        }
    }
    
}
