using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong
{
    class Movement
    {
        private static int _index;
        public static void KeyPress(Player player, Player.Side side)
        {
            KeyboardState _keys = Keyboard.GetState(PlayerIndex.One);
            GamePadState _pad = GamePad.GetState(PlayerIndex.One);

            if (side == Player.Side.left)
            {
                if (_keys.IsKeyDown(Keys.Up))
                {
                    player.Y = player.Y - 3;
                }
                else if (_keys.IsKeyDown(Keys.Down))
                {
                    player.Y = player.Y + 3;
                }
            }
            else if (side == Player.Side.right)
                if (_keys.IsKeyDown(Keys.W))
                {
                    player.Y = player.Y - 3;
                }
                else if (_keys.IsKeyDown(Keys.S))
                {
                    player.Y = player.Y + 3;
                }
        }

        public static void AutoMove(Ball ball, Player player)
        {
            if (ball.X != 0 || ball.Y != -20)
            {
                _index += (Main.WindowWidth * ball.Y);
                _index += (ball.X + ball.Width);
                if (_index == player.X && _index == player.Y)
                {
                    return;
                }
                else
                {
                    ball.X = ball.X + 1;
                    ball.Y = ball.Y - 1;
                }
            }
            else
            {
                ball.X = 250;
                ball.Y = 250; ;
            }
        }
    }
}
