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
        Board board = new Board();
        SnakeHead snakehead = new SnakeHead(new Vector2(0.0f, 0f)) ;

        public static Random random = new Random();
        Appel appel = new Appel(random.Next(Board.Width), random.Next(Board.Height));

        

        public GameState()
        {

        }

        public void Update(GameTime gameTime)
        {
            snakehead.Update(gameTime);
        }

        public void Draw(GameTime gameTime)
        {
            board.Draw();
            appel.Draw();
            snakehead.Draw();
            
        }
    }
}
