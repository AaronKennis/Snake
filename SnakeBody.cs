using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class SnakeBody : Support.Texture
    {
        public SnakeBody(Vector2 position) : base("snake body", position, new Vector2(0, 111f))
        {

        }
    }
}
