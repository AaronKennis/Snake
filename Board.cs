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

        public Board()
        {
            for (int x = 0; x < 23; x++)
            {
                cells.Add(new List<Cell>());

                for (int y = 0; y < 19; y++)
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
            return new Vector2(-1.2f + x * 0.111f, -1.0f + 0.111f / 2 + y * 0.111f);
        }
    }
}
