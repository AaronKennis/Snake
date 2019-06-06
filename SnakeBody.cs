using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class SnakeBody : Support.Texture
    {
        public int X;
        public int Y;

        public SnakeBody(int x,int y) : base("snake body", Board.getScreenPos(x,y), new Vector2(0.072f))
        {
            X = x;
            Y = y;
        }

        public void UpdatePos(int x, int y)
        {
            Position = Board.getScreenPos(x, y);
            X = x;
            Y = y;
        }
    }
}
