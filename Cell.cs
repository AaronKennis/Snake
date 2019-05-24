using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Cell : Support.Texture
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Cell(int x, int y) : base("grass", new Vector2(), new Vector2(Board.Scale))
        {
            X = x;
            Y = y;

            Position = Board.getScreenPos(x, y);
        }
    }
}
