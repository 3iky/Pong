using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong
{
    class Player
    {
        public enum Side { left, right };
        private Side _side;
        private Color _color;
        private Texture2D _player;
        private Rectangle _rect = new Rectangle(0, 0, 20, 150);
        public Player(Side side, Color color)
        {
            _side = side;
            _color = color;

            switch (_side)
            {
                case Side.left:
                    _rect.X = 20;
                    _rect.Y = 20;
                    break;
                case Side.right:
                    _rect.X = 800 - 50;//Main.WindowWidth - 20;
                    _rect.Y = 20;//Main.WindowHeight - 20;
                    break;
            }
        }

        public void Load()
        {
            _player = new Texture2D(Main.Graphics.GraphicsDevice, 1, 1);
            _player.SetData(new Color[] { Color.White });
        }

        public void Update()
        {
            Movement.KeyPress(this, _side);
        }

        public void Draw()
        {
            Main.Batch.Begin();
            Main.Batch.Draw(_player, _rect, _color);
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
    }
}
