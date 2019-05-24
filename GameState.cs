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
       


        List<SnakeBody> snakebody = new List<SnakeBody>();
        public int Score = 0;

        List<Appel> appels = new List<Appel>();
        

        public GameState()
        {
            appels.Add(new Appel(random.Next(Board.Width), random.Next(Board.Height)));
        }

        public void Update(GameTime gameTime)
        {
            snakehead.Update(gameTime);

            bool RemoveApples = false;
            foreach(var appel in appels)
            {
                if (snakehead.Collides(appel))
                {
                    Score++;
                    RemoveApples = true;
                    snakebody.Add(new SnakeBody(snakehead.Position));
                }
            }

            if (RemoveApples)
            {
                appels.Clear();
                appels.Add(new Appel(random.Next(Board.Width), random.Next(Board.Height)));
            }

            foreach(var body in snakebody)
            {
               if (snakehead.Collides(body))
               {
                   snakehead.Position = new Vector2(0.0f, 0f);
                   snakebody.Clear();
                   Score = 0;
                }
            }
            if (Support.Camera.GetCollision(snakehead) != Support.CollisionStatus.Inside)
            {
                snakehead.Position = new Vector2(0.0f, 0f);
                snakebody.Clear();
                Score = 0;
            }
        }

        public void Draw(GameTime gameTime)
        {
            board.Draw();
            foreach(var appel in appels)
            {
                appel.Draw();
            }
            Support.Font.PrintStatus("score: " + Score.ToString(), Color.Black);
            snakehead.Draw();
            foreach(var body in snakebody)
            {
                body.Draw();
            }
        }
    }
}
