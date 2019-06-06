using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MyGame.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class SnakeHead : Support.Texture
    {
        public int X, Y;
        private Direction direction = Direction.Right; 

        public SnakeHead() : base("snake head", Board.getScreenPos(10, 10), new Vector2(Board.Scale))
        {
            Reset();
        }

        public void Reset()
        {
            X = 10;
            Y = 10;
        }

        public bool Update(GameTime gametime)
        {
            bool posChanged = false;
            //Position += deltaTranslate;
            //size += deltaScale;
            Vector2 previousPos = Position;
            if (Keyboard.GetState().IsKeyDown(Keys.Right) && IsPressedRight == false)
            {
                X++;
                posChanged = true;
                direction = Direction.Right;
                IsPressedRight = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Right) && IsPressedRight == true)
            {
                IsPressedRight = false;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Left) && IsPressedLeft == false)
            {
                X--;
                posChanged = true;
                IsPressedLeft = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Left) && IsPressedLeft == true)
            {
                IsPressedLeft = false;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Down) && IsPressedDown == false)
            {
                Y--;
                posChanged = true;
                IsPressedDown = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Down) && IsPressedDown == true)
            {
                IsPressedDown = false;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Up) && IsPressedUp == false)
            {
                Y++;
                posChanged = true;
                IsPressedUp = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Up) && IsPressedUp == true)
            {
                IsPressedUp = false;
            }

            Position = Board.getScreenPos(X, Y);

            return posChanged;
        }


    }
}
