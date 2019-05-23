using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Board
    {
        List<List<Cell>> cells = new List<List<Cell>>();

        const int Width = 23;
        const int Height = 19;
        const float Scale = 0.111f;

        public Board()
        {
            for (int x = 0; x < Width; x++)
            {
                cells.Add(new List<Cell>());

                for (int y = 0; y < Height; y++)
                {
                    cells[x].Add(new Cell(x, y));
                }
            }
        }

        public void Draw()
        {
            cells.ForEach(
                column => column.ForEach(
                    cell => cell.Draw()
                )
            );
        }

        public static Vector2 getScreenPos(int x, int y)
        {
            return new Vector2(-1.2f + x * Scale, -1.0f + Scale / 2 + y * Scale);
        }
    }
}
