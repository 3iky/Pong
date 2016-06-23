using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong
{
    class Ball
    {
        private Texture2D _ball;
        private Rectangle _rect;

        public Ball() {; }

        public void Load()
        {
            _ball = new Texture2D(Main.Graphics.GraphicsDevice, 1, 1);
            _ball.SetData(new Color[] { Color.White });
            // take 1 pixel
            // add diameter
            // multiply by pi
            _rect = new Rectangle(250, 250, 20, 20);
        }

        public void Update(Player player)
        {
            Movement.AutoMove(this, player);
        }

        public void Draw()
        {
            Main.Batch.Begin();
            Main.Batch.Draw(_ball, _rect, Color.White);
            Main.Batch.End();
        }

        public int X
        {
            get { return _rect.X; }
            set { _rect.X = value; }
        }

        public int Y
        {
            get { return _rect.Y; }
            set { _rect.Y = value; }
        }

        public int Width
        {
            get { return _rect.Width; }
        }

        public int Height
        {
            get { return _rect.Height; }
        }
    }
}
