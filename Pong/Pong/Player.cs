using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong
{
    class Player
    {
        public enum Side { left, right };
        private Side _side;
        private Color _color;
        private Texture2D rect;
        public Player(Side side, Color color)
        {
            _side = side;
            _color = color;

            
        }

        public void Load()
        {
            rect = new Texture2D(Main.Graphics.GraphicsDevice, 80, 30);
            //rect.SetData(new[] { Color.White });
        }

        public void Draw()
        {
            Main.Batch.Draw(rect, new Rectangle(20, 20,20,20), Color.White);
        }

    }
}
