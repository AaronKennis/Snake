using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Appel : Support.Texture
    {
        public int X;
        public int Y;

        public Appel(int x, int y) : base("appel", new Vector2(), new Vector2(Board.Scale))
        {
            Position = Board.getScreenPos(x, y);
            X = x;
            Y = y;
        }

    }
}
