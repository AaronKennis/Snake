using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class SnakeHead : Support.Texture
    {
        

        public SnakeHead(Vector2 position) : base("snake head", position, new Vector2(Board.Scale))
        {

        }

        public void Update(GameTime gametime)
        {
            //Position += deltaTranslate;
            //size += deltaScale;
            Vector2 previousPos = Position;
            if (Keyboard.GetState().IsKeyDown(Keys.Right) && IsPressedRight == false)
            {
                Position.X += (float)gametime.ElapsedGameTime.TotalSeconds * 5.5f;
                IsPressedRight = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Right) && IsPressedRight == true)
            {
                IsPressedRight = false;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Left) && IsPressedLeft == false)
            {
                Position.X -= (float)gametime.ElapsedGameTime.TotalSeconds * 5.5f;
                IsPressedLeft = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Left) && IsPressedLeft == true)
            {
                IsPressedLeft = false;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Down) && IsPressedDown == false)
            {
                Position.Y -= (float)gametime.ElapsedGameTime.TotalSeconds * 5.5f;
                IsPressedDown = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Down) && IsPressedDown == true)
            {
                IsPressedDown = false;
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Up) && IsPressedUp == false)
            {
                Position.Y += (float)gametime.ElapsedGameTime.TotalSeconds * 5.5f;
                IsPressedUp = true;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.Up) && IsPressedUp == true)
            {
                IsPressedUp = false;
            }
        }


    }
}
