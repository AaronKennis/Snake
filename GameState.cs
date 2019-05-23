using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class GameState
    {
        SnakeHead snakehead = new SnakeHead(new Vector2(0.0f, 0f)) ;

        public static Random random = new Random();
        Appel appel = new Appel(new Vector2(-1 + (float)(random.NextDouble() * 2), -1 + (float)(random.NextDouble() * 2)));


        public GameState()
        {

        }

        public void Update(GameTime gameTime)
        {
            snakehead.Update(gameTime);
        }

        public void Draw(GameTime gameTime)
        {
            snakehead.Draw();
            appel.Draw();
        }
    }
}
