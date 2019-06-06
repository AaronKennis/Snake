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
 bettersnakepos
        
        int previousposx;
        int previousposy;
        

        backgroundS backgroundS = new backgroundS();
        backgroundN backgroundN = new backgroundN();
        backgroundA backgroundA = new backgroundA();
        backgroundK backgroundK = new backgroundK();
        backgroundE backgroundE = new backgroundE();
        backgroundsnake backgroundsnake = new backgroundsnake();
        backgroundsnake2 backgroundsnake2 = new backgroundsnake2();
        SnakeHead snakehead = new SnakeHead(new Vector2(0.0f, 0f)) ;
 master

        public static Random random = new Random();

        SnakeHead snakehead = new SnakeHead();
        List<SnakeBody> snakebody = new List<SnakeBody>();

        public int Score = 0;

        List<Appel> appels = new List<Appel>();
        

        public GameState()
        {
            appels.Add(new Appel(random.Next(Board.Width), random.Next(Board.Height)));
            
        }

        public void Update(GameTime gameTime)
        {
            previousposx = snakehead.X;
            previousposy = snakehead.Y;

            if (snakehead.Update(gameTime))
            {
                foreach(var part in snakebody)
                {
                    int previousPartX = part.X;
                    int previousPartY = part.Y;

                    part.UpdatePos(previousposx, previousposy);
                    previousposx = previousPartX;
                    previousposy = previousPartY;
                }
            }

            

            bool RemoveApples = false;
            bool RemoveBody = false;

            foreach (var appel in appels)
            {
                if (snakehead.Collides(appel))
                {
                    Score++;
                    RemoveApples = true;
                    snakebody.Add(new SnakeBody(previousposx, previousposy));
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
                    RemoveBody = true;
                }
                
            }
            if (RemoveBody)
            {
                snakebody.Clear();
                snakehead.Reset();
                Score = 0;
            }
            

            if (snakehead.X >= Board.Width || snakehead.Y >= Board.Height)
            {
                snakehead.Reset();
                snakebody.Clear();
                Score = 0;
            }
        }

        public void Draw(GameTime gameTime)
        {
            backgroundS.Draw();
            backgroundN.Draw();
            backgroundA.Draw();
            backgroundK.Draw();
            backgroundE.Draw();
            backgroundsnake.Draw();
            backgroundsnake2.Draw();
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
